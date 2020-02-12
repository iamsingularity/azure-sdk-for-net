// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Blueprint.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Value for the specified parameter. Can be either 'value' or 'reference'
    /// but not both.
    /// </summary>
    public partial class ParameterValue
    {
        /// <summary>
        /// Initializes a new instance of the ParameterValue class.
        /// </summary>
        public ParameterValue()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParameterValue class.
        /// </summary>
        /// <param name="value">Parameter value as value type.</param>
        /// <param name="reference">Parameter value as reference type.</param>
        public ParameterValue(object value = default(object), SecretValueReference reference = default(SecretValueReference))
        {
            Value = value;
            Reference = reference;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets parameter value as value type.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public object Value { get; set; }

        /// <summary>
        /// Gets or sets parameter value as reference type.
        /// </summary>
        [JsonProperty(PropertyName = "reference")]
        public SecretValueReference Reference { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Reference != null)
            {
                Reference.Validate();
            }
        }
    }
}