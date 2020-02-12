// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ApplicationInsights.Query
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// QueryOperations operations.
    /// </summary>
    public partial interface IQueryOperations
    {
        /// <summary>
        /// Execute an Analytics query
        /// </summary>
        /// <remarks>
        /// Executes an Analytics query for data.
        /// [Here](https://dev.applicationinsights.io/documentation/Using-the-API/Query)
        /// is an example for using POST with an Analytics query.
        /// </remarks>
        /// <param name='appId'>
        /// ID of the application. This is Application ID from the API Access
        /// settings blade in the Azure portal.
        /// </param>
        /// <param name='query'>
        /// The query to execute.
        /// </param>
        /// <param name='timespan'>
        /// Optional. The timespan over which to query data. This is an ISO8601
        /// time period value.  This timespan is applied in addition to any
        /// that are specified in the query expression.
        /// </param>
        /// <param name='applications'>
        /// A list of Application IDs for cross-application queries.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<QueryResults>> ExecuteWithHttpMessagesAsync(string appId, string query, string timespan = default(string), IList<string> applications = default(IList<string>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
