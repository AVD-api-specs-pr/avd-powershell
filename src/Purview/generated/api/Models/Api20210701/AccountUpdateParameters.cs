namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>The account update properties.</summary>
    public partial class AccountUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParameters,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal
    {

        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CloudConnectorAwsExternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnectorAwsExternalId; }

        /// <summary>Gets the time at which the entity was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public global::System.DateTime? CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedAt; }

        /// <summary>Gets the creator of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedBy; }

        /// <summary>Gets the creators of the entity's object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string CreatedByObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedByObjectId; }

        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointCatalog; }

        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointGuardian { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointGuardian; }

        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string EndpointScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointScan; }

        /// <summary>Gets or sets the friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).FriendlyName; }

        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceEventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceEventHubNamespace; }

        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroup; }

        /// <summary>Gets or sets the managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceGroupName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroupName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroupName = value ?? null; }

        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public string ManagedResourceStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceStorageAccount; }

        /// <summary>Internal Acessors for CloudConnector</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.CloudConnector { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnector; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnector = value; }

        /// <summary>Internal Acessors for CloudConnectorAwsExternalId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.CloudConnectorAwsExternalId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnectorAwsExternalId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CloudConnectorAwsExternalId = value; }

        /// <summary>Internal Acessors for CreatedAt</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.CreatedAt { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedAt; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedAt = value; }

        /// <summary>Internal Acessors for CreatedBy</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.CreatedBy { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedBy; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedBy = value; }

        /// <summary>Internal Acessors for CreatedByObjectId</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.CreatedByObjectId { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedByObjectId; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).CreatedByObjectId = value; }

        /// <summary>Internal Acessors for Endpoint</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.Endpoint { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).Endpoint; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).Endpoint = value; }

        /// <summary>Internal Acessors for EndpointCatalog</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.EndpointCatalog { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointCatalog; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointCatalog = value; }

        /// <summary>Internal Acessors for EndpointGuardian</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.EndpointGuardian { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointGuardian; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointGuardian = value; }

        /// <summary>Internal Acessors for EndpointScan</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.EndpointScan { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointScan; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).EndpointScan = value; }

        /// <summary>Internal Acessors for FriendlyName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.FriendlyName { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).FriendlyName; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).FriendlyName = value; }

        /// <summary>Internal Acessors for ManagedResource</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.ManagedResource { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResource; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResource = value; }

        /// <summary>Internal Acessors for ManagedResourceEventHubNamespace</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.ManagedResourceEventHubNamespace { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceEventHubNamespace; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceEventHubNamespace = value; }

        /// <summary>Internal Acessors for ManagedResourceGroup</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.ManagedResourceGroup { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroup; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceGroup = value; }

        /// <summary>Internal Acessors for ManagedResourceStorageAccount</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.ManagedResourceStorageAccount { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceStorageAccount; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ManagedResourceStorageAccount = value; }

        /// <summary>Internal Acessors for PrivateEndpointConnection</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PrivateEndpointConnection; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PrivateEndpointConnection = value; }

        /// <summary>Internal Acessors for Property</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountProperties()); set { {_property = value;} } }

        /// <summary>Internal Acessors for ProvisioningState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersInternal.ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ProvisioningState; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ProvisioningState = value; }

        /// <summary>Gets the private endpoint connections information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PrivateEndpointConnection; }

        /// <summary>Backing field for <see cref="Property" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties _property;

        /// <summary>The account properties.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties Property { get => (this._property = this._property ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountProperties()); set => this._property = value; }

        /// <summary>Gets or sets the state of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).ProvisioningState; }

        /// <summary>Gets or sets the public network access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountPropertiesInternal)Property).PublicNetworkAccess = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess)""); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersTags _tag;

        /// <summary>Tags on the azure resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.AccountUpdateParametersTags()); set => this._tag = value; }

        /// <summary>Creates an new <see cref="AccountUpdateParameters" /> instance.</summary>
        public AccountUpdateParameters()
        {

        }
    }
    /// The account update properties.
    public partial interface IAccountUpdateParameters :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"AWS external identifier.
        Configured in AWS to allow use of the role arn used for scanning",
        SerializedName = @"awsExternalId",
        PossibleTypes = new [] { typeof(string) })]
        string CloudConnectorAwsExternalId { get;  }
        /// <summary>Gets the time at which the entity was created.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the time at which the entity was created.",
        SerializedName = @"createdAt",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? CreatedAt { get;  }
        /// <summary>Gets the creator of the entity.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the creator of the entity.",
        SerializedName = @"createdBy",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedBy { get;  }
        /// <summary>Gets the creators of the entity's object id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the creators of the entity's object id.",
        SerializedName = @"createdByObjectId",
        PossibleTypes = new [] { typeof(string) })]
        string CreatedByObjectId { get;  }
        /// <summary>Gets the catalog endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the catalog endpoint.",
        SerializedName = @"catalog",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointCatalog { get;  }
        /// <summary>Gets the guardian endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the guardian endpoint.",
        SerializedName = @"guardian",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointGuardian { get;  }
        /// <summary>Gets the scan endpoint.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the scan endpoint.",
        SerializedName = @"scan",
        PossibleTypes = new [] { typeof(string) })]
        string EndpointScan { get;  }
        /// <summary>Gets or sets the friendly name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the friendly name.",
        SerializedName = @"friendlyName",
        PossibleTypes = new [] { typeof(string) })]
        string FriendlyName { get;  }
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed event hub namespace resource identifier.",
        SerializedName = @"eventHubNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceEventHubNamespace { get;  }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.",
        SerializedName = @"resourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroup { get;  }
        /// <summary>Gets or sets the managed resource group name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the managed resource group name",
        SerializedName = @"managedResourceGroupName",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceGroupName { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the managed storage account resource identifier.",
        SerializedName = @"storageAccount",
        PossibleTypes = new [] { typeof(string) })]
        string ManagedResourceStorageAccount { get;  }
        /// <summary>Gets the private endpoint connections information.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets the private endpoint connections information.",
        SerializedName = @"privateEndpointConnections",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get;  }
        /// <summary>Gets or sets the state of the provisioning.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the state of the provisioning.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get;  }
        /// <summary>Gets or sets the public network access.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Gets or sets the public network access.",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Tags on the azure resource.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Tags on the azure resource.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersTags Tag { get; set; }

    }
    /// The account update properties.
    internal partial interface IAccountUpdateParametersInternal

    {
        /// <summary>
        /// Cloud connectors.
        /// External cloud identifier used as part of scanning configuration.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.ICloudConnectors CloudConnector { get; set; }
        /// <summary>
        /// AWS external identifier.
        /// Configured in AWS to allow use of the role arn used for scanning
        /// </summary>
        string CloudConnectorAwsExternalId { get; set; }
        /// <summary>Gets the time at which the entity was created.</summary>
        global::System.DateTime? CreatedAt { get; set; }
        /// <summary>Gets the creator of the entity.</summary>
        string CreatedBy { get; set; }
        /// <summary>Gets the creators of the entity's object id.</summary>
        string CreatedByObjectId { get; set; }
        /// <summary>The URIs that are the public endpoints of the account.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountEndpoints Endpoint { get; set; }
        /// <summary>Gets the catalog endpoint.</summary>
        string EndpointCatalog { get; set; }
        /// <summary>Gets the guardian endpoint.</summary>
        string EndpointGuardian { get; set; }
        /// <summary>Gets the scan endpoint.</summary>
        string EndpointScan { get; set; }
        /// <summary>Gets or sets the friendly name.</summary>
        string FriendlyName { get; set; }
        /// <summary>Gets the resource identifiers of the managed resources.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IManagedResources ManagedResource { get; set; }
        /// <summary>Gets the managed event hub namespace resource identifier.</summary>
        string ManagedResourceEventHubNamespace { get; set; }
        /// <summary>
        /// Gets the managed resource group resource identifier. This resource group will host resource dependencies for the account.
        /// </summary>
        string ManagedResourceGroup { get; set; }
        /// <summary>Gets or sets the managed resource group name</summary>
        string ManagedResourceGroupName { get; set; }
        /// <summary>Gets the managed storage account resource identifier.</summary>
        string ManagedResourceStorageAccount { get; set; }
        /// <summary>Gets the private endpoint connections information.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IPrivateEndpointConnection[] PrivateEndpointConnection { get; set; }
        /// <summary>The account properties.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountProperties Property { get; set; }
        /// <summary>Gets or sets the state of the provisioning.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.ProvisioningState? ProvisioningState { get; set; }
        /// <summary>Gets or sets the public network access.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Support.PublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary>Tags on the azure resource.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IAccountUpdateParametersTags Tag { get; set; }

    }
}