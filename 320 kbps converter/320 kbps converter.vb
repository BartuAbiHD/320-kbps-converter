Imports System.Security.Policy

Public Class converter_program
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav"
        openFileDialog1.FilterIndex = 1
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'fileName.Text = openFileDialog1.FileName

            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Filter = "MP3 files (*.mp3)|*.mp3|WAV files (*.wav)|*.wav"
            saveFileDialog1.FilterIndex = 1
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                'fileName2.Text = saveFileDialog1.FileName

                Shell("cmd /c @echo off && color a && ffmpeg -i """ + openFileDialog1.FileName + """ -b:a 320000 -vcodec copy """ + saveFileDialog1.FileName + """")
            End If
        End If
    End Sub
End Class
