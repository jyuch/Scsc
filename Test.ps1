$Env:Path += ";C:\Windows\Microsoft.NET\Framework\v4.0.30319";

function Test {
    param (
        [int] $expected
    )
    .\Scsc.exe > temp.il
    ilasm.exe temp.il > $null
    .\temp.exe

    if($LASTEXITCODE -eq $expected) {
        Write-Host "OK"
    } else {
        Write-Host "NG"
    }
}

Push-Location .\Scsc\bin\Debug

Test(42)

Pop-Location
