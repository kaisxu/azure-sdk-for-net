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
    using Microsoft.Rest.Azure.OData;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for BuildTasksOperations.
    /// </summary>
    public static partial class BuildTasksOperationsExtensions
    {
            /// <summary>
            /// Lists all the build tasks for a specified container registry.
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on get list of build tasks, which provides the next
            /// page in the list of tasks.
            /// </param>
            public static IPage<BuildTask> List(this IBuildTasksOperations operations, string resourceGroupName, string registryName, ODataQuery<BuildTaskFilter> odataQuery = default(ODataQuery<BuildTaskFilter>), string skipToken = default(string))
            {
                return operations.ListAsync(resourceGroupName, registryName, odataQuery, skipToken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the build tasks for a specified container registry.
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
            /// <param name='odataQuery'>
            /// OData parameters to apply to the operation.
            /// </param>
            /// <param name='skipToken'>
            /// $skipToken is supported on get list of build tasks, which provides the next
            /// page in the list of tasks.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<BuildTask>> ListAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, ODataQuery<BuildTaskFilter> odataQuery = default(ODataQuery<BuildTaskFilter>), string skipToken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, registryName, odataQuery, skipToken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the properties of a specified build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            public static BuildTask Get(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName)
            {
                return operations.GetAsync(resourceGroupName, registryName, buildTaskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the properties of a specified build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildTask> GetAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a build task for a container registry with the specified
            /// parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskCreateParameters'>
            /// The parameters for creating a build task.
            /// </param>
            public static BuildTask Create(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTask buildTaskCreateParameters)
            {
                return operations.CreateAsync(resourceGroupName, registryName, buildTaskName, buildTaskCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a build task for a container registry with the specified
            /// parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskCreateParameters'>
            /// The parameters for creating a build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildTask> CreateAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTask buildTaskCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, buildTaskCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a specified build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            public static void Delete(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName)
            {
                operations.DeleteAsync(resourceGroupName, registryName, buildTaskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a specified build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a build task with the specified parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskUpdateParameters'>
            /// The parameters for updating a build task.
            /// </param>
            public static BuildTask Update(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTaskUpdateParameters buildTaskUpdateParameters)
            {
                return operations.UpdateAsync(resourceGroupName, registryName, buildTaskName, buildTaskUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a build task with the specified parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskUpdateParameters'>
            /// The parameters for updating a build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildTask> UpdateAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTaskUpdateParameters buildTaskUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, buildTaskUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the source control properties for a build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            public static SourceRepositoryProperties ListSourceRepositoryProperties(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName)
            {
                return operations.ListSourceRepositoryPropertiesAsync(resourceGroupName, registryName, buildTaskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the source control properties for a build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SourceRepositoryProperties> ListSourceRepositoryPropertiesAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListSourceRepositoryPropertiesWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a build task for a container registry with the specified
            /// parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskCreateParameters'>
            /// The parameters for creating a build task.
            /// </param>
            public static BuildTask BeginCreate(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTask buildTaskCreateParameters)
            {
                return operations.BeginCreateAsync(resourceGroupName, registryName, buildTaskName, buildTaskCreateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a build task for a container registry with the specified
            /// parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskCreateParameters'>
            /// The parameters for creating a build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildTask> BeginCreateAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTask buildTaskCreateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, buildTaskCreateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a specified build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            public static void BeginDelete(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName)
            {
                operations.BeginDeleteAsync(resourceGroupName, registryName, buildTaskName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a specified build task.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Updates a build task with the specified parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskUpdateParameters'>
            /// The parameters for updating a build task.
            /// </param>
            public static BuildTask BeginUpdate(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTaskUpdateParameters buildTaskUpdateParameters)
            {
                return operations.BeginUpdateAsync(resourceGroupName, registryName, buildTaskName, buildTaskUpdateParameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates a build task with the specified parameters.
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
            /// <param name='buildTaskName'>
            /// The name of the container registry build task.
            /// </param>
            /// <param name='buildTaskUpdateParameters'>
            /// The parameters for updating a build task.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<BuildTask> BeginUpdateAsync(this IBuildTasksOperations operations, string resourceGroupName, string registryName, string buildTaskName, BuildTaskUpdateParameters buildTaskUpdateParameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, registryName, buildTaskName, buildTaskUpdateParameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all the build tasks for a specified container registry.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<BuildTask> ListNext(this IBuildTasksOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all the build tasks for a specified container registry.
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
            public static async Task<IPage<BuildTask>> ListNextAsync(this IBuildTasksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}