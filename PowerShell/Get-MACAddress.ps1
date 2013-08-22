#Get the MAC address of one or more system

$colItems = get-wmiobject -class "Win32_NetworkAdapterConfiguration" -computername $args | Where{$_.IpEnabled -Match "True"}
foreach ($objItem in $colItems)
{
	$objItem | select Description,MACAddress
}