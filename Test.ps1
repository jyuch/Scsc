$Env:Path += ";C:\Windows\Microsoft.NET\Framework\v4.0.30319";

Push-Location .\Scsc\bin\Debug

.\Scsc.exe > temp.il
ilasm.exe temp.il
.\temp.exe

Pop-Location
