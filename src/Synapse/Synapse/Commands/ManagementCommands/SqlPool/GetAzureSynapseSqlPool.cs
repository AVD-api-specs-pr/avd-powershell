﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;
using Microsoft.Azure.Commands.Synapse.Common;
using Microsoft.Azure.Commands.Synapse.Models;
using Microsoft.Azure.Management.Internal.Resources.Utilities.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Linq;
using System.Management.Automation;

namespace Microsoft.Azure.Commands.Synapse
{
    [Cmdlet(VerbsCommon.Get, ResourceManager.Common.AzureRMConstants.AzureRMPrefix + SynapseConstants.SynapsePrefix + SynapseConstants.SqlPool,
        DefaultParameterSetName = GetByNameParameterSet)]
    [OutputType(typeof(PSSynapseSqlPool))]
    public class GetAzureSynapseSqlPool : SynapseManagementCmdletBase
    {
        private const string GetByNameParameterSet = "GetByNameParameterSet";
        private const string GetByParentObjectParameterSet = "GetByParentObjectParameterSet";
        private const string GetByResourceIdParameterSet = "GetByResourceIdParameterSet";

        [Parameter(Mandatory = false, ParameterSetName = GetByNameParameterSet,
            HelpMessage = HelpMessages.ResourceGroupName)]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(Mandatory = true, ParameterSetName = GetByNameParameterSet,
            HelpMessage = HelpMessages.WorkspaceName)]
        [ResourceNameCompleter(ResourceTypes.Workspace, nameof(ResourceGroupName))]
        [ValidateNotNullOrEmpty]
        public string WorkspaceName { get; set; }

        [Parameter(Mandatory = false, ParameterSetName = GetByNameParameterSet, HelpMessage = HelpMessages.SqlPoolName)]
        [Parameter(Mandatory = false, ParameterSetName = GetByParentObjectParameterSet, HelpMessage = HelpMessages.SqlPoolName)]
        [ResourceNameCompleter(
            ResourceTypes.SqlPool,
            nameof(ResourceGroupName),
            nameof(WorkspaceName))]
        [Alias(nameof(SynapseConstants.SqlPoolName))]
        [ValidateNotNullOrEmpty]
        public string Name { get; set; }

        [Parameter(Mandatory = false, HelpMessage = HelpMessages.SqlPoolVersion)]
        [ValidateNotNullOrEmpty]
        [ValidateRange(2, 3)]
        public int Version { get; set; }

        [Parameter(Mandatory = true, ValueFromPipeline = true, ParameterSetName = GetByParentObjectParameterSet, HelpMessage = HelpMessages.WorkspaceObject)]
        [ValidateNotNull]
        public PSSynapseWorkspace WorkspaceObject { get; set; }

        [Parameter(Mandatory = true, ValueFromPipelineByPropertyName = false, ParameterSetName = GetByResourceIdParameterSet, HelpMessage = HelpMessages.SqlPoolResourceId)]
        [ValidateNotNullOrEmpty]
        public string ResourceId { get; set; }

        public override void ExecuteCmdlet()
        {
            if (this.IsParameterBound(c => c.ResourceId))
            {
                var resourceIdentifier = new ResourceIdentifier(this.ResourceId);
                this.ResourceGroupName = resourceIdentifier.ResourceGroupName;
                this.WorkspaceName = resourceIdentifier.ParentResource;
                this.WorkspaceName = this.WorkspaceName.Substring(this.WorkspaceName.LastIndexOf('/') + 1);
                this.Name = resourceIdentifier.ResourceName;
            }

            if (this.IsParameterBound(c => c.WorkspaceObject))
            {
                this.ResourceGroupName = new ResourceIdentifier(this.WorkspaceObject.Id).ResourceGroupName;
                this.WorkspaceName = this.WorkspaceObject.Name;
            }

            if (this.Version == 3)
            {
                if (!string.IsNullOrEmpty(this.Name))
                {
                    var result = new PSSynapseSqlPoolV3(this.SynapseAnalyticsClient.GetSqlPoolV3(this.ResourceGroupName, this.WorkspaceName, this.Name));
                    WriteObject(result);
                }
                else
                {
                    var result = this.SynapseAnalyticsClient.ListSqlPoolsV3(this.ResourceGroupName, this.WorkspaceName).Select(r => new PSSynapseSqlPoolV3(r));
                    WriteObject(result, true);
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(this.Name))
                {
                    var result = new PSSynapseSqlPool(this.ResourceGroupName, this.WorkspaceName, this.SynapseAnalyticsClient.GetSqlPool(this.ResourceGroupName, this.WorkspaceName, this.Name));
                    WriteObject(result);
                }
                else
                {
                    var result = this.SynapseAnalyticsClient.ListSqlPools(this.ResourceGroupName, this.WorkspaceName).Select(r => new PSSynapseSqlPool(this.ResourceGroupName, this.WorkspaceName, r));
                    WriteObject(result, true);
                }
            }
        }
    }
}
