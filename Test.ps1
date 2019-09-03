$Env:Path += ";C:\Windows\Microsoft.NET\Framework\v4.0.30319";

function Test {
    param (
        [string] $exp,
        [int] $expected
    )
    .\Scsc.exe $exp > temp.il
    ilasm.exe temp.il /exe /debug=impl /output=temp.exe > $null
    .\temp.exe

    if($LASTEXITCODE -eq $expected) {
        Write-Host "OK"
    } else {
        Write-Host "NG $exp $expected $LASTEXITCODE"
    }
}

Push-Location .\Scsc\bin\Debug

Test '42' 42;
Test '10' 42;

Pop-Location
