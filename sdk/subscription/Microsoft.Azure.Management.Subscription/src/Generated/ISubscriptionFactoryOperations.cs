// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// SubscriptionFactoryOperations operations.
    /// </summary>
    public partial interface ISubscriptionFactoryOperations
    {
        /// <summary>
        /// The operation to create a new Azure subscription
        /// </summary>
        /// <param name='billingAccountName'>
        /// The name of the Microsoft Customer Agreement billing account for
        /// which you want to create the subscription.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// The name of the invoice section in the billing account for which
        /// you want to create the subscription.
        /// </param>
        /// <param name='body'>
        /// The subscription creation parameters.
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
        Task<AzureOperationResponse<SubscriptionCreationResult,SubscriptionFactoryCreateSubscriptionHeaders>> CreateSubscriptionWithHttpMessagesAsync(string billingAccountName, string invoiceSectionName, ModernSubscriptionCreationParameters body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an Azure subscription
        /// </summary>
        /// <param name='enrollmentAccountName'>
        /// The name of the enrollment account to which the subscription will
        /// be billed.
        /// </param>
        /// <param name='body'>
        /// The subscription creation parameters.
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
        Task<AzureOperationResponse<SubscriptionCreationResult,SubscriptionFactoryCreateSubscriptionInEnrollmentAccountHeaders>> CreateSubscriptionInEnrollmentAccountWithHttpMessagesAsync(string enrollmentAccountName, SubscriptionCreationParameters body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// The operation to create a new Azure subscription
        /// </summary>
        /// <param name='billingAccountName'>
        /// The name of the Microsoft Customer Agreement billing account for
        /// which you want to create the subscription.
        /// </param>
        /// <param name='invoiceSectionName'>
        /// The name of the invoice section in the billing account for which
        /// you want to create the subscription.
        /// </param>
        /// <param name='body'>
        /// The subscription creation parameters.
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
        Task<AzureOperationResponse<SubscriptionCreationResult,SubscriptionFactoryCreateSubscriptionHeaders>> BeginCreateSubscriptionWithHttpMessagesAsync(string billingAccountName, string invoiceSectionName, ModernSubscriptionCreationParameters body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates an Azure subscription
        /// </summary>
        /// <param name='enrollmentAccountName'>
        /// The name of the enrollment account to which the subscription will
        /// be billed.
        /// </param>
        /// <param name='body'>
        /// The subscription creation parameters.
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
        Task<AzureOperationResponse<SubscriptionCreationResult,SubscriptionFactoryCreateSubscriptionInEnrollmentAccountHeaders>> BeginCreateSubscriptionInEnrollmentAccountWithHttpMessagesAsync(string enrollmentAccountName, SubscriptionCreationParameters body, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
