// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Trigger based on request execution time.
    /// </summary>
    public partial class SlowRequestsBasedTrigger
    {
        /// <summary>
        /// Initializes a new instance of the SlowRequestsBasedTrigger class.
        /// </summary>
        public SlowRequestsBasedTrigger()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SlowRequestsBasedTrigger class.
        /// </summary>
        /// <param name="timeTaken">Time taken.</param>
        /// <param name="count">Request Count.</param>
        /// <param name="timeInterval">Time interval.</param>
        public SlowRequestsBasedTrigger(string timeTaken = default(string), int? count = default(int?), string timeInterval = default(string))
        {
            TimeTaken = timeTaken;
            Count = count;
            TimeInterval = timeInterval;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets time taken.
        /// </summary>
        [JsonProperty(PropertyName = "timeTaken")]
        public string TimeTaken { get; set; }

        /// <summary>
        /// Gets or sets request Count.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int? Count { get; set; }

        /// <summary>
        /// Gets or sets time interval.
        /// </summary>
        [JsonProperty(PropertyName = "timeInterval")]
        public string TimeInterval { get; set; }

    }
}
