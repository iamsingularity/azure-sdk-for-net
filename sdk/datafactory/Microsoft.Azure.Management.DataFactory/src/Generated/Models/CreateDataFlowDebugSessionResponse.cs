// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Response body structure for creating data flow debug session.
    /// </summary>
    public partial class CreateDataFlowDebugSessionResponse
    {
        /// <summary>
        /// Initializes a new instance of the
        /// CreateDataFlowDebugSessionResponse class.
        /// </summary>
        public CreateDataFlowDebugSessionResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// CreateDataFlowDebugSessionResponse class.
        /// </summary>
        /// <param name="status">The state of the debug session.</param>
        /// <param name="sessionId">The ID of data flow debug session.</param>
        public CreateDataFlowDebugSessionResponse(string status = default(string), string sessionId = default(string))
        {
            Status = status;
            SessionId = sessionId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the state of the debug session.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the ID of data flow debug session.
        /// </summary>
        [JsonProperty(PropertyName = "sessionId")]
        public string SessionId { get; set; }

    }
}
