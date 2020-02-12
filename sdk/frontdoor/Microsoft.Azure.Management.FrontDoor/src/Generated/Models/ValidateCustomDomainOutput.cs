// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.FrontDoor.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Output of custom domain validation.
    /// </summary>
    public partial class ValidateCustomDomainOutput
    {
        /// <summary>
        /// Initializes a new instance of the ValidateCustomDomainOutput class.
        /// </summary>
        public ValidateCustomDomainOutput()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidateCustomDomainOutput class.
        /// </summary>
        /// <param name="customDomainValidated">Indicates whether the custom
        /// domain is valid or not.</param>
        /// <param name="reason">The reason why the custom domain is not
        /// valid.</param>
        /// <param name="message">Error message describing why the custom
        /// domain is not valid.</param>
        public ValidateCustomDomainOutput(bool? customDomainValidated = default(bool?), string reason = default(string), string message = default(string))
        {
            CustomDomainValidated = customDomainValidated;
            Reason = reason;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets indicates whether the custom domain is valid or not.
        /// </summary>
        [JsonProperty(PropertyName = "customDomainValidated")]
        public bool? CustomDomainValidated { get; private set; }

        /// <summary>
        /// Gets the reason why the custom domain is not valid.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; private set; }

        /// <summary>
        /// Gets error message describing why the custom domain is not valid.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}
