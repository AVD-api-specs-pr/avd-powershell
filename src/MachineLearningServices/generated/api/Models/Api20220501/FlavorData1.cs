// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class FlavorData1 :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData1,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData1Internal
    {

        /// <summary>Backing field for <see cref="Data" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData _data;

        /// <summary>Model flavor-specific data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData Data { get => (this._data = this._data ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.FlavorData()); set => this._data = value; }

        /// <summary>Creates an new <see cref="FlavorData1" /> instance.</summary>
        public FlavorData1()
        {

        }
    }
    public partial interface IFlavorData1 :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable
    {
        /// <summary>Model flavor-specific data.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Model flavor-specific data.",
        SerializedName = @"data",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData) })]
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData Data { get; set; }

    }
    internal partial interface IFlavorData1Internal

    {
        /// <summary>Model flavor-specific data.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IFlavorData Data { get; set; }

    }
}