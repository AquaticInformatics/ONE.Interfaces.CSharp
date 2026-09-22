@rem Clean up temporary flat proto files and previous generated cs files for a clean generation
set "BASE_DIR=%~dp0"
cd "%BASE_DIR%" || exit /b 1
IF EXIST "..\ONE.Interfaces.ProtocolBuffers\proto\flat" rd /q /s "..\ONE.Interfaces.ProtocolBuffers\proto\flat" || exit /b 1
IF EXIST "generated" rd /q /s "generated" || exit /b 1

@rem Generate all the C# classes from proto files
cd ..\ONE.Interfaces.ProtocolBuffers\generators
Powershell.exe -executionpolicy Bypass -File gen_all.ps1 || exit /b 1

mkdir ..\..\ONE.Models.CSharp\generated || exit /b 1

@rem Copy to local folder
copy ..\proto\flat\out\csharp\* ..\..\ONE.Models.CSharp\generated || exit /b 1

if errorlevel 1 exit /b %errorlevel%

exit /b 0