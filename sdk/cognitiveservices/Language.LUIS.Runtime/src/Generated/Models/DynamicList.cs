// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Runtime.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines an extension for a list entity.
    /// </summary>
    public partial class DynamicList
    {
        /// <summary>
        /// Initializes a new instance of the DynamicList class.
        /// </summary>
        public DynamicList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DynamicList class.
        /// </summary>
        /// <param name="listEntityName">The name of the list entity to
        /// extend.</param>
        /// <param name="requestLists">The lists to append on the extended list
        /// entity.</param>
        public DynamicList(string listEntityName, IList<RequestList> requestLists)
        {
            ListEntityName = listEntityName;
            RequestLists = requestLists;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the list entity to extend.
        /// </summary>
        [JsonProperty(PropertyName = "listEntityName")]
        public string ListEntityName { get; set; }

        /// <summary>
        /// Gets or sets the lists to append on the extended list entity.
        /// </summary>
        [JsonProperty(PropertyName = "requestLists")]
        public IList<RequestList> RequestLists { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (ListEntityName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ListEntityName");
            }
            if (RequestLists == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RequestLists");
            }
            if (RequestLists != null)
            {
                foreach (var element in RequestLists)
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
