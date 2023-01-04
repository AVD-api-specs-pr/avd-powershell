
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
Create an in-memory object for AmazonS3DataSource.
.Description
Create an in-memory object for AmazonS3DataSource.

.Outputs
Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource
.Link
https://learn.microsoft.com/powershell/module/az.Purview/new-AzPurviewAmazonS3DataSourceObject
#>
function New-AzPurviewAmazonS3DataSourceObject {
    [OutputType('Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource')]
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
        $RoleArn,
        [Parameter()]
        [string]
        $ServiceUrl,
        [Parameter(Mandatory)]
        [ArgumentCompleter([Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType])]
        [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Support.DataSourceType]
        $Kind
    )

    process {
        $Object = [Microsoft.Azure.PowerShell.Cmdlets.Purviewdata.Models.Api20211001Preview.AmazonS3DataSource]::New()

        if ($PSBoundParameters.ContainsKey('CollectionReferenceName')) {
            $Object.CollectionReferenceName = $CollectionReferenceName
        }
        if ($PSBoundParameters.ContainsKey('CollectionType')) {
            $Object.CollectionType = $CollectionType
        }
        if ($PSBoundParameters.ContainsKey('RoleArn')) {
            $Object.RoleArn = $RoleArn
        }
        if ($PSBoundParameters.ContainsKey('ServiceUrl')) {
            $Object.ServiceUrl = $ServiceUrl
        }
        if ($PSBoundParameters.ContainsKey('Kind')) {
            $Object.Kind = $Kind
        }
        return $Object
    }
}

