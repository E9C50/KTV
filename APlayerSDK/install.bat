regsvr32 /s .\bin\APlayer.dll
regsvr32 /s .\bin\APlayerUI.dll
regsvr32 /s .\bin\npaplayer.dll

for /f "tokens=1,2,*" %%i in ('reg query "HKEY_CURRENT_USER\Software\Thunder Network\APlayer" ^| find /i "Path"') do SET "pURL=%%k" 
xcopy /E /Y .\bin\codecs\*.* "%pURL%\..\codecs\*.*"
