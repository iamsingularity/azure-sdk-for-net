// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Reservations.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ReservationProperties
    {
        /// <summary>
        /// Initializes a new instance of the ReservationProperties class.
        /// </summary>
        public ReservationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ReservationProperties class.
        /// </summary>
        /// <param name="reservedResourceType">Possible values include:
        /// 'VirtualMachines', 'SqlDatabases', 'SuseLinux', 'CosmosDb',
        /// 'RedHat', 'SqlDataWarehouse', 'VMwareCloudSimple',
        /// 'RedHatOsa'</param>
        /// <param name="instanceFlexibility">Possible values include: 'On',
        /// 'Off'</param>
        /// <param name="displayName">Friendly name for user to easily identify
        /// the reservation</param>
        /// <param name="appliedScopeType">Possible values include: 'Single',
        /// 'Shared'</param>
        /// <param name="provisioningState">Current state of the
        /// reservation.</param>
        /// <param name="effectiveDateTime">DateTime of the Reservation
        /// starting when this version is effective from.</param>
        /// <param name="lastUpdatedDateTime">DateTime of the last time the
        /// Reservation was updated.</param>
        /// <param name="expiryDate">This is the date when the Reservation will
        /// expire.</param>
        /// <param name="skuDescription">Description of the SKU in
        /// english.</param>
        /// <param name="billingPlan">Possible values include: 'Upfront',
        /// 'Monthly'</param>
        /// <param name="renewSource">Reservation Id of the reservation from
        /// which this reservation is renewed. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}.</param>
        /// <param name="renewDestination">Reservation Id of the reservation
        /// which is purchased because of renew. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}.</param>
        /// <param name="term">Possible values include: 'P1Y', 'P3Y'</param>
        public ReservationProperties(string reservedResourceType = default(string), string instanceFlexibility = default(string), string displayName = default(string), IList<string> appliedScopes = default(IList<string>), string appliedScopeType = default(string), int? quantity = default(int?), string provisioningState = default(string), System.DateTime? effectiveDateTime = default(System.DateTime?), System.DateTime? lastUpdatedDateTime = default(System.DateTime?), System.DateTime? expiryDate = default(System.DateTime?), string skuDescription = default(string), ExtendedStatusInfo extendedStatusInfo = default(ExtendedStatusInfo), string billingPlan = default(string), ReservationSplitProperties splitProperties = default(ReservationSplitProperties), ReservationMergeProperties mergeProperties = default(ReservationMergeProperties), string billingScopeId = default(string), bool? renew = default(bool?), string renewSource = default(string), string renewDestination = default(string), RenewPropertiesResponse renewProperties = default(RenewPropertiesResponse), string term = default(string))
        {
            ReservedResourceType = reservedResourceType;
            InstanceFlexibility = instanceFlexibility;
            DisplayName = displayName;
            AppliedScopes = appliedScopes;
            AppliedScopeType = appliedScopeType;
            Quantity = quantity;
            ProvisioningState = provisioningState;
            EffectiveDateTime = effectiveDateTime;
            LastUpdatedDateTime = lastUpdatedDateTime;
            ExpiryDate = expiryDate;
            SkuDescription = skuDescription;
            ExtendedStatusInfo = extendedStatusInfo;
            BillingPlan = billingPlan;
            SplitProperties = splitProperties;
            MergeProperties = mergeProperties;
            BillingScopeId = billingScopeId;
            Renew = renew;
            RenewSource = renewSource;
            RenewDestination = renewDestination;
            RenewProperties = renewProperties;
            Term = term;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets possible values include: 'VirtualMachines',
        /// 'SqlDatabases', 'SuseLinux', 'CosmosDb', 'RedHat',
        /// 'SqlDataWarehouse', 'VMwareCloudSimple', 'RedHatOsa'
        /// </summary>
        [JsonProperty(PropertyName = "reservedResourceType")]
        public string ReservedResourceType { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'On', 'Off'
        /// </summary>
        [JsonProperty(PropertyName = "instanceFlexibility")]
        public string InstanceFlexibility { get; set; }

        /// <summary>
        /// Gets or sets friendly name for user to easily identify the
        /// reservation
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "appliedScopes")]
        public IList<string> AppliedScopes { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Single', 'Shared'
        /// </summary>
        [JsonProperty(PropertyName = "appliedScopeType")]
        public string AppliedScopeType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Gets or sets current state of the reservation.
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public string ProvisioningState { get; set; }

        /// <summary>
        /// Gets or sets dateTime of the Reservation starting when this version
        /// is effective from.
        /// </summary>
        [JsonProperty(PropertyName = "effectiveDateTime")]
        public System.DateTime? EffectiveDateTime { get; set; }

        /// <summary>
        /// Gets dateTime of the last time the Reservation was updated.
        /// </summary>
        [JsonProperty(PropertyName = "lastUpdatedDateTime")]
        public System.DateTime? LastUpdatedDateTime { get; private set; }

        /// <summary>
        /// Gets or sets this is the date when the Reservation will expire.
        /// </summary>
        [JsonConverter(typeof(DateJsonConverter))]
        [JsonProperty(PropertyName = "expiryDate")]
        public System.DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets description of the SKU in english.
        /// </summary>
        [JsonProperty(PropertyName = "skuDescription")]
        public string SkuDescription { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedStatusInfo")]
        public ExtendedStatusInfo ExtendedStatusInfo { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Upfront', 'Monthly'
        /// </summary>
        [JsonProperty(PropertyName = "billingPlan")]
        public string BillingPlan { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "splitProperties")]
        public ReservationSplitProperties SplitProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mergeProperties")]
        public ReservationMergeProperties MergeProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "billingScopeId")]
        public string BillingScopeId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "renew")]
        public bool? Renew { get; set; }

        /// <summary>
        /// Gets or sets reservation Id of the reservation from which this
        /// reservation is renewed. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}.
        /// </summary>
        [JsonProperty(PropertyName = "renewSource")]
        public string RenewSource { get; set; }

        /// <summary>
        /// Gets or sets reservation Id of the reservation which is purchased
        /// because of renew. Format of the resource Id is
        /// /providers/Microsoft.Capacity/reservationOrders/{reservationOrderId}/reservations/{reservationId}.
        /// </summary>
        [JsonProperty(PropertyName = "renewDestination")]
        public string RenewDestination { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "renewProperties")]
        public RenewPropertiesResponse RenewProperties { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'P1Y', 'P3Y'
        /// </summary>
        [JsonProperty(PropertyName = "term")]
        public string Term { get; set; }

    }
}
