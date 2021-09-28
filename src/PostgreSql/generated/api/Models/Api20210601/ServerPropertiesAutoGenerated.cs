// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601
{
    using static Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Extensions;

    /// <summary>The properties of a server.</summary>
    public partial class ServerPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGenerated,
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal
    {

        /// <summary>Backing field for <see cref="AdministratorLogin" /> property.</summary>
        private string _administratorLogin;

        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string AdministratorLogin { get => this._administratorLogin; set => this._administratorLogin = value; }

        /// <summary>Backing field for <see cref="AdministratorLoginPassword" /> property.</summary>
        private System.Security.SecureString _administratorLoginPassword;

        /// <summary>The administrator login password (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public System.Security.SecureString AdministratorLoginPassword { get => this._administratorLoginPassword; set => this._administratorLoginPassword = value; }

        /// <summary>Backing field for <see cref="AvailabilityZone" /> property.</summary>
        private string _availabilityZone;

        /// <summary>availability zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string AvailabilityZone { get => this._availabilityZone; set => this._availabilityZone = value; }

        /// <summary>Backing field for <see cref="Backup" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup _backup;

        /// <summary>Backup properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.Backup()); set => this._backup = value; }

        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public global::System.DateTime? BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).EarliestRestoreDate; }

        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? BackupGeoRedundantBackup { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).GeoRedundantBackup; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).GeoRedundantBackup = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum)""); }

        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? BackupRetentionDay { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).RetentionDay; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).RetentionDay = value ?? default(int); }

        /// <summary>Backing field for <see cref="CreateMode" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? _createMode;

        /// <summary>The mode to create a new PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? CreateMode { get => this._createMode; set => this._createMode = value; }

        /// <summary>Backing field for <see cref="FullyQualifiedDomainName" /> property.</summary>
        private string _fullyQualifiedDomainName;

        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; }

        /// <summary>Backing field for <see cref="HighAvailability" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability _highAvailability;

        /// <summary>High availability properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HighAvailability()); set => this._highAvailability = value; }

        /// <summary>The HA mode for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? HighAvailabilityMode { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).Mode; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).Mode = value ?? ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode)""); }

        /// <summary>availability zone information of the standby.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string HighAvailabilityStandbyAvailabilityZone { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).StandbyAvailabilityZone; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).StandbyAvailabilityZone = value ?? null; }

        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).State; }

        /// <summary>Backing field for <see cref="MaintenanceWindow" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindow _maintenanceWindow;

        /// <summary>Maintenance window properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindow MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.MaintenanceWindow()); set => this._maintenanceWindow = value; }

        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string MaintenanceWindowCustomWindow { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).CustomWindow; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).CustomWindow = value ?? null; }

        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowDayOfWeek { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).DayOfWeek; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).DayOfWeek = value ?? default(int); }

        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartHour { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).StartHour; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).StartHour = value ?? default(int); }

        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? MaintenanceWindowStartMinute { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).StartMinute; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindowInternal)MaintenanceWindow).StartMinute = value ?? default(int); }

        /// <summary>Internal Acessors for Backup</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.Backup { get => (this._backup = this._backup ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.Backup()); set { {_backup = value;} } }

        /// <summary>Internal Acessors for BackupEarliestRestoreDate</summary>
        global::System.DateTime? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.BackupEarliestRestoreDate { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).EarliestRestoreDate; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackupInternal)Backup).EarliestRestoreDate = value; }

        /// <summary>Internal Acessors for FullyQualifiedDomainName</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.FullyQualifiedDomainName { get => this._fullyQualifiedDomainName; set { {_fullyQualifiedDomainName = value;} } }

        /// <summary>Internal Acessors for HighAvailability</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.HighAvailability { get => (this._highAvailability = this._highAvailability ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.HighAvailability()); set { {_highAvailability = value;} } }

        /// <summary>Internal Acessors for HighAvailabilityState</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.HighAvailabilityState { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).State; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailabilityInternal)HighAvailability).State = value; }

        /// <summary>Internal Acessors for MaintenanceWindow</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindow Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.MaintenanceWindow { get => (this._maintenanceWindow = this._maintenanceWindow ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.MaintenanceWindow()); set { {_maintenanceWindow = value;} } }

        /// <summary>Internal Acessors for MinorVersion</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.MinorVersion { get => this._minorVersion; set { {_minorVersion = value;} } }

        /// <summary>Internal Acessors for Network</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetwork Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.Network { get => (this._network = this._network ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.Network()); set { {_network = value;} } }

        /// <summary>Internal Acessors for NetworkPublicNetworkAccess</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.NetworkPublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).PublicNetworkAccess; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).PublicNetworkAccess = value; }

        /// <summary>Internal Acessors for State</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.State { get => this._state; set { {_state = value;} } }

        /// <summary>Internal Acessors for Storage</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesAutoGeneratedInternal.Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.Storage()); set { {_storage = value;} } }

        /// <summary>Backing field for <see cref="MinorVersion" /> property.</summary>
        private string _minorVersion;

        /// <summary>The minor version of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string MinorVersion { get => this._minorVersion; }

        /// <summary>Backing field for <see cref="Network" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetwork _network;

        /// <summary>Network properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetwork Network { get => (this._network = this._network ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.Network()); set => this._network = value; }

        /// <summary>delegated subnet arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string NetworkDelegatedSubnetResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).DelegatedSubnetResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).DelegatedSubnetResourceId = value ?? null; }

        /// <summary>private dns zone arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public string NetworkPrivateDnsZoneArmResourceId { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).PrivateDnsZoneArmResourceId; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).PrivateDnsZoneArmResourceId = value ?? null; }

        /// <summary>public network access is enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? NetworkPublicNetworkAccess { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetworkInternal)Network).PublicNetworkAccess; }

        /// <summary>Backing field for <see cref="PointInTimeUtc" /> property.</summary>
        private global::System.DateTime? _pointInTimeUtc;

        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is
        /// 'PointInTimeRestore'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public global::System.DateTime? PointInTimeUtc { get => this._pointInTimeUtc; set => this._pointInTimeUtc = value; }

        /// <summary>Backing field for <see cref="SourceServerResourceId" /> property.</summary>
        private string _sourceServerResourceId;

        /// <summary>
        /// The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public string SourceServerResourceId { get => this._sourceServerResourceId; set => this._sourceServerResourceId = value; }

        /// <summary>Backing field for <see cref="State" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? _state;

        /// <summary>A state of a server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? State { get => this._state; }

        /// <summary>Backing field for <see cref="Storage" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage _storage;

        /// <summary>Storage properties of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage Storage { get => (this._storage = this._storage ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.Storage()); set => this._storage = value; }

        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Inlined)]
        public int? StorageSizeGb { get => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageInternal)Storage).SizeGb; set => ((Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorageInternal)Storage).SizeGb = value ?? default(int); }

        /// <summary>Backing field for <see cref="Tag" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesTags _tag;

        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesTags Tag { get => (this._tag = this._tag ?? new Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.ServerPropertiesTags()); set => this._tag = value; }

        /// <summary>Backing field for <see cref="Version" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? _version;

        /// <summary>PostgreSQL Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Origin(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? Version { get => this._version; set => this._version = value; }

        /// <summary>Creates an new <see cref="ServerPropertiesAutoGenerated" /> instance.</summary>
        public ServerPropertiesAutoGenerated()
        {

        }
    }
    /// The properties of a server.
    public partial interface IServerPropertiesAutoGenerated :
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.IJsonSerializable
    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator's login name of a server. Can only be specified when the server is being created (and is required for creation).",
        SerializedName = @"administratorLogin",
        PossibleTypes = new [] { typeof(string) })]
        string AdministratorLogin { get; set; }
        /// <summary>The administrator login password (required for server creation).</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The administrator login password (required for server creation).",
        SerializedName = @"administratorLoginPassword",
        PossibleTypes = new [] { typeof(System.Security.SecureString) })]
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>availability zone information of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"availability zone information of the server.",
        SerializedName = @"availabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string AvailabilityZone { get; set; }
        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The earliest restore point time (ISO8601 format) for server.",
        SerializedName = @"earliestRestoreDate",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? BackupEarliestRestoreDate { get;  }
        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether Geo-Redundant backup is enabled on the server.",
        SerializedName = @"geoRedundantBackup",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Backup retention days for the server.",
        SerializedName = @"backupRetentionDays",
        PossibleTypes = new [] { typeof(int) })]
        int? BackupRetentionDay { get; set; }
        /// <summary>The mode to create a new PostgreSQL server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The mode to create a new PostgreSQL server.",
        SerializedName = @"createMode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? CreateMode { get; set; }
        /// <summary>The fully qualified domain name of a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The fully qualified domain name of a server.",
        SerializedName = @"fullyQualifiedDomainName",
        PossibleTypes = new [] { typeof(string) })]
        string FullyQualifiedDomainName { get;  }
        /// <summary>The HA mode for the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The HA mode for the server.",
        SerializedName = @"mode",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? HighAvailabilityMode { get; set; }
        /// <summary>availability zone information of the standby.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"availability zone information of the standby.",
        SerializedName = @"standbyAvailabilityZone",
        PossibleTypes = new [] { typeof(string) })]
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A state of a HA server that is visible to user.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HighAvailabilityState { get;  }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"indicates whether custom window is enabled or disabled",
        SerializedName = @"customWindow",
        PossibleTypes = new [] { typeof(string) })]
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"day of week for maintenance window",
        SerializedName = @"dayOfWeek",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start hour for maintenance window",
        SerializedName = @"startHour",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"start minute for maintenance window",
        SerializedName = @"startMinute",
        PossibleTypes = new [] { typeof(int) })]
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>The minor version of the server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The minor version of the server.",
        SerializedName = @"minorVersion",
        PossibleTypes = new [] { typeof(string) })]
        string MinorVersion { get;  }
        /// <summary>delegated subnet arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"delegated subnet arm resource id.",
        SerializedName = @"delegatedSubnetResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkDelegatedSubnetResourceId { get; set; }
        /// <summary>private dns zone arm resource id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"private dns zone arm resource id.",
        SerializedName = @"privateDnsZoneArmResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string NetworkPrivateDnsZoneArmResourceId { get; set; }
        /// <summary>public network access is enabled or not</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"public network access is enabled or not",
        SerializedName = @"publicNetworkAccess",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? NetworkPublicNetworkAccess { get;  }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is
        /// 'PointInTimeRestore'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is 'PointInTimeRestore'.",
        SerializedName = @"pointInTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? PointInTimeUtc { get; set; }
        /// <summary>
        /// The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.",
        SerializedName = @"sourceServerResourceId",
        PossibleTypes = new [] { typeof(string) })]
        string SourceServerResourceId { get; set; }
        /// <summary>A state of a server that is visible to user.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"A state of a server that is visible to user.",
        SerializedName = @"state",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? State { get;  }
        /// <summary>Max storage allowed for a server.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Max storage allowed for a server.",
        SerializedName = @"storageSizeGB",
        PossibleTypes = new [] { typeof(int) })]
        int? StorageSizeGb { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"Application-specific metadata in the form of key-value pairs.",
        SerializedName = @"tags",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesTags) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesTags Tag { get; set; }
        /// <summary>PostgreSQL Server version.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"PostgreSQL Server version.",
        SerializedName = @"version",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion) })]
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? Version { get; set; }

    }
    /// The properties of a server.
    internal partial interface IServerPropertiesAutoGeneratedInternal

    {
        /// <summary>
        /// The administrator's login name of a server. Can only be specified when the server is being created (and is required for
        /// creation).
        /// </summary>
        string AdministratorLogin { get; set; }
        /// <summary>The administrator login password (required for server creation).</summary>
        System.Security.SecureString AdministratorLoginPassword { get; set; }
        /// <summary>availability zone information of the server.</summary>
        string AvailabilityZone { get; set; }
        /// <summary>Backup properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IBackup Backup { get; set; }
        /// <summary>The earliest restore point time (ISO8601 format) for server.</summary>
        global::System.DateTime? BackupEarliestRestoreDate { get; set; }
        /// <summary>A value indicating whether Geo-Redundant backup is enabled on the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.GeoRedundantBackupEnum? BackupGeoRedundantBackup { get; set; }
        /// <summary>Backup retention days for the server.</summary>
        int? BackupRetentionDay { get; set; }
        /// <summary>The mode to create a new PostgreSQL server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.CreateMode? CreateMode { get; set; }
        /// <summary>The fully qualified domain name of a server.</summary>
        string FullyQualifiedDomainName { get; set; }
        /// <summary>High availability properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IHighAvailability HighAvailability { get; set; }
        /// <summary>The HA mode for the server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.HighAvailabilityMode? HighAvailabilityMode { get; set; }
        /// <summary>availability zone information of the standby.</summary>
        string HighAvailabilityStandbyAvailabilityZone { get; set; }
        /// <summary>A state of a HA server that is visible to user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerHaState? HighAvailabilityState { get; set; }
        /// <summary>Maintenance window properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IMaintenanceWindow MaintenanceWindow { get; set; }
        /// <summary>indicates whether custom window is enabled or disabled</summary>
        string MaintenanceWindowCustomWindow { get; set; }
        /// <summary>day of week for maintenance window</summary>
        int? MaintenanceWindowDayOfWeek { get; set; }
        /// <summary>start hour for maintenance window</summary>
        int? MaintenanceWindowStartHour { get; set; }
        /// <summary>start minute for maintenance window</summary>
        int? MaintenanceWindowStartMinute { get; set; }
        /// <summary>The minor version of the server.</summary>
        string MinorVersion { get; set; }
        /// <summary>Network properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.INetwork Network { get; set; }
        /// <summary>delegated subnet arm resource id.</summary>
        string NetworkDelegatedSubnetResourceId { get; set; }
        /// <summary>private dns zone arm resource id.</summary>
        string NetworkPrivateDnsZoneArmResourceId { get; set; }
        /// <summary>public network access is enabled or not</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerPublicNetworkAccessState? NetworkPublicNetworkAccess { get; set; }
        /// <summary>
        /// Restore point creation time (ISO8601 format), specifying the time to restore from. It's required when 'createMode' is
        /// 'PointInTimeRestore'.
        /// </summary>
        global::System.DateTime? PointInTimeUtc { get; set; }
        /// <summary>
        /// The source server resource ID to restore from. It's required when 'createMode' is 'PointInTimeRestore'.
        /// </summary>
        string SourceServerResourceId { get; set; }
        /// <summary>A state of a server that is visible to user.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerState? State { get; set; }
        /// <summary>Storage properties of a server.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IStorage Storage { get; set; }
        /// <summary>Max storage allowed for a server.</summary>
        int? StorageSizeGb { get; set; }
        /// <summary>Application-specific metadata in the form of key-value pairs.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Models.Api20210601.IServerPropertiesTags Tag { get; set; }
        /// <summary>PostgreSQL Server version.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.PostgreSql.Support.ServerVersion? Version { get; set; }

    }
}