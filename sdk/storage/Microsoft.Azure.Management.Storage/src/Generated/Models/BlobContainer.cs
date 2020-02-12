// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Properties of the blob container, including Id, resource name, resource
    /// type, Etag.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class BlobContainer : AzureEntityResource
    {
        /// <summary>
        /// Initializes a new instance of the BlobContainer class.
        /// </summary>
        public BlobContainer()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BlobContainer class.
        /// </summary>
        /// <param name="id">Fully qualified resource Id for the resource. Ex -
        /// /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}</param>
        /// <param name="name">The name of the resource</param>
        /// <param name="type">The type of the resource. Ex-
        /// Microsoft.Compute/virtualMachines or
        /// Microsoft.Storage/storageAccounts.</param>
        /// <param name="etag">Resource Etag.</param>
        /// <param name="publicAccess">Specifies whether data in the container
        /// may be accessed publicly and the level of access. Possible values
        /// include: 'Container', 'Blob', 'None'</param>
        /// <param name="lastModifiedTime">Returns the date and time the
        /// container was last modified.</param>
        /// <param name="leaseStatus">The lease status of the container.
        /// Possible values include: 'Locked', 'Unlocked'</param>
        /// <param name="leaseState">Lease state of the container. Possible
        /// values include: 'Available', 'Leased', 'Expired', 'Breaking',
        /// 'Broken'</param>
        /// <param name="leaseDuration">Specifies whether the lease on a
        /// container is of infinite or fixed duration, only when the container
        /// is leased. Possible values include: 'Infinite', 'Fixed'</param>
        /// <param name="metadata">A name-value pair to associate with the
        /// container as metadata.</param>
        /// <param name="immutabilityPolicy">The ImmutabilityPolicy property of
        /// the container.</param>
        /// <param name="legalHold">The LegalHold property of the
        /// container.</param>
        /// <param name="hasLegalHold">The hasLegalHold public property is set
        /// to true by SRP if there are at least one existing tag. The
        /// hasLegalHold public property is set to false by SRP if all existing
        /// legal hold tags are cleared out. There can be a maximum of 1000
        /// blob containers with hasLegalHold=true for a given account.</param>
        /// <param name="hasImmutabilityPolicy">The hasImmutabilityPolicy
        /// public property is set to true by SRP if ImmutabilityPolicy has
        /// been created for this container. The hasImmutabilityPolicy public
        /// property is set to false by SRP if ImmutabilityPolicy has not been
        /// created for this container.</param>
        public BlobContainer(string id = default(string), string name = default(string), string type = default(string), string etag = default(string), PublicAccess? publicAccess = default(PublicAccess?), System.DateTime? lastModifiedTime = default(System.DateTime?), string leaseStatus = default(string), string leaseState = default(string), string leaseDuration = default(string), IDictionary<string, string> metadata = default(IDictionary<string, string>), ImmutabilityPolicyProperties immutabilityPolicy = default(ImmutabilityPolicyProperties), LegalHoldProperties legalHold = default(LegalHoldProperties), bool? hasLegalHold = default(bool?), bool? hasImmutabilityPolicy = default(bool?))
            : base(id, name, type, etag)
        {
            PublicAccess = publicAccess;
            LastModifiedTime = lastModifiedTime;
            LeaseStatus = leaseStatus;
            LeaseState = leaseState;
            LeaseDuration = leaseDuration;
            Metadata = metadata;
            ImmutabilityPolicy = immutabilityPolicy;
            LegalHold = legalHold;
            HasLegalHold = hasLegalHold;
            HasImmutabilityPolicy = hasImmutabilityPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets specifies whether data in the container may be
        /// accessed publicly and the level of access. Possible values include:
        /// 'Container', 'Blob', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicAccess")]
        public PublicAccess? PublicAccess { get; set; }

        /// <summary>
        /// Gets returns the date and time the container was last modified.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the lease status of the container. Possible values include:
        /// 'Locked', 'Unlocked'
        /// </summary>
        [JsonProperty(PropertyName = "properties.leaseStatus")]
        public string LeaseStatus { get; private set; }

        /// <summary>
        /// Gets lease state of the container. Possible values include:
        /// 'Available', 'Leased', 'Expired', 'Breaking', 'Broken'
        /// </summary>
        [JsonProperty(PropertyName = "properties.leaseState")]
        public string LeaseState { get; private set; }

        /// <summary>
        /// Gets specifies whether the lease on a container is of infinite or
        /// fixed duration, only when the container is leased. Possible values
        /// include: 'Infinite', 'Fixed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.leaseDuration")]
        public string LeaseDuration { get; private set; }

        /// <summary>
        /// Gets or sets a name-value pair to associate with the container as
        /// metadata.
        /// </summary>
        [JsonProperty(PropertyName = "properties.metadata")]
        public IDictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// Gets the ImmutabilityPolicy property of the container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.immutabilityPolicy")]
        public ImmutabilityPolicyProperties ImmutabilityPolicy { get; private set; }

        /// <summary>
        /// Gets the LegalHold property of the container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.legalHold")]
        public LegalHoldProperties LegalHold { get; private set; }

        /// <summary>
        /// Gets the hasLegalHold public property is set to true by SRP if
        /// there are at least one existing tag. The hasLegalHold public
        /// property is set to false by SRP if all existing legal hold tags are
        /// cleared out. There can be a maximum of 1000 blob containers with
        /// hasLegalHold=true for a given account.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasLegalHold")]
        public bool? HasLegalHold { get; private set; }

        /// <summary>
        /// Gets the hasImmutabilityPolicy public property is set to true by
        /// SRP if ImmutabilityPolicy has been created for this container. The
        /// hasImmutabilityPolicy public property is set to false by SRP if
        /// ImmutabilityPolicy has not been created for this container.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hasImmutabilityPolicy")]
        public bool? HasImmutabilityPolicy { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ImmutabilityPolicy != null)
            {
                ImmutabilityPolicy.Validate();
            }
        }
    }
}
