// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The backup key result, containing the backup blob.
    /// </summary>
    public partial class BackupKeyResult
    {
        /// <summary>
        /// Initializes a new instance of the BackupKeyResult class.
        /// </summary>
        public BackupKeyResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupKeyResult class.
        /// </summary>
        /// <param name="value">The backup blob containing the backed up
        /// key.</param>
        public BackupKeyResult(byte[] value = default(byte[]))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the backup blob containing the backed up key.
        /// </summary>
        [JsonConverter(typeof(Base64UrlJsonConverter))]
        [JsonProperty(PropertyName = "value")]
        public byte[] Value { get; private set; }

    }
}
