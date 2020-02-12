// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// VirtualHub route.
    /// </summary>
    public partial class VirtualHubRoute
    {
        /// <summary>
        /// Initializes a new instance of the VirtualHubRoute class.
        /// </summary>
        public VirtualHubRoute()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualHubRoute class.
        /// </summary>
        /// <param name="addressPrefixes">List of all addressPrefixes.</param>
        /// <param name="nextHopIpAddress">NextHop ip address.</param>
        public VirtualHubRoute(IList<string> addressPrefixes = default(IList<string>), string nextHopIpAddress = default(string))
        {
            AddressPrefixes = addressPrefixes;
            NextHopIpAddress = nextHopIpAddress;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of all addressPrefixes.
        /// </summary>
        [JsonProperty(PropertyName = "addressPrefixes")]
        public IList<string> AddressPrefixes { get; set; }

        /// <summary>
        /// Gets or sets nextHop ip address.
        /// </summary>
        [JsonProperty(PropertyName = "nextHopIpAddress")]
        public string NextHopIpAddress { get; set; }

    }
}
