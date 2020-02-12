// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Knowledge.QnAMaker.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Context object with previous QnA's information.
    /// </summary>
    public partial class QueryContextDTO
    {
        /// <summary>
        /// Initializes a new instance of the QueryContextDTO class.
        /// </summary>
        public QueryContextDTO()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the QueryContextDTO class.
        /// </summary>
        /// <param name="previousQnaId">Previous QnA Id - qnaId of the top
        /// result.</param>
        /// <param name="previousUserQuery">Previous user query.</param>
        public QueryContextDTO(string previousQnaId = default(string), string previousUserQuery = default(string))
        {
            PreviousQnaId = previousQnaId;
            PreviousUserQuery = previousUserQuery;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets previous QnA Id - qnaId of the top result.
        /// </summary>
        [JsonProperty(PropertyName = "previousQnaId")]
        public string PreviousQnaId { get; set; }

        /// <summary>
        /// Gets or sets previous user query.
        /// </summary>
        [JsonProperty(PropertyName = "previousUserQuery")]
        public string PreviousUserQuery { get; set; }

    }
}