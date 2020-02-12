// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerRegistry
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;

    /// <summary>
    /// Extension methods for WebhooksOperations.
    /// </summary>
    public static partial class WebhooksOperationsExtensions
    {
            /// <summary>
            /// Gets the properties of the specified webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            public static Webhook Get(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName)
            {
                return operations.GetAsync(resourceGroupName, registryName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Webhook> GetAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a webhook for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookCreateParameters'>
            /// The parameters for creating a webhook.
            /// </param>
            public static Webhook Create(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookCreateParameters webhookCreateParameters)
            {
                return operations.CreateAsync(resourceGroupName, registryName, webhookName, webhookCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a webhook for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookCreateParameters'>
            /// The parameters for creating a webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Webhook> CreateAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookCreateParameters webhookCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, webhookCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a webhook from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            public static void Delete(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a webhook from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task DeleteAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a webhook with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookUpdateParameters'>
            /// The parameters for updating a webhook.
            /// </param>
            public static Webhook Update(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookUpdateParameters webhookUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, registryName, webhookName, webhookUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a webhook with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookUpdateParameters'>
            /// The parameters for updating a webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Webhook> UpdateAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookUpdateParameters webhookUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, webhookUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the webhooks for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            public static IPage<Webhook> List(this IWebhooksOperations operations, string resourceGroupName, string registryName)
            {
                return operations.ListAsync(resourceGroupName, registryName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the webhooks for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<Webhook>> ListAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Triggers a ping event to be sent to the webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            public static EventInfo Ping(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName)
            {
                return operations.PingAsync(resourceGroupName, registryName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Triggers a ping event to be sent to the webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<EventInfo> PingAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PingWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the configuration of service URI and custom headers for the webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            public static CallbackConfig GetCallbackConfig(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName)
            {
                return operations.GetCallbackConfigAsync(resourceGroupName, registryName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the configuration of service URI and custom headers for the webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<CallbackConfig> GetCallbackConfigAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetCallbackConfigWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists recent events for the specified webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            public static IPage<EventModel> ListEvents(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName)
            {
                return operations.ListEventsAsync(resourceGroupName, registryName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists recent events for the specified webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<EventModel>> ListEventsAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEventsWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a webhook for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookCreateParameters'>
            /// The parameters for creating a webhook.
            /// </param>
            public static Webhook BeginCreate(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookCreateParameters webhookCreateParameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, registryName, webhookName, webhookCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a webhook for a container registry with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookCreateParameters'>
            /// The parameters for creating a webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Webhook> BeginCreateAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookCreateParameters webhookCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, webhookCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a webhook from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            public static void BeginDelete(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, webhookName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a webhook from a container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task BeginDeleteAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a webhook with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookUpdateParameters'>
            /// The parameters for updating a webhook.
            /// </param>
            public static Webhook BeginUpdate(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookUpdateParameters webhookUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, registryName, webhookName, webhookUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a webhook with the specified parameters.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group to which the container registry belongs.
            /// </param>
            /// <param name='registryName'>
            /// The name of the container registry.
            /// </param>
            /// <param name='webhookName'>
            /// The name of the webhook.
            /// </param>
            /// <param name='webhookUpdateParameters'>
            /// The parameters for updating a webhook.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Webhook> BeginUpdateAsync(this IWebhooksOperations operations, string resourceGroupName, string registryName, string webhookName, WebhookUpdateParameters webhookUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, webhookName, webhookUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the webhooks for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Webhook> ListNext(this IWebhooksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the webhooks for the specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<Webhook>> ListNextAsync(this IWebhooksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists recent events for the specified webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<EventModel> ListEventsNext(this IWebhooksOperations operations, string nextPageLink)
            {
                return operations.ListEventsNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists recent events for the specified webhook.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<IPage<EventModel>> ListEventsNextAsync(this IWebhooksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListEventsNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
