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
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Describes a profile type participating in an interaction.
    /// </summary>
    public partial class Participant
    {
        /// <summary>
        /// Initializes a new instance of the Participant class.
        /// </summary>
        public Participant() { }

        /// <summary>
        /// Initializes a new instance of the Participant class.
        /// </summary>
        /// <param name="profileTypeName">Profile type name.</param>
        /// <param name="participantPropertyReferences">The property
        /// references.</param>
        /// <param name="participantName">Participant name.</param>
        /// <param name="displayName">Localized display name.</param>
        /// <param name="description">Localized descriptions.</param>
        /// <param name="role">The role that the participant is playing in the
        /// interaction.</param>
        public Participant(string profileTypeName, IList<ParticipantPropertyReference> participantPropertyReferences, string participantName, IDictionary<string, string> displayName = default(IDictionary<string, string>), IDictionary<string, string> description = default(IDictionary<string, string>), string role = default(string))
        {
            ProfileTypeName = profileTypeName;
            ParticipantPropertyReferences = participantPropertyReferences;
            ParticipantName = participantName;
            DisplayName = displayName;
            Description = description;
            Role = role;
        }

        /// <summary>
        /// Gets or sets profile type name.
        /// </summary>
        [JsonProperty(PropertyName = "profileTypeName")]
        public string ProfileTypeName { get; set; }

        /// <summary>
        /// Gets or sets the property references.
        /// </summary>
        [JsonProperty(PropertyName = "participantPropertyReferences")]
        public IList<ParticipantPropertyReference> ParticipantPropertyReferences { get; set; }

        /// <summary>
        /// Gets or sets participant name.
        /// </summary>
        [JsonProperty(PropertyName = "participantName")]
        public string ParticipantName { get; set; }

        /// <summary>
        /// Gets or sets localized display name.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public IDictionary<string, string> DisplayName { get; set; }

        /// <summary>
        /// Gets or sets localized descriptions.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public IDictionary<string, string> Description { get; set; }

        /// <summary>
        /// Gets or sets the role that the participant is playing in the
        /// interaction.
        /// </summary>
        [JsonProperty(PropertyName = "role")]
        public string Role { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ProfileTypeName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ProfileTypeName");
            }
            if (ParticipantPropertyReferences == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ParticipantPropertyReferences");
            }
            if (ParticipantName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ParticipantName");
            }
            if (ParticipantPropertyReferences != null)
            {
                foreach (var element in ParticipantPropertyReferences)
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

