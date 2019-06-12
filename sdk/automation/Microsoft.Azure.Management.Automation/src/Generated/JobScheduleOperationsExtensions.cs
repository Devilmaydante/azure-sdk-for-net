// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for JobScheduleOperations.
    /// </summary>
    public static partial class JobScheduleOperationsExtensions
    {
            /// <summary>
            /// Delete the job schedule identified by job schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The job schedule name.
            /// </param>
            public static void Delete(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobScheduleId)
            {
                operations.DeleteAsync(resourceGroupName, automationAccountName, jobScheduleId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete the job schedule identified by job schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The job schedule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, automationAccountName, jobScheduleId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve the job schedule identified by job schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The job schedule name.
            /// </param>
            public static JobSchedule Get(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobScheduleId)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName, jobScheduleId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the job schedule identified by job schedule name.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The job schedule name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobSchedule> GetAsync(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, jobScheduleId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a job schedule.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The job schedule name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the create job schedule operation.
            /// </param>
            public static JobSchedule Create(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, JobScheduleCreateParameters parameters)
            {
                return operations.CreateAsync(resourceGroupName, automationAccountName, jobScheduleId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a job schedule.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='jobScheduleId'>
            /// The job schedule name.
            /// </param>
            /// <param name='parameters'>
            /// The parameters supplied to the create job schedule operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobSchedule> CreateAsync(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, System.Guid jobScheduleId, JobScheduleCreateParameters parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, automationAccountName, jobScheduleId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of job schedules.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            public static IPage<JobSchedule> ListByAutomationAccount(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, ODataQuery<JobSchedule> odataQuery = default(ODataQuery<JobSchedule>))
            {
                return operations.ListByAutomationAccountAsync(resourceGroupName, automationAccountName, odataQuery).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of job schedules.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of an Azure Resource group.
            /// </param>
            /// <param name='automationAccountName'>
            /// The name of the automation account.
            /// </param>
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<JobSchedule>> ListByAutomationAccountAsync(this IJobScheduleOperations operations, string resourceGroupName, string automationAccountName, ODataQuery<JobSchedule> odataQuery = default(ODataQuery<JobSchedule>), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountWithHttpMessagesAsync(resourceGroupName, automationAccountName, odataQuery, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve a list of job schedules.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<JobSchedule> ListByAutomationAccountNext(this IJobScheduleOperations operations, string nextPageLink)
            {
                return operations.ListByAutomationAccountNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve a list of job schedules.
            /// <see href="http://aka.ms/azureautomationsdk/jobscheduleoperations" />
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
            public static async Task<IPage<JobSchedule>> ListByAutomationAccountNextAsync(this IJobScheduleOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByAutomationAccountNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}