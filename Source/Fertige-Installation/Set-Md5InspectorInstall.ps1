Clear;
Write-Host "###############################################################" -ForegroundColor Green;
Write-Host "#                                                             #" -ForegroundColor Green;
Write-Host "#                     AEKT SharpShell Installer               #" -ForegroundColor Green;
Write-Host "#                                                             #" -ForegroundColor Green;
Write-Host "###############################################################`n" -ForegroundColor Green;

$ComputerName = $env:COMPUTERNAME;
$ExecutablePath = $PSScriptRoot + "\srm.exe";
$DllPath = $PSScriptRoot + "\Md5InspectorUpdate.dll";
$TimeStemp = Get-Date -Format "yyyyMMdd_HHmm";
$LogFilePath = "D:\Temp\$($ComputerName)_MD5Inspector_$TimeStemp.txt";

Function Write-Log
{
    Param([string]$logstring)
    Add-Content $LogFilePath -Value $logstring;
    Write-Host $logstring -ForegroundColor Green;
}

Write-Log "Computer: $ComputerName" -ForegroundColor Green;
Write-Log "$(Get-Date): Start Task . . ." -ForegroundColor Green;

Write-Host $ExecutablePath
Write-Host $DllPath

& $ExecutablePath install $DllPath -coeebase;