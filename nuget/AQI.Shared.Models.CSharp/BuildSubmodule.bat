# Generate all the C# classes from proto files
cd ..\Claros.Interfaces.ProtocolBuffers\generators
Powershell.exe -executionpolicy Bypass -File gen_all.ps1

# Create folder
mkdir ..\..\AQI.Shared.Models.CSharp\generated

# Copy to local folder
copy ..\proto\flat\out\csharp\* ..\..\AQI.Shared.Models.CSharp\generated