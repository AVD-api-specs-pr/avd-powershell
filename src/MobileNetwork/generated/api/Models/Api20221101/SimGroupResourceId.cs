// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>Reference to a SIM group resource.</summary>
    public partial class SimGroupResourceId :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimGroupResourceId,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.ISimGroupResourceIdInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>SIM group resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string Id { get => this._id; set => this._id = value; }

        /// <summary>Creates an new <see cref="SimGroupResourceId" /> instance.</summary>
        public SimGroupResourceId()
        {

        }
    }
    /// Reference to a SIM group resource.
    public partial interface ISimGroupResourceId :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>SIM group resource ID.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = true,
        ReadOnly = false,
        Description = @"SIM group resource ID.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get; set; }

    }
    /// Reference to a SIM group resource.
    internal partial interface ISimGroupResourceIdInternal

    {
        /// <summary>SIM group resource ID.</summary>
        string Id { get; set; }

    }
}