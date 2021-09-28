// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Extensions;

    /// <summary>A principal assignment check name availability request.</summary>
    public partial class DatabasePrincipalAssignmentCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentCheckNameRequest,
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentCheckNameRequestInternal
    {

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20210601Preview.IDatabasePrincipalAssignmentCheckNameRequestInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Principal Assignment resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type= @"Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments";

        /// <summary>
        /// The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Origin(Microsoft.Azure.PowerShell.Cmdlets.Synapse.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>
        /// Creates an new <see cref="DatabasePrincipalAssignmentCheckNameRequest" /> instance.
        /// </summary>
        public DatabasePrincipalAssignmentCheckNameRequest()
        {

        }
    }
    /// A principal assignment check name availability request.
    public partial interface IDatabasePrincipalAssignmentCheckNameRequest :
        Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.IJsonSerializable
    {
        /// <summary>Principal Assignment resource name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"Principal Assignment resource name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>
        /// The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Synapse.Runtime.Info(
        Required = true,
        ReadOnly = true,
        Description = @"The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// A principal assignment check name availability request.
    internal partial interface IDatabasePrincipalAssignmentCheckNameRequestInternal

    {
        /// <summary>Principal Assignment resource name.</summary>
        string Name { get; set; }
        /// <summary>
        /// The type of resource, Microsoft.Synapse/workspaces/kustoPools/databases/principalAssignments.
        /// </summary>
        string Type { get; set; }

    }
}