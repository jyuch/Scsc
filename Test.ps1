$Env:Path += ";C:\Windows\Microsoft.NET\Framework\v4.0.30319";

function Test {
    param (
        [string] $exp,
        [int] $expected
    )

    Remove-Item .\temp.il
    Remove-Item .\temp.exe

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
Test '10' 10;
Test '1+1' 2;
Test '1+2+3+4+5+6+7+8+9+10' 55;
Test '10-5' 5;

Pop-Location
