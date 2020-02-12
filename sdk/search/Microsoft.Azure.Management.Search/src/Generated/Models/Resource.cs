// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Search.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Base type for all Azure resources.
    /// </summary>
    public partial class Resource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="id">The ID of the resource. This can be used with the
        /// Azure Resource Manager to link resources together.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The resource type.</param>
        /// <param name="location">The geographic location of the resource.
        /// This must be one of the supported and registered Azure Geo Regions
        /// (for example, West US, East US, Southeast Asia, and so forth). This
        /// property is required when creating a new resource.</param>
        /// <param name="tags">Tags to help categorize the resource in the
        /// Azure portal.</param>
        /// <param name="identity">The identity of the resource.</param>
        public Resource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Identity identity = default(Identity))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            Identity = identity;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the ID of the resource. This can be used with the Azure
        /// Resource Manager to link resources together.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the geographic location of the resource. This must be
        /// one of the supported and registered Azure Geo Regions (for example,
        /// West US, East US, Southeast Asia, and so forth). This property is
        /// required when creating a new resource.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets tags to help categorize the resource in the Azure
        /// portal.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the identity of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public Identity Identity { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Identity != null)
            {
                Identity.Validate();
            }
        }
    }
}
