import customtkinter as ctk
from tkinter import filedialog, messagebox
import subprocess
import threading
import os
import sys

# PyInstaller ile gömülü dosyaların yolunu bulan fonksiyon
def resource_path(relative_path):
    """Dev ortamı ve PyInstaller (sys._MEIPASS) için mutlak dosya yolunu getirir."""
    try:
        base_path = sys._MEIPASS
    except Exception:
        base_path = os.path.abspath(".")
    return os.path.join(base_path, relative_path)

class ConverterApp(ctk.CTk):
    def __init__(self):
        super().__init__()

        # ---------------- Temel Pencere Ayarları ----------------
        self.title("320 kbps converter")
        self.geometry("400x180")
        self.resizable(False, False)
        ctk.set_appearance_mode("dark")

        # İkon Ayarlama
        try:
            self.iconbitmap(resource_path("icon.ico"))
        except Exception:
            pass 

        # ---------------- Renk Tanımları ----------------
        self.color_red_bg = "#A02525"
        self.color_red_btn = "#A93232"
        self.color_red_btn_hover = "#B83E3E"
        self.color_dark_bg = "#1E2429"
        self.color_text_white = "#FFFFFF"
        self.color_text_grey = "#88929B"

        self.configure(fg_color=self.color_dark_bg)

        # ---------------- Özel Başlık Çubuğu ----------------
        self.title_bar_frame = ctk.CTkFrame(self, height=40, corner_radius=0, fg_color=self.color_red_bg)
        self.title_bar_frame.pack(side="top", fill="x", anchor="n")
        self.title_bar_frame.pack_propagate(False)

        self.title_label = ctk.CTkLabel(self.title_bar_frame, text="320 kbps converter", font=("Helvetica", 16, "bold"), text_color=self.color_text_white)
        self.title_label.pack(side="left", padx=15, pady=(0, 2))

        self.title_bar_frame.bind("<ButtonPress-1>", self.start_move)
        self.title_bar_frame.bind("<B1-Motion>", self.do_move)
        self.title_label.bind("<ButtonPress-1>", self.start_move)
        self.title_label.bind("<B1-Motion>", self.do_move)

        self.close_button = ctk.CTkButton(self.title_bar_frame, text="✕", width=30, height=30, fg_color="transparent", hover_color=self.color_red_btn_hover, command=self.close_window)
        self.close_button.pack(side="right", padx=(0, 5))

        self.minimize_button = ctk.CTkButton(self.title_bar_frame, text="—", width=30, height=30, fg_color="transparent", hover_color=self.color_red_btn_hover, command=self.minimize_window)
        self.minimize_button.pack(side="right", padx=(0, 5))

        # ---------------- Ana İçerik Alanı ----------------
        self.main_frame = ctk.CTkFrame(self, fg_color=self.color_dark_bg, corner_radius=0)
        self.main_frame.pack(side="top", fill="both", expand=True)

        self.convert_button = ctk.CTkButton(self.main_frame, text="CONVERT", font=("Helvetica", 15, "bold"),
                                            fg_color=self.color_red_btn, hover_color=self.color_red_btn_hover,
                                            command=self.start_conversion_thread, width=160, height=45, corner_radius=8)
        self.convert_button.place(relx=0.5, rely=0.4, anchor="center")

        # ---------------- Alt Bilgi Etiketleri ----------------
        self.version_label = ctk.CTkLabel(self.main_frame, text="v1.3", font=("Helvetica", 12), text_color=self.color_text_grey)
        self.version_label.place(relx=0.05, rely=0.9, anchor="sw")

        self.programmer_label = ctk.CTkLabel(self.main_frame, text="Programmed by BartuAbiHD", font=("Helvetica", 12), text_color=self.color_text_white)
        self.programmer_label.place(relx=0.5, rely=0.9, anchor="s")

        self.overrideredirect(True)
        self.center_window()
        
        self.after(10, self.setup_window_hacks)

    def force_taskbar_icon(self):
        """Pencereyi zorla görev çubuğuna ekleyen Windows API hilesi"""
        if os.name == 'nt':
            import ctypes
            hwnd = ctypes.windll.user32.GetParent(self.winfo_id())
            if hwnd == 0:
                hwnd = self.winfo_id()
            style = ctypes.windll.user32.GetWindowLongW(hwnd, -20)
            style = style & ~0x00000080 | 0x00040000
            ctypes.windll.user32.SetWindowLongW(hwnd, -20, style)

    def setup_window_hacks(self):
        """Program ilk açıldığında görev çubuğunda gösterme ve öne getirme"""
        self.force_taskbar_icon()
        self.wm_withdraw()
        self.after(10, self._show_and_focus)

    def _show_and_focus(self):
        self.wm_deiconify()
        self.apply_rounded_corners() 
        
        self.attributes('-topmost', True)
        self.focus_force()
        self.after(200, lambda: self.attributes('-topmost', False))

    def center_window(self):
        self.update_idletasks()
        width = self.winfo_width()
        height = self.winfo_height()
        x = (self.winfo_screenwidth() // 2) - (width // 2)
        y = (self.winfo_screenheight() // 2) - (height // 2)
        self.geometry(f'{width}x{height}+{x}+{y}')

    def apply_rounded_corners(self):
        if os.name == 'nt':
            import ctypes
            self.update_idletasks()
            hwnd = ctypes.windll.user32.GetParent(self.winfo_id())
            if hwnd == 0:
                hwnd = self.winfo_id()
            rgn = ctypes.windll.gdi32.CreateRoundRectRgn(0, 0, self.winfo_width(), self.winfo_height(), 15, 15)
            ctypes.windll.user32.SetWindowRgn(hwnd, rgn, True)

    def start_move(self, event):
        self.x = event.x
        self.y = event.y

    def do_move(self, event):
        deltax = event.x - self.x
        deltay = event.y - self.y
        x = self.winfo_x() + deltax
        y = self.winfo_y() + deltay
        self.geometry(f"+{x}+{y}")

    def close_window(self):
        self.destroy()

    def minimize_window(self):
        self.overrideredirect(False)
        self.wm_state('iconic')
        self.bind('<Map>', self.restore_window)

    def restore_window(self, event):
        """Pencere simge durumundan çıkarıldığında çalışır"""
        if self.wm_state() == 'normal':
            self.overrideredirect(True)
            self.unbind('<Map>')
            self.apply_rounded_corners()
            
            # Görev çubuğundan ikonun silinmemesi için stili tekrar uyguluyoruz
            self.force_taskbar_icon()
            
            # Windows'un ikon güncellemesini anında fark etmesi için çok hızlı bir gizle/göster yapıyoruz
            self.wm_withdraw()
            self.wm_deiconify()

    def start_conversion_thread(self):
        self.convert_button.configure(state="disabled", text="Converting...")
        threading.Thread(target=self.convert_file, daemon=True).start()

    def convert_file(self):
        filetypes = (("MP3 files", "*.mp3"), ("WAV files", "*.wav"))
        input_file = filedialog.askopenfilename(title="Select file to convert", filetypes=filetypes)

        if input_file:
            output_file = filedialog.asksaveasfilename(title="Save converted file as", filetypes=filetypes, defaultextension=".mp3")

            if output_file:
                ffmpeg_path = resource_path("ffmpeg.exe")
                
                command = [
                    ffmpeg_path,
                    "-y",
                    "-i", input_file,
                    "-b:a", "320k",
                    "-vcodec", "copy",
                    output_file
                ]

                try:
                    startupinfo = None
                    creationflags = 0
                    if os.name == 'nt':
                        startupinfo = subprocess.STARTUPINFO()
                        startupinfo.dwFlags |= subprocess.STARTF_USESHOWWINDOW
                        startupinfo.wShowWindow = subprocess.SW_HIDE
                        creationflags = subprocess.CREATE_NO_WINDOW

                    subprocess.run(
                        command, 
                        check=True, 
                        stdout=subprocess.DEVNULL, 
                        stderr=subprocess.DEVNULL, 
                        startupinfo=startupinfo, 
                        creationflags=creationflags
                    )
                    messagebox.showinfo("Success", "Conversion completed successfully!")
                except subprocess.CalledProcessError as e:
                    messagebox.showerror("Error", f"An error occurred during conversion.\nError code: {e.returncode}")
                except FileNotFoundError:
                    messagebox.showerror("Error", "FFmpeg component is missing or corrupted!")
                except Exception as e:
                    messagebox.showerror("Error", f"An unexpected error occurred: {e}")
        
        self.after(0, lambda: self.convert_button.configure(state="normal", text="CONVERT"))

if __name__ == "__main__":
    app = ConverterApp()
    app.mainloop()