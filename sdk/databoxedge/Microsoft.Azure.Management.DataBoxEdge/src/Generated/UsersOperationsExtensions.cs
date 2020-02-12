// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBoxEdge
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UsersOperations.
    /// </summary>
    public static partial class UsersOperationsExtensions
    {
            /// <summary>
            /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='filter'>
            /// Specify $filter='UserType eq &lt;type&gt;' to filter on user type property
            /// </param>
            public static IPage<User> ListByDataBoxEdgeDevice(this IUsersOperations operations, string deviceName, string resourceGroupName, string filter = default(string))
            {
                return operations.ListByDataBoxEdgeDeviceAsync(deviceName, resourceGroupName, filter).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='filter'>
            /// Specify $filter='UserType eq &lt;type&gt;' to filter on user type property
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<User>> ListByDataBoxEdgeDeviceAsync(this IUsersOperations operations, string deviceName, string resourceGroupName, string filter = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataBoxEdgeDeviceWithHttpMessagesAsync(deviceName, resourceGroupName, filter, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the properties of the specified user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static User Get(this IUsersOperations operations, string deviceName, string name, string resourceGroupName)
            {
                return operations.GetAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified user.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetAsync(this IUsersOperations operations, string deviceName, string name, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a new user or updates an existing user's information on a Data Box
            /// Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='user'>
            /// The user details.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static User CreateOrUpdate(this IUsersOperations operations, string deviceName, string name, User user, string resourceGroupName)
            {
                return operations.CreateOrUpdateAsync(deviceName, name, user, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new user or updates an existing user's information on a Data Box
            /// Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='user'>
            /// The user details.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> CreateOrUpdateAsync(this IUsersOperations operations, string deviceName, string name, User user, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(deviceName, name, user, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the user on a databox edge/gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static void Delete(this IUsersOperations operations, string deviceName, string name, string resourceGroupName)
            {
                operations.DeleteAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the user on a databox edge/gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IUsersOperations operations, string deviceName, string name, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Creates a new user or updates an existing user's information on a Data Box
            /// Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='user'>
            /// The user details.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static User BeginCreateOrUpdate(this IUsersOperations operations, string deviceName, string name, User user, string resourceGroupName)
            {
                return operations.BeginCreateOrUpdateAsync(deviceName, name, user, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new user or updates an existing user's information on a Data Box
            /// Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='user'>
            /// The user details.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> BeginCreateOrUpdateAsync(this IUsersOperations operations, string deviceName, string name, User user, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(deviceName, name, user, resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the user on a databox edge/gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            public static void BeginDelete(this IUsersOperations operations, string deviceName, string name, string resourceGroupName)
            {
                operations.BeginDeleteAsync(deviceName, name, resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the user on a databox edge/gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='deviceName'>
            /// The device name.
            /// </param>
            /// <param name='name'>
            /// The user name.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IUsersOperations operations, string deviceName, string name, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(deviceName, name, resourceGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<User> ListByDataBoxEdgeDeviceNext(this IUsersOperations operations, string nextPageLink)
            {
                return operations.ListByDataBoxEdgeDeviceNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all the users registered on a Data Box Edge/Data Box Gateway device.
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
            public static async Task<IPage<User>> ListByDataBoxEdgeDeviceNextAsync(this IUsersOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByDataBoxEdgeDeviceNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
