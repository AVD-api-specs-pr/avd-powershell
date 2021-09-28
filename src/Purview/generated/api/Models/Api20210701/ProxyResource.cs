namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>Proxy Azure Resource</summary>
    public partial class ProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IProxyResource,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IProxyResourceInternal
    {

        /// <summary>Backing field for <see cref="Id" /> property.</summary>
        private string _id;

        /// <summary>Gets or sets the identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Id { get => this._id; }

        /// <summary>Internal Acessors for Id</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IProxyResourceInternal.Id { get => this._id; set { {_id = value;} } }

        /// <summary>Internal Acessors for Name</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IProxyResourceInternal.Name { get => this._name; set { {_name = value;} } }

        /// <summary>Internal Acessors for Type</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IProxyResourceInternal.Type { get => this._type; set { {_type = value;} } }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>Gets or sets the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Name { get => this._name; }

        /// <summary>Backing field for <see cref="Type" /> property.</summary>
        private string _type;

        /// <summary>Gets or sets the type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Type { get => this._type; }

        /// <summary>Creates an new <see cref="ProxyResource" /> instance.</summary>
        public ProxyResource()
        {

        }
    }
    /// Proxy Azure Resource
    public partial interface IProxyResource :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>Gets or sets the identifier.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the identifier.",
        SerializedName = @"id",
        PossibleTypes = new [] { typeof(string) })]
        string Id { get;  }
        /// <summary>Gets or sets the name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the name.",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get;  }
        /// <summary>Gets or sets the type.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"Gets or sets the type.",
        SerializedName = @"type",
        PossibleTypes = new [] { typeof(string) })]
        string Type { get;  }

    }
    /// Proxy Azure Resource
    internal partial interface IProxyResourceInternal

    {
        /// <summary>Gets or sets the identifier.</summary>
        string Id { get; set; }
        /// <summary>Gets or sets the name.</summary>
        string Name { get; set; }
        /// <summary>Gets or sets the type.</summary>
        string Type { get; set; }

    }
}