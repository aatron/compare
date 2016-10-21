param([string]$projectName = $(Read-Host -prompt "Project Name"))
$rootPath = Split-Path -parent $PSCommandPath
$sourcePath = "1.HelloWorld"

# Get new folder number
$newNumber = (Get-ChildItem $rootPath | 
    ?{ $_.PSIsContainer } |
    Where-Object { $_.Name.Contains('.') } |
    Select @{Name="Number";Expression={ [int]($_.Name.Split(".")[0])} } |
    Measure-Object Number -Max).Maximum + 1

# Copy Folder from 1.HelloWorld to x.NewName
Copy-Item -Path (Join-Path $rootPath $sourcePath) -Destination (Join-Path $rootPath "$newNumber.$projectName") -Recurse