namespace Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Extensions;

    /// <summary>metric specifications for the operation</summary>
    public partial class OperationMetaMetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecification,
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IOperationMetaMetricSpecificationInternal
    {

        /// <summary>Backing field for <see cref="AggregationType" /> property.</summary>
        private string _aggregationType;

        /// <summary>aggregation type of metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string AggregationType { get => this._aggregationType; set => this._aggregationType = value; }

        /// <summary>Backing field for <see cref="Dimension" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties[] _dimension;

        /// <summary>properties for dimension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties[] Dimension { get => this._dimension; set => this._dimension = value; }

        /// <summary>Backing field for <see cref="DisplayDescription" /> property.</summary>
        private string _displayDescription;

        /// <summary>description of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string DisplayDescription { get => this._displayDescription; set => this._displayDescription = value; }

        /// <summary>Backing field for <see cref="DisplayName" /> property.</summary>
        private string _displayName;

        /// <summary>localized name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string DisplayName { get => this._displayName; set => this._displayName = value; }

        /// <summary>Backing field for <see cref="EnableRegionalMdmAccount" /> property.</summary>
        private string _enableRegionalMdmAccount;

        /// <summary>enable regional mdm account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string EnableRegionalMdmAccount { get => this._enableRegionalMdmAccount; set => this._enableRegionalMdmAccount = value; }

        /// <summary>Backing field for <see cref="InternalMetricName" /> property.</summary>
        private string _internalMetricName;

        /// <summary>internal metric name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string InternalMetricName { get => this._internalMetricName; set => this._internalMetricName = value; }

        /// <summary>Backing field for <see cref="Name" /> property.</summary>
        private string _name;

        /// <summary>name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Name { get => this._name; set => this._name = value; }

        /// <summary>Backing field for <see cref="ResourceIdDimensionNameOverride" /> property.</summary>
        private string _resourceIdDimensionNameOverride;

        /// <summary>dimension name use to replace resource id if specified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string ResourceIdDimensionNameOverride { get => this._resourceIdDimensionNameOverride; set => this._resourceIdDimensionNameOverride = value; }

        /// <summary>Backing field for <see cref="SourceMdmNamespace" /> property.</summary>
        private string _sourceMdmNamespace;

        /// <summary>
        /// Metric namespace.
        /// Only set the namespace if different from the default value,
        /// leaving it empty makes it use the value from the ARM manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string SourceMdmNamespace { get => this._sourceMdmNamespace; set => this._sourceMdmNamespace = value; }

        /// <summary>Backing field for <see cref="SupportedAggregationType" /> property.</summary>
        private string[] _supportedAggregationType;

        /// <summary>supported aggregation types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string[] SupportedAggregationType { get => this._supportedAggregationType; set => this._supportedAggregationType = value; }

        /// <summary>Backing field for <see cref="SupportedTimeGrainType" /> property.</summary>
        private string[] _supportedTimeGrainType;

        /// <summary>supported time grain types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string[] SupportedTimeGrainType { get => this._supportedTimeGrainType; set => this._supportedTimeGrainType = value; }

        /// <summary>Backing field for <see cref="Unit" /> property.</summary>
        private string _unit;

        /// <summary>units for the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Origin(Microsoft.Azure.PowerShell.Cmdlets.Purview.PropertyOrigin.Owned)]
        public string Unit { get => this._unit; set => this._unit = value; }

        /// <summary>Creates an new <see cref="OperationMetaMetricSpecification" /> instance.</summary>
        public OperationMetaMetricSpecification()
        {

        }
    }
    /// metric specifications for the operation
    public partial interface IOperationMetaMetricSpecification :
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.IJsonSerializable
    {
        /// <summary>aggregation type of metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"aggregation type of metric",
        SerializedName = @"aggregationType",
        PossibleTypes = new [] { typeof(string) })]
        string AggregationType { get; set; }
        /// <summary>properties for dimension</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"properties for dimension",
        SerializedName = @"dimensions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties) })]
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties[] Dimension { get; set; }
        /// <summary>description of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"description of the metric",
        SerializedName = @"displayDescription",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayDescription { get; set; }
        /// <summary>localized name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"localized name of the metric",
        SerializedName = @"displayName",
        PossibleTypes = new [] { typeof(string) })]
        string DisplayName { get; set; }
        /// <summary>enable regional mdm account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"enable regional mdm account",
        SerializedName = @"enableRegionalMdmAccount",
        PossibleTypes = new [] { typeof(string) })]
        string EnableRegionalMdmAccount { get; set; }
        /// <summary>internal metric name</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"internal metric name",
        SerializedName = @"internalMetricName",
        PossibleTypes = new [] { typeof(string) })]
        string InternalMetricName { get; set; }
        /// <summary>name of the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"name of the metric",
        SerializedName = @"name",
        PossibleTypes = new [] { typeof(string) })]
        string Name { get; set; }
        /// <summary>dimension name use to replace resource id if specified</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"dimension name use to replace resource id if specified",
        SerializedName = @"resourceIdDimensionNameOverride",
        PossibleTypes = new [] { typeof(string) })]
        string ResourceIdDimensionNameOverride { get; set; }
        /// <summary>
        /// Metric namespace.
        /// Only set the namespace if different from the default value,
        /// leaving it empty makes it use the value from the ARM manifest.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Metric namespace.
        Only set the namespace if different from the default value,
        leaving it empty makes it use the value from the ARM manifest.",
        SerializedName = @"sourceMdmNamespace",
        PossibleTypes = new [] { typeof(string) })]
        string SourceMdmNamespace { get; set; }
        /// <summary>supported aggregation types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"supported aggregation types",
        SerializedName = @"supportedAggregationTypes",
        PossibleTypes = new [] { typeof(string) })]
        string[] SupportedAggregationType { get; set; }
        /// <summary>supported time grain types</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"supported time grain types",
        SerializedName = @"supportedTimeGrainTypes",
        PossibleTypes = new [] { typeof(string) })]
        string[] SupportedTimeGrainType { get; set; }
        /// <summary>units for the metric</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Purview.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"units for the metric",
        SerializedName = @"unit",
        PossibleTypes = new [] { typeof(string) })]
        string Unit { get; set; }

    }
    /// metric specifications for the operation
    internal partial interface IOperationMetaMetricSpecificationInternal

    {
        /// <summary>aggregation type of metric</summary>
        string AggregationType { get; set; }
        /// <summary>properties for dimension</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Purview.Models.Api20210701.IDimensionProperties[] Dimension { get; set; }
        /// <summary>description of the metric</summary>
        string DisplayDescription { get; set; }
        /// <summary>localized name of the metric</summary>
        string DisplayName { get; set; }
        /// <summary>enable regional mdm account</summary>
        string EnableRegionalMdmAccount { get; set; }
        /// <summary>internal metric name</summary>
        string InternalMetricName { get; set; }
        /// <summary>name of the metric</summary>
        string Name { get; set; }
        /// <summary>dimension name use to replace resource id if specified</summary>
        string ResourceIdDimensionNameOverride { get; set; }
        /// <summary>
        /// Metric namespace.
        /// Only set the namespace if different from the default value,
        /// leaving it empty makes it use the value from the ARM manifest.
        /// </summary>
        string SourceMdmNamespace { get; set; }
        /// <summary>supported aggregation types</summary>
        string[] SupportedAggregationType { get; set; }
        /// <summary>supported time grain types</summary>
        string[] SupportedTimeGrainType { get; set; }
        /// <summary>units for the metric</summary>
        string Unit { get; set; }

    }
}