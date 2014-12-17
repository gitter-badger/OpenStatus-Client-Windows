; OpenStatus Windows Client Installer NSIS Script
; get NSIS at http://tenet.dl.sourceforge.net/project/nsis/NSIS%202/2.46/nsis-2.46-setup.exe
; As a program that all Power PC users should have, Notepad++ is recommended to edit this file

AddBrandingImage top 20
Icon favicon.ico
Caption "OpenStatus Windows Client Installer"
Name "OpenStatus Windows Client"
AutoCloseWindow true
ShowInstDetails show

LicenseBkColor /windows
LicenseData "LICENSE.md"
LicenseForceSelection checkbox "I have read and understand this notice"
LicenseText "Please read the notice below before installing the OpenStatus Windows Client. If you understand the notice, click the checkbox below and click Next."

InstallDir $PROGRAMFILES\DeavmiOSS

OutFile "bin\Release\OpenStatusClientWin-Installer.exe"

; Pages

Page license
Page components
Page directory
Page instfiles
UninstPage uninstConfirm
UninstPage instfiles

; Sections

Section "OpenStatus Windows Client Executable & Uninstaller"
  SectionIn RO
  SetOutPath $INSTDIR
  File "bin\Release\OpenStatus.exe"
  WriteUninstaller "OpenStatusClientWin-Uninst.exe"
SectionEnd

Section "OpenStatus Windows Client Start Menu Shortcuts"
  CreateDirectory "$SMPROGRAMS\DeavmiOSS"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\OpenStatus Windows Client.lnk" "$INSTDIR\OpenStatus.exe" "" "$INSTDIR\OpenStatus.exe" "" "" "" "OpenStatus Windows Client"
  CreateShortCut "$SMPROGRAMS\DeavmiOSS\Uninstall OpenStatus Windows Client.lnk" "$INSTDIR\OpenStatusClientWin-Uninst.exe" "" "" "" "" "" "Uninstall OpenStatus Windows Client"
  ;Syntax for CreateShortCut: link.lnk target.file [parameters [icon.file [icon_index_number [start_options [keyboard_shortcut [description]]]]]]
SectionEnd

Section "OpenStatus Windows Client Desktop Shortcut"
  CreateShortCut "$DESKTOP\OpenStatus Windows Client.lnk" "$INSTDIR\OpenStatus.exe" "" "$INSTDIR\OpenStatus.exe" "" "" "" "OpenStatus Windows Client"
SectionEnd

Section "OpenStatus Windows Client Quick Launch Shortcut"
  CreateShortCut "$QUICKLAUNCH\OpenStatus Windows Client.lnk" "$INSTDIR\OpenStatus.exe" "" "$INSTDIR\OpenStatus.exe" "" "" "" "OpenStatus Windows Client"
SectionEnd

;Section "More apps from DeavmiOSS"
; this should have sub options for available apps, that are downloaded
;SectionEnd

; Functions

Function .onInit
  MessageBox MB_YESNO "This will install OpenStatus Windows Client. Do you wish to continue?" IDYES gogogo
    Abort
  gogogo:
  SetBrandingImage "[/RESIZETOFIT] favicon.ico"
  SetShellVarContext all
  SetAutoClose true
FunctionEnd

Function .onInstSuccess
    MessageBox MB_YESNO "Install Succeeded! Open ReadMe?" IDNO NoReadme
      ExecShell "open" "https://github.com/OpenStatus/OpenStatus-Client-Windows/blob/master/README.md#openstatus-windows-"
    NoReadme:
FunctionEnd

; Uninstaller

Section "Uninstall"
  Delete $INSTDIR\OpenStatusClientWin-Uninst.exe.exe   ; Remove Application Files
  Delete $INSTDIR\OpenStatus.exe
  RMDir $INSTDIR
  
  Delete "$SMPROGRAMS\DeavmiOSS\OpenStatus Windows Client.lnk"   ; Remove Start Menu Shortcuts & Folder
  Delete "$SMPROGRAMS\DeavmiOSS\Uninstall OpenStatus Windows Client.lnk"
  RMDir $SMPROGRAMS\DeavmiOSS
  
  Delete $DESKTOP\OpenStatus Windows Client.lnk   ; Remove Desktop Shortcut
  Delete $QUICKLAUNCH\OpenStatus Windows Client.lnk   ; Remove Quick Launch shortcut
SectionEnd

; Uninstaller Functions

Function un.onInit
    MessageBox MB_YESNO "This will uninstall OpenStatus Windows Client. Continue?" IDYES NoAbort
      Abort ; causes uninstaller to quit.
    NoAbort:
    SetShellVarContext all
    SetAutoClose true
FunctionEnd

Function un.onUninstFailed
    MessageBox MB_OK "Uninstall Cancelled"
FunctionEnd

Function un.onUninstSuccess
    MessageBox MB_OK "Uninstall Completed"
FunctionEnd
