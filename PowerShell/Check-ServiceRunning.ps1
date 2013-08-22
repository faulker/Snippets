# Check if a service is running on a system.

Param(
	[string]$arg1,
	[string]$arg2
)


Function CheckService($ServiceName, $Computer)
{
	if((Get-Service -ComputerName $Computer $ServiceName|select Status) -match "Running")
	{
		Write-Host -ForegroundColor Green "$ServiceName on $Computer is running."
	}
	else
	{
		Write-Host -ForegroundColor Yellow -BackgroundColor Red "$ServiceName on $Computer is not running."
	}
}

CheckService $arg1 $arg2