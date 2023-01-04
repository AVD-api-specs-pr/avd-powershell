
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
Create an in-memory object for AmazonS3CredentialScan.
.Description
Create an in-memory object for AmazonS3CredentialScan.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3CredentialScan
.Link
https://learn.microsoft.com/powershell/module/az.Purview/new-AzPurviewAmazonS3CredentialScanObject
#>
function New-AzPurviewAmazonS3CredentialScanObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3CredentialScan')]
    [CmdletBinding(PositionalBinding=$false)]
    Param(

        [Parameter()]
        [string]
        $CollectionReferenceName,
        [Parameter()]
        [string]
        $CollectionType,
        [Parameter()]
        [string]
        $ConnectedViaReferenceName,
        [Parameter()]
        [string]
        $CredentialReferenceName,
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.CredentialType]
        $CredentialType,
        [Parameter()]
        [bool]
        $IsMauiScan,
        [Parameter()]
        [string]
        $RoleArn,
        [Parameter()]
        [string]
        $ScanRulesetName,
        [Parameter()]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanRulesetType]
        $ScanRulesetType,
        [Parameter()]
        [int]
        $Worker,
        [Parameter(Mandatory)]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.ScanAuthorizationType]
        $Kind
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3CredentialScan]::New()

        if ($PSBoundParameters.ContainsKey('CollectionReferenceName')) {
            $Object.CollectionReferenceName = $CollectionReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CollectionType')) {
            $Object.CollectionType = $CollectionType
        }
        if ($PSBoundParameters.ContainsKey('ConnectedViaReferenceName')) {
            $Object.ConnectedViaReferenceName = $ConnectedViaReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CredentialReferenceName')) {
            $Object.CredentialReferenceName = $CredentialReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CredentialType')) {
            $Object.CredentialType = $CredentialType
        }
        if ($PSBoundParameters.ContainsKey('IsMauiScan')) {
            $Object.IsMauiScan = $IsMauiScan
        }
        if ($PSBoundParameters.ContainsKey('RoleArn')) {
            $Object.RoleArn = $RoleArn
        }
        if ($PSBoundParameters.ContainsKey('ScanRulesetName')) {
            $Object.ScanRulesetName = $ScanRulesetName
        }
        if ($PSBoundParameters.ContainsKey('ScanRulesetType')) {
            $Object.ScanRulesetType = $ScanRulesetType
        }
        if ($PSBoundParameters.ContainsKey('Worker')) {
            $Object.Worker = $Worker
        }
        if ($PSBoundParameters.ContainsKey('Kind')) {
            $Object.Kind = $Kind
        }
        return $Object
    }
}

