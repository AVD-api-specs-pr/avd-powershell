// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.Extensions;

    /// <summary>Gets or sets the tags, a dictionary of descriptors arm object</summary>
    public partial class ResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceTags,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Models.Api20221001.IResourceTagsInternal
    {

        /// <summary>Creates an new <see cref="ResourceTags" /> instance.</summary>
        public ResourceTags()
        {

        }
    }
    /// Gets or sets the tags, a dictionary of descriptors arm object
    public partial interface IResourceTags :
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.Peering.Runtime.IAssociativeArray<string>
    {

    }
    /// Gets or sets the tags, a dictionary of descriptors arm object
    internal partial interface IResourceTagsInternal

    {

    }
}