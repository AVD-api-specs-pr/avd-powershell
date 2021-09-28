// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Extensions;

    /// <summary>InMage protected disk details.</summary>
    public partial class InMageProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetails,
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Models.Api20210210.IInMageProtectedDiskDetailsInternal
    {

        /// <summary>Backing field for <see cref="DiskCapacityInByte" /> property.</summary>
        private long? _diskCapacityInByte;

        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? DiskCapacityInByte { get => this._diskCapacityInByte; set => this._diskCapacityInByte = value; }

        /// <summary>Backing field for <see cref="DiskId" /> property.</summary>
        private string _diskId;

        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskId { get => this._diskId; set => this._diskId = value; }

        /// <summary>Backing field for <see cref="DiskName" /> property.</summary>
        private string _diskName;

        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskName { get => this._diskName; set => this._diskName = value; }

        /// <summary>Backing field for <see cref="DiskResized" /> property.</summary>
        private string _diskResized;

        /// <summary>A value indicating whether disk is resized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string DiskResized { get => this._diskResized; set => this._diskResized = value; }

        /// <summary>Backing field for <see cref="FileSystemCapacityInByte" /> property.</summary>
        private long? _fileSystemCapacityInByte;

        /// <summary>The file system capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? FileSystemCapacityInByte { get => this._fileSystemCapacityInByte; set => this._fileSystemCapacityInByte = value; }

        /// <summary>Backing field for <see cref="HealthErrorCode" /> property.</summary>
        private string _healthErrorCode;

        /// <summary>The health error code for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string HealthErrorCode { get => this._healthErrorCode; set => this._healthErrorCode = value; }

        /// <summary>Backing field for <see cref="LastRpoCalculatedTime" /> property.</summary>
        private global::System.DateTime? _lastRpoCalculatedTime;

        /// <summary>The last RPO calculated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? LastRpoCalculatedTime { get => this._lastRpoCalculatedTime; set => this._lastRpoCalculatedTime = value; }

        /// <summary>Backing field for <see cref="ProgressHealth" /> property.</summary>
        private string _progressHealth;

        /// <summary>The Progress Health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProgressHealth { get => this._progressHealth; set => this._progressHealth = value; }

        /// <summary>Backing field for <see cref="ProgressStatus" /> property.</summary>
        private string _progressStatus;

        /// <summary>The Progress Status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProgressStatus { get => this._progressStatus; set => this._progressStatus = value; }

        /// <summary>Backing field for <see cref="ProtectionStage" /> property.</summary>
        private string _protectionStage;

        /// <summary>The protection stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ProtectionStage { get => this._protectionStage; set => this._protectionStage = value; }

        /// <summary>Backing field for <see cref="PsDataInMb" /> property.</summary>
        private double? _psDataInMb;

        /// <summary>The PS data transit in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? PsDataInMb { get => this._psDataInMb; set => this._psDataInMb = value; }

        /// <summary>Backing field for <see cref="ResyncDurationInSecond" /> property.</summary>
        private long? _resyncDurationInSecond;

        /// <summary>The resync duration in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncDurationInSecond { get => this._resyncDurationInSecond; set => this._resyncDurationInSecond = value; }

        /// <summary>Backing field for <see cref="ResyncLast15MinutesTransferredByte" /> property.</summary>
        private long? _resyncLast15MinutesTransferredByte;

        /// <summary>The resync last 15 minutes transferred bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncLast15MinutesTransferredByte { get => this._resyncLast15MinutesTransferredByte; set => this._resyncLast15MinutesTransferredByte = value; }

        /// <summary>Backing field for <see cref="ResyncLastDataTransferTimeUtc" /> property.</summary>
        private global::System.DateTime? _resyncLastDataTransferTimeUtc;

        /// <summary>The last data transfer time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? ResyncLastDataTransferTimeUtc { get => this._resyncLastDataTransferTimeUtc; set => this._resyncLastDataTransferTimeUtc = value; }

        /// <summary>Backing field for <see cref="ResyncProcessedByte" /> property.</summary>
        private long? _resyncProcessedByte;

        /// <summary>The resync processed bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncProcessedByte { get => this._resyncProcessedByte; set => this._resyncProcessedByte = value; }

        /// <summary>Backing field for <see cref="ResyncProgressPercentage" /> property.</summary>
        private int? _resyncProgressPercentage;

        /// <summary>The resync progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public int? ResyncProgressPercentage { get => this._resyncProgressPercentage; set => this._resyncProgressPercentage = value; }

        /// <summary>Backing field for <see cref="ResyncRequired" /> property.</summary>
        private string _resyncRequired;

        /// <summary>A value indicating whether resync is required for this disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public string ResyncRequired { get => this._resyncRequired; set => this._resyncRequired = value; }

        /// <summary>Backing field for <see cref="ResyncStartTime" /> property.</summary>
        private global::System.DateTime? _resyncStartTime;

        /// <summary>The resync start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public global::System.DateTime? ResyncStartTime { get => this._resyncStartTime; set => this._resyncStartTime = value; }

        /// <summary>Backing field for <see cref="ResyncTotalTransferredByte" /> property.</summary>
        private long? _resyncTotalTransferredByte;

        /// <summary>The resync total transferred bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? ResyncTotalTransferredByte { get => this._resyncTotalTransferredByte; set => this._resyncTotalTransferredByte = value; }

        /// <summary>Backing field for <see cref="RpoInSecond" /> property.</summary>
        private long? _rpoInSecond;

        /// <summary>The RPO in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public long? RpoInSecond { get => this._rpoInSecond; set => this._rpoInSecond = value; }

        /// <summary>Backing field for <see cref="SourceDataInMb" /> property.</summary>
        private double? _sourceDataInMb;

        /// <summary>The source data transit in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? SourceDataInMb { get => this._sourceDataInMb; set => this._sourceDataInMb = value; }

        /// <summary>Backing field for <see cref="TargetDataInMb" /> property.</summary>
        private double? _targetDataInMb;

        /// <summary>The target data transit in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Origin(Microsoft.Azure.PowerShell.Cmdlets.Migrate.PropertyOrigin.Owned)]
        public double? TargetDataInMb { get => this._targetDataInMb; set => this._targetDataInMb = value; }

        /// <summary>Creates an new <see cref="InMageProtectedDiskDetails" /> instance.</summary>
        public InMageProtectedDiskDetails()
        {

        }
    }
    /// InMage protected disk details.
    public partial interface IInMageProtectedDiskDetails :
        Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.IJsonSerializable
    {
        /// <summary>The disk capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk capacity in bytes.",
        SerializedName = @"diskCapacityInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? DiskCapacityInByte { get; set; }
        /// <summary>The disk id.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk id.",
        SerializedName = @"diskId",
        PossibleTypes = new [] { typeof(string) })]
        string DiskId { get; set; }
        /// <summary>The disk name.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The disk name.",
        SerializedName = @"diskName",
        PossibleTypes = new [] { typeof(string) })]
        string DiskName { get; set; }
        /// <summary>A value indicating whether disk is resized.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether disk is resized.",
        SerializedName = @"diskResized",
        PossibleTypes = new [] { typeof(string) })]
        string DiskResized { get; set; }
        /// <summary>The file system capacity in bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The file system capacity in bytes.",
        SerializedName = @"fileSystemCapacityInBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? FileSystemCapacityInByte { get; set; }
        /// <summary>The health error code for the disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The health error code for the disk.",
        SerializedName = @"healthErrorCode",
        PossibleTypes = new [] { typeof(string) })]
        string HealthErrorCode { get; set; }
        /// <summary>The last RPO calculated time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The last RPO calculated time.",
        SerializedName = @"lastRpoCalculatedTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? LastRpoCalculatedTime { get; set; }
        /// <summary>The Progress Health.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Progress Health.",
        SerializedName = @"progressHealth",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressHealth { get; set; }
        /// <summary>The Progress Status.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The Progress Status.",
        SerializedName = @"progressStatus",
        PossibleTypes = new [] { typeof(string) })]
        string ProgressStatus { get; set; }
        /// <summary>The protection stage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The protection stage.",
        SerializedName = @"protectionStage",
        PossibleTypes = new [] { typeof(string) })]
        string ProtectionStage { get; set; }
        /// <summary>The PS data transit in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The PS data transit in MB.",
        SerializedName = @"psDataInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? PsDataInMb { get; set; }
        /// <summary>The resync duration in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resync duration in seconds.",
        SerializedName = @"resyncDurationInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncDurationInSecond { get; set; }
        /// <summary>The resync last 15 minutes transferred bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resync last 15 minutes transferred bytes.",
        SerializedName = @"resyncLast15MinutesTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncLast15MinutesTransferredByte { get; set; }
        /// <summary>The last data transfer time in UTC.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The last data transfer time in UTC.",
        SerializedName = @"resyncLastDataTransferTimeUTC",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResyncLastDataTransferTimeUtc { get; set; }
        /// <summary>The resync processed bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resync processed bytes.",
        SerializedName = @"resyncProcessedBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncProcessedByte { get; set; }
        /// <summary>The resync progress percentage.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resync progress percentage.",
        SerializedName = @"resyncProgressPercentage",
        PossibleTypes = new [] { typeof(int) })]
        int? ResyncProgressPercentage { get; set; }
        /// <summary>A value indicating whether resync is required for this disk.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"A value indicating whether resync is required for this disk.",
        SerializedName = @"resyncRequired",
        PossibleTypes = new [] { typeof(string) })]
        string ResyncRequired { get; set; }
        /// <summary>The resync start time.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resync start time.",
        SerializedName = @"resyncStartTime",
        PossibleTypes = new [] { typeof(global::System.DateTime) })]
        global::System.DateTime? ResyncStartTime { get; set; }
        /// <summary>The resync total transferred bytes.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The resync total transferred bytes.",
        SerializedName = @"resyncTotalTransferredBytes",
        PossibleTypes = new [] { typeof(long) })]
        long? ResyncTotalTransferredByte { get; set; }
        /// <summary>The RPO in seconds.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The RPO in seconds.",
        SerializedName = @"rpoInSeconds",
        PossibleTypes = new [] { typeof(long) })]
        long? RpoInSecond { get; set; }
        /// <summary>The source data transit in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The source data transit in MB.",
        SerializedName = @"sourceDataInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? SourceDataInMb { get; set; }
        /// <summary>The target data transit in MB.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Migrate.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"The target data transit in MB.",
        SerializedName = @"targetDataInMB",
        PossibleTypes = new [] { typeof(double) })]
        double? TargetDataInMb { get; set; }

    }
    /// InMage protected disk details.
    internal partial interface IInMageProtectedDiskDetailsInternal

    {
        /// <summary>The disk capacity in bytes.</summary>
        long? DiskCapacityInByte { get; set; }
        /// <summary>The disk id.</summary>
        string DiskId { get; set; }
        /// <summary>The disk name.</summary>
        string DiskName { get; set; }
        /// <summary>A value indicating whether disk is resized.</summary>
        string DiskResized { get; set; }
        /// <summary>The file system capacity in bytes.</summary>
        long? FileSystemCapacityInByte { get; set; }
        /// <summary>The health error code for the disk.</summary>
        string HealthErrorCode { get; set; }
        /// <summary>The last RPO calculated time.</summary>
        global::System.DateTime? LastRpoCalculatedTime { get; set; }
        /// <summary>The Progress Health.</summary>
        string ProgressHealth { get; set; }
        /// <summary>The Progress Status.</summary>
        string ProgressStatus { get; set; }
        /// <summary>The protection stage.</summary>
        string ProtectionStage { get; set; }
        /// <summary>The PS data transit in MB.</summary>
        double? PsDataInMb { get; set; }
        /// <summary>The resync duration in seconds.</summary>
        long? ResyncDurationInSecond { get; set; }
        /// <summary>The resync last 15 minutes transferred bytes.</summary>
        long? ResyncLast15MinutesTransferredByte { get; set; }
        /// <summary>The last data transfer time in UTC.</summary>
        global::System.DateTime? ResyncLastDataTransferTimeUtc { get; set; }
        /// <summary>The resync processed bytes.</summary>
        long? ResyncProcessedByte { get; set; }
        /// <summary>The resync progress percentage.</summary>
        int? ResyncProgressPercentage { get; set; }
        /// <summary>A value indicating whether resync is required for this disk.</summary>
        string ResyncRequired { get; set; }
        /// <summary>The resync start time.</summary>
        global::System.DateTime? ResyncStartTime { get; set; }
        /// <summary>The resync total transferred bytes.</summary>
        long? ResyncTotalTransferredByte { get; set; }
        /// <summary>The RPO in seconds.</summary>
        long? RpoInSecond { get; set; }
        /// <summary>The source data transit in MB.</summary>
        double? SourceDataInMb { get; set; }
        /// <summary>The target data transit in MB.</summary>
        double? TargetDataInMb { get; set; }

    }
}