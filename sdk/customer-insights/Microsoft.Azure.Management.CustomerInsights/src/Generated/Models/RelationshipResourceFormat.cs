// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Azure;
    using Management;
    using CustomerInsights;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The relationship resource format.
    /// </summary>
    [JsonTransformation]
    public partial class RelationshipResourceFormat : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the RelationshipResourceFormat class.
        /// </summary>
        public RelationshipResourceFormat() { }

        /// <summary>
        /// Initializes a new instance of the RelationshipResourceFormat class.
        /// </summary>
        /// <param name="profileType">Profile type.</param>
        /// <param name="relatedProfileType">Related profile being
        /// referenced.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="cardinality">The Relationship Cardinality. Possible
        /// values include: 'OneToOne', 'OneToMany', 'ManyToMany'</param>
        /// <param name="displayName">Localized display name for the
        /// Relationship.</param>
        /// <param name="description">Localized descriptions for the
        /// Relationship.</param>
        /// <param name="expiryDateTimeUtc">The expiry date time in
        /// UTC.</param>
        /// <param name="fields">The properties of the Relationship.</param>
        /// <param name="lookupMappings">Optional property to be used to map
        /// fields in profile to their strong ids in related profile.</param>
        /// <param name="provisioningState">Provisioning state. Possible values
        /// include: 'Provisioning', 'Succeeded', 'Expiring', 'Deleting',
        /// 'HumanIntervention', 'Failed'</param>
        /// <param name="relationshipName">The Relationship name.</param>
        /// <param name="relationshipGuidId">The relationship guid id.</param>
        /// <param name="tenantId">The hub name.</param>
        public RelationshipResourceFormat(string profileType, string relatedProfileType, string id = default(string), string name = default(string), string type = default(string), CardinalityTypes? cardinality = default(CardinalityTypes?), IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, string> description = default(IDictionary<string, string>), System.DateTime? expiryDateTimeUtc = default(System.DateTime?), IList<PropertyDefinition> fields = default(IList<PropertyDefinition>), IList<RelationshipTypeMapping> lookupMappings = default(IList<RelationshipTypeMapping>), string provisioningState = default(string), string relationshipName = default(string), string relationshipGuidId = default(string), string tenantId = default(string))
            : base(id, name, type)
        {
            Cardinality = cardinality;
            DisplayName = displayName;
            Description = description;
            ExpiryDateTimeUtc = expiryDateTimeUtc;
            Fields = fields;
            LookupMappings = lookupMappings;
            ProfileType = profileType;
            ProvisioningState = provisioningState;
            RelationshipName = relationshipName;
            RelatedProfileType = relatedProfileType;
            RelationshipGuidId = relationshipGuidId;
            TenantId = tenantId;
        }

        /// <summary>
        /// Gets or sets the Relationship Cardinality. Possible values include:
        /// 'OneToOne', 'OneToMany', 'ManyToMany'
        /// </summary>
        [JsonProperty(PropertyName = "properties.cardinality")]
        public CardinalityTypes? Cardinality { get; set; }

        /// <summary>
        /// Gets or sets localized display name for the Relationship.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized descriptions for the Relationship.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets the expiry date time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expiryDateTimeUtc")]
        public System.DateTime? ExpiryDateTimeUtc { get; set; }

        /// <summary>
        /// Gets or sets the properties of the Relationship.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fields")]
        public IList<PropertyDefinition> Fields { get; set; }

        /// <summary>
        /// Gets or sets optional property to be used to map fields in profile
        /// to their strong ids in related profile.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lookupMappings")]
        public IList<RelationshipTypeMapping> LookupMappings { get; set; }

        /// <summary>
        /// Gets or sets profile type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.profileType")]
        public string ProfileType { get; set; }

        /// <summary>
        /// Gets provisioning state. Possible values include: 'Provisioning',
        /// 'Succeeded', 'Expiring', 'Deleting', 'HumanIntervention', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public string ProvisioningState { get; protected set; }

        /// <summary>
        /// Gets the Relationship name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relationshipName")]
        public string RelationshipName { get; protected set; }

        /// <summary>
        /// Gets or sets related profile being referenced.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relatedProfileType")]
        public string RelatedProfileType { get; set; }

        /// <summary>
        /// Gets the relationship guid id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.relationshipGuidId")]
        public string RelationshipGuidId { get; protected set; }

        /// <summary>
        /// Gets the hub name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.tenantId")]
        public string TenantId { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProfileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProfileType");
            }
            if (RelatedProfileType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelatedProfileType");
            }
            if (Fields != null)
            {
                foreach (var element in Fields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (LookupMappings != null)
            {
                foreach (var element1 in LookupMappings)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
        }
    }
}

