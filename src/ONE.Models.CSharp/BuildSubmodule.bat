@rem Clean up temporary flat proto files and previous generated cs files for a clean generation
IF EXIST "..\ONE.Interfaces.ProtocolBuffers\proto\flat" rd /q /s "..\ONE.Interfaces.ProtocolBuffers\proto\flat"
IF EXIST "generated" rd /q /s "generated"


@rem Generate all the C# classes from proto files
cd ..\ONE.Interfaces.ProtocolBuffers\generators
Powershell.exe -executionpolicy Bypass -File gen_all.ps1

@rem Create folder
mkdir ..\..\ONE.Models.CSharp\generated

@rem Copy to local folder
copy ..\proto\flat\out\csharp\* ..\..\ONE.Models.CSharp\generated