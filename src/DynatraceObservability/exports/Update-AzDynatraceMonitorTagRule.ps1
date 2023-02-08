
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
Update a TagRule
.Description
Update a TagRule
.Example
$tagFilter = New-AzDynatraceMonitorFilteringTagObject -Action 'Include' -Name 'Environment' -Value 'Prod'
Update-AzDynatraceMonitorTagRule -ResourceGroupName dyobrg -MonitorName dyob-pwsh01 -LogRuleFilteringTag $tagFilter
.Example
$tagFilter = New-AzDynatraceMonitorFilteringTagObject -Action 'Include' -Name 'Environment' -Value 'Prod'
Get-AzDynatraceMonitorTagRule -ResourceGroupName dyobrg -MonitorName dyob-pwsh01 | Update-AzDynatraceMonitorTagRule -LogRuleFilteringTag $tagFilter

.Inputs
Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IDynatraceObservabilityIdentity
.Outputs
Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRule
.Notes
COMPLEX PARAMETER PROPERTIES

To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

INPUTOBJECT <IDynatraceObservabilityIdentity>: Identity Parameter
  [ConfigurationName <String>]: Single Sign On Configuration Name
  [Id <String>]: Resource identity path
  [MonitorName <String>]: Monitor resource name
  [ResourceGroupName <String>]: The name of the resource group. The name is case insensitive.
  [RuleSetName <String>]: Monitor resource name
  [SubscriptionId <String>]: The ID of the target subscription.

LOGRULEFILTERINGTAG <IFilteringTag[]>: List of filtering tags to be used for capturing logs. This only takes effect if SendActivityLogs flag is enabled. If empty, all resources will be captured.If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
  [Action <TagAction?>]: Valid actions for a filtering tag. Exclusion takes priority over inclusion.
  [Name <String>]: The name (also known as the key) of the tag.
  [Value <String>]: The value of the tag.

METRICRULEFILTERINGTAG <IFilteringTag[]>: List of filtering tags to be used for capturing metrics. If empty, all resources will be captured. If only Exclude action is specified, the rules will apply to the list of all available resources. If Include actions are specified, the rules will only include resources with the associated tags.
  [Action <TagAction?>]: Valid actions for a filtering tag. Exclusion takes priority over inclusion.
  [Name <String>]: The name (also known as the key) of the tag.
  [Value <String>]: The value of the tag.
.Link
https://learn.microsoft.com/powershell/module/az.dynatraceobservability/update-azdynatracemonitortagrule
#>
function Update-AzDynatraceMonitorTagRule {
[OutputType([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.ITagRule])]
[CmdletBinding(DefaultParameterSetName='UpdateExpanded', PositionalBinding=$false, SupportsShouldProcess, ConfirmImpact='Medium')]
param(
    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [System.String]
    # Monitor resource name
    ${MonitorName},

    [Parameter(ParameterSetName='UpdateExpanded', Mandatory)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [System.String]
    # The name of the resource group.
    # The name is case insensitive.
    ${ResourceGroupName},

    [Parameter(ParameterSetName='UpdateExpanded')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.DefaultInfo(Script='(Get-AzContext).Subscription.Id')]
    [System.String]
    # The ID of the target subscription.
    ${SubscriptionId},

    [Parameter(ParameterSetName='UpdateViaIdentityExpanded', Mandatory, ValueFromPipeline)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Path')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.IDynatraceObservabilityIdentity]
    # Identity Parameter
    # To construct, see NOTES section for INPUTOBJECT properties and create a hash table.
    ${InputObject},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag[]]
    # List of filtering tags to be used for capturing logs.
    # This only takes effect if SendActivityLogs flag is enabled.
    # If empty, all resources will be captured.If only Exclude action is specified, the rules will apply to the list of all available resources.
    # If Include actions are specified, the rules will only include resources with the associated tags.
    # To construct, see NOTES section for LOGRULEFILTERINGTAG properties and create a hash table.
    ${LogRuleFilteringTag},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendAadLogsStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendAadLogsStatus]
    # Flag specifying if AAD logs should be sent for the Monitor resource.
    ${LogRuleSendAadLog},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendActivityLogsStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendActivityLogsStatus]
    # Flag specifying if activity logs from Azure resources should be sent for the Monitor resource.
    ${LogRuleSendActivityLog},

    [Parameter()]
    [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendSubscriptionLogsStatus])]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Support.SendSubscriptionLogsStatus]
    # Flag specifying if subscription logs should be sent for the Monitor resource.
    ${LogRuleSendSubscriptionLog},

    [Parameter()]
    [AllowEmptyCollection()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Body')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Models.Api20210901.IFilteringTag[]]
    # List of filtering tags to be used for capturing metrics.
    # If empty, all resources will be captured.
    # If only Exclude action is specified, the rules will apply to the list of all available resources.
    # If Include actions are specified, the rules will only include resources with the associated tags.
    # To construct, see NOTES section for METRICRULEFILTERINGTAG properties and create a hash table.
    ${MetricRuleFilteringTag},

    [Parameter()]
    [Alias('AzureRMContext', 'AzureCredential')]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Azure')]
    [System.Management.Automation.PSObject]
    # The credentials, account, tenant, and subscription used for communication with Azure.
    ${DefaultProfile},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Wait for .NET debugger to attach
    ${Break},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be appended to the front of the pipeline
    ${HttpPipelineAppend},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.SendAsyncStep[]]
    # SendAsync Pipeline Steps to be prepended to the front of the pipeline
    ${HttpPipelinePrepend},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Uri]
    # The URI for the proxy server to use
    ${Proxy},

    [Parameter(DontShow)]
    [ValidateNotNull()]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Management.Automation.PSCredential]
    # Credentials for a proxy server to use for the remote call
    ${ProxyCredential},

    [Parameter(DontShow)]
    [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Category('Runtime')]
    [System.Management.Automation.SwitchParameter]
    # Use the default credentials for the proxy
    ${ProxyUseDefaultCredentials}
)

