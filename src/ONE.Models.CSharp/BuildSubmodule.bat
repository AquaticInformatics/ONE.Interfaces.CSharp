# Generate all the C# classes from proto files
cd ..\ONE.Interfaces.ProtocolBuffers\generators
Powershell.exe -executionpolicy Bypass -File gen_all.ps1

# Create folder
mkdir ..\..\ONE.Models.CSharp\generated

# Copy to local folder
copy ..\proto\flat\out\csharp\* ..\..\ONE.Models.CSharp\generated