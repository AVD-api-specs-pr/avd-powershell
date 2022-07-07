// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Extensions;

    public partial class SasAuthTypeWorkspaceConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasAuthTypeWorkspaceConnectionProperties,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasAuthTypeWorkspaceConnectionPropertiesInternal,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IValidates
    {
        /// <summary>
        /// Backing field for Inherited model <see cref= "Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2"
        /// />
        /// </summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2 __workspaceConnectionPropertiesV2 = new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.WorkspaceConnectionPropertiesV2();

        /// <summary>Authentication type of the connection target</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ConnectionAuthType AuthType { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).AuthType; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).AuthType = value ; }

        /// <summary>Category of the connection</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ConnectionCategory? Category { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).Category; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).Category = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ConnectionCategory)""); }

        /// <summary>Backing field for <see cref="Credentials" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionSharedAccessSignature _credentials;

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionSharedAccessSignature Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.WorkspaceConnectionSharedAccessSignature()); set => this._credentials = value; }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inlined)]
        public string CredentialsSas { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionSharedAccessSignatureInternal)Credentials).Sas; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionSharedAccessSignatureInternal)Credentials).Sas = value ?? null; }

        /// <summary>Internal Acessors for Credentials</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionSharedAccessSignature Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.ISasAuthTypeWorkspaceConnectionPropertiesInternal.Credentials { get => (this._credentials = this._credentials ?? new Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.WorkspaceConnectionSharedAccessSignature()); set { {_credentials = value;} } }

        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Target { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).Target; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).Target = value ?? null; }

        /// <summary>Value details of the workspace connection.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public string Value { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).Value; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).Value = value ?? null; }

        /// <summary>format for the workspace connection value</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Origin(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.PropertyOrigin.Inherited)]
        public Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ValueFormat? ValueFormat { get => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).ValueFormat; set => ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal)__workspaceConnectionPropertiesV2).ValueFormat = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Support.ValueFormat)""); }

        /// <summary>
        /// Creates an new <see cref="SasAuthTypeWorkspaceConnectionProperties" /> instance.
        /// </summary>
        public SasAuthTypeWorkspaceConnectionProperties()
        {

        }

        /// <summary>Validates that this object meets the validation criteria.</summary>
        /// <param name="eventListener">an <see cref="Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener" /> instance that will receive validation
        /// events.</param>
        /// <returns>
        /// A <see cref = "global::System.Threading.Tasks.Task" /> that will be complete when validation is completed.
        /// </returns>
        public async global::System.Threading.Tasks.Task Validate(Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IEventListener eventListener)
        {
            await eventListener.AssertNotNull(nameof(__workspaceConnectionPropertiesV2), __workspaceConnectionPropertiesV2);
            await eventListener.AssertObjectIsValid(nameof(__workspaceConnectionPropertiesV2), __workspaceConnectionPropertiesV2);
        }
    }
    public partial interface ISasAuthTypeWorkspaceConnectionProperties :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.IJsonSerializable,
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2
    {
        [Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"",
        SerializedName = @"sas",
        PossibleTypes = new [] { typeof(string) })]
        string CredentialsSas { get; set; }

    }
    internal partial interface ISasAuthTypeWorkspaceConnectionPropertiesInternal :
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionPropertiesV2Internal
    {
        Microsoft.Azure.PowerShell.Cmdlets.MachineLearningServices.Models.Api20220501.IWorkspaceConnectionSharedAccessSignature Credentials { get; set; }

        string CredentialsSas { get; set; }

    }
}