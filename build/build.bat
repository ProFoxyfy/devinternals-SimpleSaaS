@echo off
IF EXIST SimpleSaaS.exe (
    del SimpleSaaS.exe
)
cd ..
vbc main.vb
ren main.exe SimpleSaaS.exe
move SimpleSaaS.exe build
echo Build Complete
pause