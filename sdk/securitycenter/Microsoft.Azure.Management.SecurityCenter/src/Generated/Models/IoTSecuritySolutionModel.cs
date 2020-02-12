// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IoT Security solution configuration and resource information.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class IoTSecuritySolutionModel
    {
        /// <summary>
        /// Initializes a new instance of the IoTSecuritySolutionModel class.
        /// </summary>
        public IoTSecuritySolutionModel()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the IoTSecuritySolutionModel class.
        /// </summary>
        /// <param name="workspace">Workspace resource ID</param>
        /// <param name="displayName">Resource display name.</param>
        /// <param name="iotHubs">IoT Hub resource IDs</param>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="location">The resource location.</param>
        /// <param name="status">Status of the IoT Security solution. Possible
        /// values include: 'Enabled', 'Disabled'</param>
        /// <param name="export">List of additional options for exporting to
        /// workspace data.</param>
        /// <param name="disabledDataSources">Disabled data sources. Disabling
        /// these data sources compromises the system.</param>
        /// <param name="autoDiscoveredResources">List of resources that were
        /// automatically discovered as relevant to the security
        /// solution.</param>
        /// <param name="unmaskedIpLoggingStatus">Unmasked IP address logging
        /// status. Possible values include: 'Disabled', 'Enabled'</param>
        public IoTSecuritySolutionModel(string workspace, string displayName, IList<string> iotHubs, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string location = default(string), string status = default(string), IList<string> export = default(IList<string>), IList<string> disabledDataSources = default(IList<string>), UserDefinedResourcesProperties userDefinedResources = default(UserDefinedResourcesProperties), IList<string> autoDiscoveredResources = default(IList<string>), IList<RecommendationConfigurationProperties> recommendationsConfiguration = default(IList<RecommendationConfigurationProperties>), string unmaskedIpLoggingStatus = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            Tags = tags;
            Location = location;
            Workspace = workspace;
            DisplayName = displayName;
            Status = status;
            Export = export;
            DisabledDataSources = disabledDataSources;
            IotHubs = iotHubs;
            UserDefinedResources = userDefinedResources;
            AutoDiscoveredResources = autoDiscoveredResources;
            RecommendationsConfiguration = recommendationsConfiguration;
            UnmaskedIpLoggingStatus = unmaskedIpLoggingStatus;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets resource tags
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the resource location.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets workspace resource ID
        /// </summary>
        [JsonProperty(PropertyName = "properties.workspace")]
        public string Workspace { get; set; }

        /// <summary>
        /// Gets or sets resource display name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets status of the IoT Security solution. Possible values
        /// include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets list of additional options for exporting to workspace
        /// data.
        /// </summary>
        [JsonProperty(PropertyName = "properties.export")]
        public IList<string> Export { get; set; }

        /// <summary>
        /// Gets or sets disabled data sources. Disabling these data sources
        /// compromises the system.
        /// </summary>
        [JsonProperty(PropertyName = "properties.disabledDataSources")]
        public IList<string> DisabledDataSources { get; set; }

        /// <summary>
        /// Gets or sets ioT Hub resource IDs
        /// </summary>
        [JsonProperty(PropertyName = "properties.iotHubs")]
        public IList<string> IotHubs { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.userDefinedResources")]
        public UserDefinedResourcesProperties UserDefinedResources { get; set; }

        /// <summary>
        /// Gets list of resources that were automatically discovered as
        /// relevant to the security solution.
        /// </summary>
        [JsonProperty(PropertyName = "properties.autoDiscoveredResources")]
        public IList<string> AutoDiscoveredResources { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties.recommendationsConfiguration")]
        public IList<RecommendationConfigurationProperties> RecommendationsConfiguration { get; set; }

        /// <summary>
        /// Gets or sets unmasked IP address logging status. Possible values
        /// include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.unmaskedIpLoggingStatus")]
        public string UnmaskedIpLoggingStatus { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Workspace == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Workspace");
            }
            if (DisplayName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DisplayName");
            }
            if (IotHubs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "IotHubs");
            }
            if (UserDefinedResources != null)
            {
                UserDefinedResources.Validate();
            }
            if (RecommendationsConfiguration != null)
            {
                foreach (var element in RecommendationsConfiguration)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}