begin {
    try {
        $outBuffer = $null
        if ($PSBoundParameters.TryGetValue('OutBuffer', [ref]$outBuffer)) {
            $PSBoundParameters['OutBuffer'] = 1
        }
        $parameterSet = $PSCmdlet.ParameterSetName

        if ($null -eq [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion) {
            [Microsoft.WindowsAzure.Commands.Utilities.Common.AzurePSCmdlet]::PowerShellVersion = $Host.Version.ToString()
        }         
        $preTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        if ($preTelemetryId -eq '') {
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId =(New-Guid).ToString()
            [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.module]::Instance.Telemetry.Invoke('Create', $MyInvocation, $parameterSet, $PSCmdlet)
        } else {
            $internalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
            if ($internalCalledCmdlets -eq '') {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $MyInvocation.MyCommand.Name
            } else {
                [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets += ',' + $MyInvocation.MyCommand.Name
            }
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = 'internal'
        }

        $mapping = @{
            UpdateExpanded = 'Az.DynatraceObservability.private\Update-AzDynatraceMonitorTagRule_UpdateExpanded';
            UpdateViaIdentityExpanded = 'Az.DynatraceObservability.private\Update-AzDynatraceMonitorTagRule_UpdateViaIdentityExpanded';
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('Name')) {
            $PSBoundParameters['Name'] = "default"
        }
        if (('UpdateExpanded') -contains $parameterSet -and -not $PSBoundParameters.ContainsKey('SubscriptionId')) {
            $PSBoundParameters['SubscriptionId'] = (Get-AzContext).Subscription.Id
        }
        $cmdInfo = Get-Command -Name $mapping[$parameterSet]
        [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.Runtime.MessageAttributeHelper]::ProcessCustomAttributesAtRuntime($cmdInfo, $MyInvocation, $parameterSet, $PSCmdlet)
        $wrappedCmd = $ExecutionContext.InvokeCommand.GetCommand(($mapping[$parameterSet]), [System.Management.Automation.CommandTypes]::Cmdlet)
        $scriptCmd = {& $wrappedCmd @PSBoundParameters}
        $steppablePipeline = $scriptCmd.GetSteppablePipeline($MyInvocation.CommandOrigin)
        $steppablePipeline.Begin($PSCmdlet)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
}

process {
    try {
        $steppablePipeline.Process($_)
    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }

    finally {
        $backupTelemetryId = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId
        $backupInternalCalledCmdlets = [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
    }

}
end {
    try {
        $steppablePipeline.End()

        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $backupTelemetryId
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::InternalCalledCmdlets = $backupInternalCalledCmdlets
        if ($preTelemetryId -eq '') {
            [Microsoft.Azure.PowerShell.Cmdlets.DynatraceObservability.module]::Instance.Telemetry.Invoke('Send', $MyInvocation, $parameterSet, $PSCmdlet)
            [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        }
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::TelemetryId = $preTelemetryId

    } catch {
        [Microsoft.WindowsAzure.Commands.Common.MetricHelper]::ClearTelemetryContext()
        throw
    }
} 
}
