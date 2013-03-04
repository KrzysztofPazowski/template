@echo off

set scriptpath=%~dp0
echo scriptpath:%scriptpath%

echo #####################   Calling Nant for oneclick service   #####################

%scriptpath%Tools\nant\nant.exe -buildfile:%scriptpath%buildscripts\HelloWorld\HelloWorld.oneclick
if errorlevel 1 (
   echo Broken build.
   pause
   exit
)

pause
@echo on