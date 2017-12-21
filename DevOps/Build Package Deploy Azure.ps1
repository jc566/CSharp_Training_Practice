<#This variable holds the drop folder location#>

$dropFolder = "\\VMINOB076\DropLocationFolder\Joe"

<#get the most recently added file in the drop folder#>
<#
$mostRecentFolder = Get-ChildItem -Path $dropFolder `
| Sort-Object LastAccessTime -Descending `
| Select-Object -First 1
#>

#$mostRecentFolder #uncomment to confirm that the above snippet is working

#Install-Module AzureAutomationAuthoringToolkit -Scope CurrentUser -Force
<#
Install-PackageProvider AzureAutomationAuthoringToolkit  -Force
Import-PackageProvider AzureAutomationAuthoringToolkit  -Force
Set-PSRepository -Name PSGallery -InstallationPolicy Trusted

Install-Module AzureAutomationAuthoringToolkit -Scope CurrentUser -Force

#>
<#Let us find the Cloud Service Packages : 
1. Cloud Service Configuration type
2. Service Package File
#>
#The following 2 lines should have reference to the cloud config packages
#$servicePackageFile = "C:\Users\Joseph.Choi\Source\Workspaces\TFS-Test-Project\JC_DevOps\DevOps\CloudService\bin\Cloud\app.publish" + "\CloudService.cspkg"
#$cloudServiceConfiguration = "C:\Users\Joseph.Choi\Source\Workspaces\TFS-Test-Project\JC_DevOps\DevOps\CloudService\bin\Cloud\app.publish" + "\ServiceConfiguration.Cloud.cscfg"

#for TFS server
$servicePackageFile = "C:\TfsData\Agents\Agent-VMINOB035\_work\2\s\JC_DevOps\DevOps\CloudService\bin\Cloud\app.publish" + "\CloudService.cspkg"
$cloudServiceConfiguration = "C:\TfsData\Agents\Agent-VMINOB035\_work\2\s\JC_DevOps\DevOps\CloudService\bin\Cloud\app.publish" + "\ServiceConfiguration.Cloud.cscfg"

Import-Module "C:\Program Files (x86)\Microsoft SDKs\Azure\PowerShell\ServiceManagement\Azure\Azure.psd1"
Import-Module Azure.Storage

#for shared folder
#$servicePackageFile = "\\VMINOB076\Share" + "\CloudService.cspkg"
#$cloudServiceConfiguration = "\\VMINOB076\Share" + "\ServiceConfiguration.Cloud.cscfg"


$username = "Joseph.Choi@valuemomentum.com"
$securePassword = ConvertTo-SecureString `
        -String "Cho@409432" -AsPlainText -Force
$cred = New-Object System.Management.Automation.PSCredential ($username, $securePassword)
Add-AzureAccount -Credential $cred


#Add your Azure Account 
#Add-AzureRmAccount -SubscriptionId "0e7e6980-50b6-41d9-bb48-61874d914f8e"



Select-AzureSubscription -SubscriptionId "0e7e6980-50b6-41d9-bb48-61874d914f8e"
#Save your subscription into a variable
$subscriptions = Get-AzureSubscription -Current
#Write-Output $($subscriptions.SubscriptionName) #print the name of the Subscription


#Deploy the Service
Get-AzureService -ServiceName DevOpsTrainingJC
Set-AzureSubscription -SubscriptionName $($subscriptions.SubscriptionName) -CurrentStorageAccountName 'classicstoragejc'
Set-AzureDeployment -Label "Successful_BUILD" -Package $servicePackageFile -Configuration $cloudServiceConfiguration -ServiceName DevOpsTrainingJC -Slot Production -Upgrade -Force

























