// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Cosmos DB location metadata
    /// </summary>
    public partial class LocationProperties
    {
        /// <summary>
        /// Initializes a new instance of the LocationProperties class.
        /// </summary>
        public LocationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LocationProperties class.
        /// </summary>
        /// <param name="supportsAvailabilityZone">Flag indicating whether the
        /// location supports availability zones or not.</param>
        /// <param name="isResidencyRestricted">Flag indicating whether the
        /// location is residency sensitive.</param>
        /// <param name="backupStorageRedundancies">The properties of available
        /// backup storage redundancies.</param>
        /// <param name="isSubscriptionRegionAccessAllowedForRegular">Flag
        /// indicating whether the subscription have access in region for
        /// Non-Availability Zones.</param>
        /// <param name="isSubscriptionRegionAccessAllowedForAz">Flag
        /// indicating whether the subscription have access in region for
        /// Availability Zones(Az).</param>
        /// <param name="status">Enum to indicate current buildout status of
        /// the region. Possible values include: 'Uninitialized',
        /// 'Initializing', 'InternallyReady', 'Online', 'Deleting'</param>
        public LocationProperties(bool? supportsAvailabilityZone = default(bool?), bool? isResidencyRestricted = default(bool?), IList<string> backupStorageRedundancies = default(IList<string>), bool? isSubscriptionRegionAccessAllowedForRegular = default(bool?), bool? isSubscriptionRegionAccessAllowedForAz = default(bool?), string status = default(string))
        {
            SupportsAvailabilityZone = supportsAvailabilityZone;
            IsResidencyRestricted = isResidencyRestricted;
            BackupStorageRedundancies = backupStorageRedundancies;
            IsSubscriptionRegionAccessAllowedForRegular = isSubscriptionRegionAccessAllowedForRegular;
            IsSubscriptionRegionAccessAllowedForAz = isSubscriptionRegionAccessAllowedForAz;
            Status = status;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets flag indicating whether the location supports availability
        /// zones or not.
        /// </summary>
        [JsonProperty(PropertyName = "supportsAvailabilityZone")]
        public bool? SupportsAvailabilityZone { get; private set; }

        /// <summary>
        /// Gets flag indicating whether the location is residency sensitive.
        /// </summary>
        [JsonProperty(PropertyName = "isResidencyRestricted")]
        public bool? IsResidencyRestricted { get; private set; }

        /// <summary>
        /// Gets the properties of available backup storage redundancies.
        /// </summary>
        [JsonProperty(PropertyName = "backupStorageRedundancies")]
        public IList<string> BackupStorageRedundancies { get; private set; }

        /// <summary>
        /// Gets flag indicating whether the subscription have access in region
        /// for Non-Availability Zones.
        /// </summary>
        [JsonProperty(PropertyName = "isSubscriptionRegionAccessAllowedForRegular")]
        public bool? IsSubscriptionRegionAccessAllowedForRegular { get; private set; }

        /// <summary>
        /// Gets flag indicating whether the subscription have access in region
        /// for Availability Zones(Az).
        /// </summary>
        [JsonProperty(PropertyName = "isSubscriptionRegionAccessAllowedForAz")]
        public bool? IsSubscriptionRegionAccessAllowedForAz { get; private set; }

        /// <summary>
        /// Gets enum to indicate current buildout status of the region.
        /// Possible values include: 'Uninitialized', 'Initializing',
        /// 'InternallyReady', 'Online', 'Deleting'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

    }
}
