function RandomString([bool]$allChars, [int32]$len) {
    if ($allChars) {
        return -join ((33..126) | Get-Random -Count $len | % {[char]$_})
    } else {
        return -join ((48..57) + (97..122) | Get-Random -Count $len | % {[char]$_})
    }
}
$env = @{}
if ($UsePreviousConfigForRecord) {
    $previousEnv = Get-Content (Join-Path $PSScriptRoot 'env.json') | ConvertFrom-Json
    $previousEnv.psobject.properties | Foreach-Object { $env[$_.Name] = $_.Value }
}
# Add script method called AddWithCache to $env, when useCache is set true, it will try to get the value from the $env first.
# example: $val = $env.AddWithCache('key', $val, $true)
$env | Add-Member -Type ScriptMethod -Value { param( [string]$key, [object]$val, [bool]$useCache) if ($this.Contains($key) -and $useCache) { return $this[$key] } else { $this[$key] = $val; return $val } } -Name 'AddWithCache'
function setupEnv() {
    # Preload subscriptionId and tenant from context, which will be used in test
    # as default. You could change them if needed.
    $env.SubscriptionId = (Get-AzContext).Subscription.Id
    $env.Tenant = (Get-AzContext).Tenant.Id
    # For any resources you created for test, you should add it to $env here.

    $resourceGroupName = "azcli-test-rg"
    $env.Add("resourceGroupName", $resourceGroupName)

    $location = "eastus"
    $env.Add("location", $location)

    $extendedLocationType = "CustomLocation"
    $env.Add("extendedLocationType", $extendedLocationType)

    $extendedLocationName = "/subscriptions/$($env.SubscriptionId)/resourceGroups/azcli-test-rg/providers/Microsoft.ExtendedLocation/customLocations/azcli-test-cl3"
    $env.Add("extendedLocationName", $extendedLocationName)

    $vcenterId = "/subscriptions/$($env.SubscriptionId)/resourceGroups/azcli-test-rg/providers/microsoft.connectedvmwarevsphere/VCenters/azcli-test-vc3"
    $env.Add("vcenterId", $vcenterId)

    $clusterName = "test-cluster" + (RandomString -allChars $false -len 5)
    $env.Add("clusterName", $clusterName)

    $datastoreName = "test-datastore" + (RandomString -allChars $false -len 5)
    $env.Add("datastoreName", $datastoreName)

    $hostName = "test-host" + (RandomString -allChars $false -len 5)
    $env.Add("hostName", $hostName)

    $resourcePoolName = "test-resourcePool" + (RandomString -allChars $false -len 5)
    $env.Add("resourcePoolName", $resourcePoolName)

    $vcenterName = "azcli-test-vc3"
    $env.Add("vcenterName", $vcenterName)

    $vmName = "vm-1106469"
    $env.Add("vmName", $vmName)

    $vmTemplateName = "test-vmtemplate" + (RandomString -allChars $false -len 5)
    $env.Add("vmTemplateName", $vmTemplateName)

    $envFile = 'env.json'
    if ($TestMode -eq 'live') {
        $envFile = 'localEnv.json'
    }
    set-content -Path (Join-Path $PSScriptRoot $envFile) -Value (ConvertTo-Json $env)
}
function cleanupEnv() {
    # Clean resources you create for testing
}

