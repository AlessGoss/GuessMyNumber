@echo off
title Cleaning up...
if exist "bin\Debug\net5.0\win-x86\publish" (
if exist "Release" (del /f /s /q Release & rd /s /q Release)
cd "bin\Debug\net5.0\win-x86"
move /Y "publish" "..\..\..\..\Release"
cd "..\..\..\..\"
)
del /f /s /q bin
rd /s /q bin
del /f /s /q obj
rd /s /q obj