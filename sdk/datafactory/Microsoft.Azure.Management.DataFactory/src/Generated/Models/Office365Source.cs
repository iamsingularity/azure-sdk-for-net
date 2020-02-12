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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A copy activity source for an Office 365 service.
    /// </summary>
    public partial class Office365Source : CopySource
    {
        /// <summary>
        /// Initializes a new instance of the Office365Source class.
        /// </summary>
        public Office365Source()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Office365Source class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="sourceRetryCount">Source retry count. Type: integer
        /// (or Expression with resultType integer).</param>
        /// <param name="sourceRetryWait">Source retry wait. Type: string (or
        /// Expression with resultType string), pattern:
        /// ((\d+)\.)?(\d\d):(60|([0-5][0-9])):(60|([0-5][0-9])).</param>
        /// <param name="maxConcurrentConnections">The maximum concurrent
        /// connection count for the source data store. Type: integer (or
        /// Expression with resultType integer).</param>
        /// <param name="allowedGroups">The groups containing all the users.
        /// Type: array of strings (or Expression with resultType array of
        /// strings).</param>
        /// <param name="userScopeFilterUri">The user scope uri. Type: string
        /// (or Expression with resultType string).</param>
        /// <param name="dateFilterColumn">The Column to apply the &lt;paramref
        /// name="StartTime"/&gt; and &lt;paramref name="EndTime"/&gt;. Type:
        /// string (or Expression with resultType string).</param>
        /// <param name="startTime">Start time of the requested range for this
        /// dataset. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="endTime">End time of the requested range for this
        /// dataset. Type: string (or Expression with resultType
        /// string).</param>
        /// <param name="outputColumns">The columns to be read out from the
        /// Office 365 table. Type: array of objects (or Expression with
        /// resultType array of objects). Example: [ { "name": "Id" }, {
        /// "name": "CreatedDateTime" } ]</param>
        public Office365Source(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), object sourceRetryCount = default(object), object sourceRetryWait = default(object), object maxConcurrentConnections = default(object), object allowedGroups = default(object), object userScopeFilterUri = default(object), object dateFilterColumn = default(object), object startTime = default(object), object endTime = default(object), object outputColumns = default(object))
            : base(additionalProperties, sourceRetryCount, sourceRetryWait, maxConcurrentConnections)
        {
            AllowedGroups = allowedGroups;
            UserScopeFilterUri = userScopeFilterUri;
            DateFilterColumn = dateFilterColumn;
            StartTime = startTime;
            EndTime = endTime;
            OutputColumns = outputColumns;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the groups containing all the users. Type: array of
        /// strings (or Expression with resultType array of strings).
        /// </summary>
        [JsonProperty(PropertyName = "allowedGroups")]
        public object AllowedGroups { get; set; }

        /// <summary>
        /// Gets or sets the user scope uri. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "userScopeFilterUri")]
        public object UserScopeFilterUri { get; set; }

        /// <summary>
        /// Gets or sets the Column to apply the &amp;lt;paramref
        /// name="StartTime"/&amp;gt; and &amp;lt;paramref
        /// name="EndTime"/&amp;gt;. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "dateFilterColumn")]
        public object DateFilterColumn { get; set; }

        /// <summary>
        /// Gets or sets start time of the requested range for this dataset.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public object StartTime { get; set; }

        /// <summary>
        /// Gets or sets end time of the requested range for this dataset.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "endTime")]
        public object EndTime { get; set; }

        /// <summary>
        /// Gets or sets the columns to be read out from the Office 365 table.
        /// Type: array of objects (or Expression with resultType array of
        /// objects). Example: [ { "name": "Id" }, { "name": "CreatedDateTime"
        /// } ]
        /// </summary>
        [JsonProperty(PropertyName = "outputColumns")]
        public object OutputColumns { get; set; }

    }
}