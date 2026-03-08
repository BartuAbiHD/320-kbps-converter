@ECHO OFF
title Build 320Kbps Converter
cls
pyinstaller app.spec --noconfirm && explorer dist
pause