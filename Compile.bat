@echo off

%ProgramFiles%\MSBuild\12.0\bin\msbuild.exe /property:Configuration=Release OpenStatus-client.sln

%ProgramFiles%\NSIS\makensis.exe "NSIS Installer for OpenStatus Windows Client.nsi"
del bin\Release\OpenStatusClientWin-Portable.exe
ren bin\Release\OpenStatus.exe OpenStatusClientWin-Portable.exe

explorer.exe "%~dp0bin\Release"