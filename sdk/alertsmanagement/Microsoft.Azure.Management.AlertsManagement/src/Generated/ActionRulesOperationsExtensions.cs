// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.AlertsManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ActionRulesOperations.
    /// </summary>
    public static partial class ActionRulesOperationsExtensions
    {
            /// <summary>
            /// Get all action rule in a given subscription
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='impactedScope'>
            /// filter by impacted/target scope (provide comma separated list for multiple
            /// scopes). The value should be an well constructed ARM id of the scope.
            /// </param>
            /// <param name='description'>
            /// filter by alert rule description
            /// </param>
            /// <param name='alertRuleId'>
            /// filter by alert rule id
            /// </param>
            /// <param name='actionGroup'>
            /// filter by action group configured as part of action rule
            /// </param>
            /// <param name='name'>
            /// filter by action rule name
            /// </param>
            public static IPage<ActionRule> ListBySubscription(this IActionRulesOperations operations, string targetResourceGroup = default(string), string targetResourceType = default(string), string targetResource = default(string), string severity = default(string), string monitorService = default(string), string impactedScope = default(string), string description = default(string), string alertRuleId = default(string), string actionGroup = default(string), string name = default(string))
            {
                return operations.ListBySubscriptionAsync(targetResourceGroup, targetResourceType, targetResource, severity, monitorService, impactedScope, description, alertRuleId, actionGroup, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all action rule in a given subscription
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='impactedScope'>
            /// filter by impacted/target scope (provide comma separated list for multiple
            /// scopes). The value should be an well constructed ARM id of the scope.
            /// </param>
            /// <param name='description'>
            /// filter by alert rule description
            /// </param>
            /// <param name='alertRuleId'>
            /// filter by alert rule id
            /// </param>
            /// <param name='actionGroup'>
            /// filter by action group configured as part of action rule
            /// </param>
            /// <param name='name'>
            /// filter by action rule name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ActionRule>> ListBySubscriptionAsync(this IActionRulesOperations operations, string targetResourceGroup = default(string), string targetResourceType = default(string), string targetResource = default(string), string severity = default(string), string monitorService = default(string), string impactedScope = default(string), string description = default(string), string alertRuleId = default(string), string actionGroup = default(string), string name = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionWithHttpMessagesAsync(targetResourceGroup, targetResourceType, targetResource, severity, monitorService, impactedScope, description, alertRuleId, actionGroup, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all action rules created in a resource group
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription, created in given resource group
            /// and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='impactedScope'>
            /// filter by impacted/target scope (provide comma separated list for multiple
            /// scopes). The value should be an well constructed ARM id of the scope.
            /// </param>
            /// <param name='description'>
            /// filter by alert rule description
            /// </param>
            /// <param name='alertRuleId'>
            /// filter by alert rule id
            /// </param>
            /// <param name='actionGroup'>
            /// filter by action group configured as part of action rule
            /// </param>
            /// <param name='name'>
            /// filter by action rule name
            /// </param>
            public static IPage<ActionRule> ListByResourceGroup(this IActionRulesOperations operations, string resourceGroupName, string targetResourceGroup = default(string), string targetResourceType = default(string), string targetResource = default(string), string severity = default(string), string monitorService = default(string), string impactedScope = default(string), string description = default(string), string alertRuleId = default(string), string actionGroup = default(string), string name = default(string))
            {
                return operations.ListByResourceGroupAsync(resourceGroupName, targetResourceGroup, targetResourceType, targetResource, severity, monitorService, impactedScope, description, alertRuleId, actionGroup, name).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all action rules created in a resource group
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription, created in given resource group
            /// and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='targetResourceGroup'>
            /// Filter by target resource group name. Default value is select all.
            /// </param>
            /// <param name='targetResourceType'>
            /// Filter by target resource type. Default value is select all.
            /// </param>
            /// <param name='targetResource'>
            /// Filter by target resource( which is full ARM ID) Default value is select
            /// all.
            /// </param>
            /// <param name='severity'>
            /// Filter by severity.  Default value is select all. Possible values include:
            /// 'Sev0', 'Sev1', 'Sev2', 'Sev3', 'Sev4'
            /// </param>
            /// <param name='monitorService'>
            /// Filter by monitor service which generates the alert instance. Default value
            /// is select all. Possible values include: 'Application Insights',
            /// 'ActivityLog Administrative', 'ActivityLog Security', 'ActivityLog
            /// Recommendation', 'ActivityLog Policy', 'ActivityLog Autoscale', 'Log
            /// Analytics', 'Nagios', 'Platform', 'SCOM', 'ServiceHealth', 'SmartDetector',
            /// 'VM Insights', 'Zabbix'
            /// </param>
            /// <param name='impactedScope'>
            /// filter by impacted/target scope (provide comma separated list for multiple
            /// scopes). The value should be an well constructed ARM id of the scope.
            /// </param>
            /// <param name='description'>
            /// filter by alert rule description
            /// </param>
            /// <param name='alertRuleId'>
            /// filter by alert rule id
            /// </param>
            /// <param name='actionGroup'>
            /// filter by action group configured as part of action rule
            /// </param>
            /// <param name='name'>
            /// filter by action rule name
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ActionRule>> ListByResourceGroupAsync(this IActionRulesOperations operations, string resourceGroupName, string targetResourceGroup = default(string), string targetResourceType = default(string), string targetResource = default(string), string severity = default(string), string monitorService = default(string), string impactedScope = default(string), string description = default(string), string alertRuleId = default(string), string actionGroup = default(string), string name = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, targetResourceGroup, targetResourceType, targetResource, severity, monitorService, impactedScope, description, alertRuleId, actionGroup, name, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get action rule by name
            /// </summary>
            /// <remarks>
            /// Get a specific action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name of action rule that needs to be fetched
            /// </param>
            public static ActionRule GetByName(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName)
            {
                return operations.GetByNameAsync(resourceGroupName, actionRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get action rule by name
            /// </summary>
            /// <remarks>
            /// Get a specific action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name of action rule that needs to be fetched
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionRule> GetByNameAsync(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetByNameWithHttpMessagesAsync(resourceGroupName, actionRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create/update an action rule
            /// </summary>
            /// <remarks>
            /// Creates/Updates a specific action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name of action rule that needs to be created/updated
            /// </param>
            /// <param name='actionRule'>
            /// action rule to be created/updated
            /// </param>
            public static ActionRule CreateUpdate(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName, ActionRule actionRule)
            {
                return operations.CreateUpdateAsync(resourceGroupName, actionRuleName, actionRule).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create/update an action rule
            /// </summary>
            /// <remarks>
            /// Creates/Updates a specific action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name of action rule that needs to be created/updated
            /// </param>
            /// <param name='actionRule'>
            /// action rule to be created/updated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionRule> CreateUpdateAsync(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName, ActionRule actionRule, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateUpdateWithHttpMessagesAsync(resourceGroupName, actionRuleName, actionRule, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete action rule
            /// </summary>
            /// <remarks>
            /// Deletes a given action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name that needs to be deleted
            /// </param>
            public static bool? Delete(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName)
            {
                return operations.DeleteAsync(resourceGroupName, actionRuleName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete action rule
            /// </summary>
            /// <remarks>
            /// Deletes a given action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name that needs to be deleted
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<bool?> DeleteAsync(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, actionRuleName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Patch action rule
            /// </summary>
            /// <remarks>
            /// Update enabled flag and/or tags for the given action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name that needs to be updated
            /// </param>
            /// <param name='actionRulePatch'>
            /// Parameters supplied to the operation.
            /// </param>
            public static ActionRule Update(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName, PatchObject actionRulePatch)
            {
                return operations.UpdateAsync(resourceGroupName, actionRuleName, actionRulePatch).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Patch action rule
            /// </summary>
            /// <remarks>
            /// Update enabled flag and/or tags for the given action rule
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Resource group name where the resource is created.
            /// </param>
            /// <param name='actionRuleName'>
            /// The name that needs to be updated
            /// </param>
            /// <param name='actionRulePatch'>
            /// Parameters supplied to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ActionRule> UpdateAsync(this IActionRulesOperations operations, string resourceGroupName, string actionRuleName, PatchObject actionRulePatch, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, actionRuleName, actionRulePatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all action rule in a given subscription
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ActionRule> ListBySubscriptionNext(this IActionRulesOperations operations, string nextPageLink)
            {
                return operations.ListBySubscriptionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all action rule in a given subscription
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ActionRule>> ListBySubscriptionNextAsync(this IActionRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBySubscriptionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get all action rules created in a resource group
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription, created in given resource group
            /// and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ActionRule> ListByResourceGroupNext(this IActionRulesOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get all action rules created in a resource group
            /// </summary>
            /// <remarks>
            /// List all action rules of the subscription, created in given resource group
            /// and given input filters
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ActionRule>> ListByResourceGroupNextAsync(this IActionRulesOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
