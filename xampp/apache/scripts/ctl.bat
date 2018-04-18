@echo off

if not ""%1"" == ""START"" goto stop

cmd.exe /C start /B /MIN "" "C:\Users\HP\Desktop\PP2\xampp\apache\bin\httpd.exe"

if errorlevel 255 goto finish
if errorlevel 1 goto error
goto finish

:stop
"C:\Users\HP\Desktop\PP2\xampp\apache\bin\pv" -f -k httpd.exe -q
if not exist "C:\Users\HP\Desktop\PP2\xampp\apache\logs\httpd.pid" GOTO finish
del "C:\Users\HP\Desktop\PP2\xampp\apache\logs\httpd.pid"
goto finish

:error
echo Error starting Apache

:finish
exit
