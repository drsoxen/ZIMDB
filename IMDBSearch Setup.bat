@echo off
xcopy /Y /s "SupportingFiles\IMDB.ico" "C:\Program Files\IMDBSearch\"
xcopy /Y /s "SupportingFiles\IMDB\IMDB\bin\Release\IMDB.exe" "C:\Program Files\IMDBSearch\"
regedit /S SupportingFiles\IMDB.reg