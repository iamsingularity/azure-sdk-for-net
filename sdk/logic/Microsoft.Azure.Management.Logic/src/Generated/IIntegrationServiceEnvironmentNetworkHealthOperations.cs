// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// IntegrationServiceEnvironmentNetworkHealthOperations operations.
    /// </summary>
    public partial interface IIntegrationServiceEnvironmentNetworkHealthOperations
    {
        /// <summary>
        /// Gets the integration service environment network health.
        /// </summary>
        /// <param name='resourceGroup'>
        /// The resource group.
        /// </param>
        /// <param name='integrationServiceEnvironmentName'>
        /// The integration service environment name.
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
        Task<AzureOperationResponse<IDictionary<string, IntegrationServiceEnvironmentSubnetNetworkHealth>>> GetWithHttpMessagesAsync(string resourceGroup, string integrationServiceEnvironmentName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
