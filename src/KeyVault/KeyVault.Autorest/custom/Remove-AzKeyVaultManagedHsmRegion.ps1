
# ----------------------------------------------------------------------------------
# Copyright (c) Microsoft Corporation. All rights reserved.
# Licensed under the Apache License, Version 2.0 (the "License");
# you may not use this file except in compliance with the License.
# You may obtain a copy of the License at
# http://www.apache.org/licenses/LICENSE-2.0
# Unless required by applicable law or agreed to in writing, software
# distributed under the License is distributed on an "AS IS" BASIS,
# WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
# See the License for the specific language governing permissions and
# limitations under the License.
# Code generated by Microsoft (R) AutoRest Code Generator.Changes may cause incorrect behavior and will be lost if the code
# is regenerated.
# ----------------------------------------------------------------------------------

<#
.Synopsis
The List operation gets information about the regions associated with the managed HSM Pool.
.Description
The List operation gets information about the regions associated with the managed HSM Pool.
.Example
{{ Add code here }}
.Example
{{ Add code here }}

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IMhsmGeoReplicatedRegion
.Link
https://learn.microsoft.com/powershell/module/az.keyvault/remove-azkeyvaultmanagedhsmregion
#>
function Remove-AzKeyVaultManagedHsmRegion {
    [OutputType([Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Models.IMhsmGeoReplicatedRegion])]
    [CmdletBinding(PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
    param(
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Path')]
        [System.String]
        # Name of the managed HSM Pool
        ${HsmName},
    
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Path')]
        [System.String]
        # Name of the resource group that contains the managed HSM pool.
        ${ResourceGroupName},
 
        [Parameter(Mandatory)]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Body')]
        [System.String[]]
        # List of regions to be removed associated with the managed hsm pool.
        ${Region},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Returns true when the command succeeds
        ${PassThru},
            
        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Run the command as a job
        ${AsJob},

        [Parameter()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Path')]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
        [System.String]
        # Subscription credentials which uniquely identify Microsoft Azure subscription.
        # The subscription ID forms part of the URI for every service call.
        ${SubscriptionId},
    
        [Parameter()]
        [Alias('AzureRMContext', 'AzureCredential')]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Azure')]
        [System.Management.Automation.PSObject]
        # The DefaultProfile parameter is not functional.
        # Use the SubscriptionId parameter when available if executing the cmdlet against a different subscription.
        ${DefaultProfile},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Wait for .NET debugger to attach
        ${Break},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be appended to the front of the pipeline
        ${HttpPipelineAppend},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Runtime.SendAsyncStep[]]
        # SendAsync Pipeline Steps to be prepended to the front of the pipeline
        ${HttpPipelinePrepend},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [System.Uri]
        # The URI for the proxy server to use
        ${Proxy},
    
        [Parameter(DontShow)]
        [ValidateNotNull()]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [System.Management.Automation.PSCredential]
        # Credentials for a proxy server to use for the remote call
        ${ProxyCredential},
    
        [Parameter(DontShow)]
        [Microsoft.Azure.PowerShell.Cmdlets.KeyVault.Category('Runtime')]
        [System.Management.Automation.SwitchParameter]
        # Use the default credentials for the proxy
        ${ProxyUseDefaultCredentials}
    )
    process {
        try {
            $null = $PSBoundParameters.Remove('PassThru')
            $null = $PSBoundParameters.Remove('HsmName')
            $null = $PSBoundParameters.Add('Name', $HsmName)
            $null = $PSBoundParameters.Remove('Region')
            $Parameter = Az.KeyVault.internal\Get-AzKeyVaultManagedHsm @PSBoundParameters
            $remainingRegions = @()
            for ($i = 0; $i -lt $Parameter.Region.Count; $i++) {
                if($Region -notcontains $Parameter.Region[$i].Name){
                    $remainingRegions += $Parameter.Region[$i]
                }
            }
            $Parameter.Region = $remainingRegions
            $null = $PSBoundParameters.Add('Parameter', $Parameter)            
            $null = Az.KeyVault.internal\Update-AzKeyVaultManagedHsm @PSBoundParameters
            $null = $PSBoundParameters.Remove('Parameter')
            $null = $PSBoundParameters.Remove('Name')
            $null = $PSBoundParameters.Add('HsmName', $HsmName)
            if($PassThru.IsPresent){
                Az.KeyVault\Get-AzKeyVaultManagedHsmRegion @PSBoundParameters
            }
        } catch {
            throw
        }
    }    
}  