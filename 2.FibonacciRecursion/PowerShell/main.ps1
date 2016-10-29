$rootPath = Split-Path -parent $PSCommandPath
Import-Module $rootPath\fibonacci.psm1


Write-Host "-7: " (Calculate(-7))
Write-Host "-1: " (Calculate(-1))
Write-Host "0: " (Calculate(0))
Write-Host "1: " (Calculate(1))
Write-Host "2: " (Calculate(2))
Write-Host "4: " (Calculate(4))
Write-Host "7: " (Calculate(7))