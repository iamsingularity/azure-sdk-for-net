// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using FileStaging;
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch task. A task is a piece of work that is associated with a job and runs on a compute node.
    /// </summary>
    /// <remarks>
    /// Batch will retry tasks when a recovery operation is triggered on a compute node. Examples of recovery operations 
    /// include (but are not limited to) when an unhealthy compute node is rebooted or a compute node disappeared due to 
    /// host failure. Retries due to recovery operations are independent of and are not counted against the <see cref="TaskConstraints.MaxTaskRetryCount" 
    /// />. Even if the <see cref="TaskConstraints.MaxTaskRetryCount" /> is 0, an internal retry due to a recovery operation 
    /// may occur. Because of this, all tasks should be idempotent. This means tasks need to tolerate being interrupted and 
    /// restarted without causing any corruption or duplicate data. The best practice for long running tasks is to use some 
    /// form of checkpointing. The maximum lifetime of a task from addition to completion is 180 days. If a task has not 
    /// completed within 180 days of being added it will be terminated by the Batch service and left in whatever state it 
    /// was in at that time.
    /// </remarks>
    public partial class CloudTask : ITransportObjectProvider<Models.TaskAddParameter>, IInheritedBehaviors, IPropertyMetadata
    {
        private class PropertyContainer : PropertyCollection
        {
            public readonly PropertyAccessor<AffinityInformation> AffinityInformationProperty;
            public readonly PropertyAccessor<IList<ApplicationPackageReference>> ApplicationPackageReferencesProperty;
            public readonly PropertyAccessor<AuthenticationTokenSettings> AuthenticationTokenSettingsProperty;
            public readonly PropertyAccessor<string> CommandLineProperty;
            public readonly PropertyAccessor<ComputeNodeInformation> ComputeNodeInformationProperty;
            public readonly PropertyAccessor<TaskConstraints> ConstraintsProperty;
            public readonly PropertyAccessor<TaskContainerSettings> ContainerSettingsProperty;
            public readonly PropertyAccessor<DateTime?> CreationTimeProperty;
            public readonly PropertyAccessor<TaskDependencies> DependsOnProperty;
            public readonly PropertyAccessor<string> DisplayNameProperty;
            public readonly PropertyAccessor<IList<EnvironmentSetting>> EnvironmentSettingsProperty;
            public readonly PropertyAccessor<string> ETagProperty;
            public readonly PropertyAccessor<TaskExecutionInformation> ExecutionInformationProperty;
            public readonly PropertyAccessor<ExitConditions> ExitConditionsProperty;
            public readonly PropertyAccessor<IList<IFileStagingProvider>> FilesToStageProperty;
            public readonly PropertyAccessor<string> IdProperty;
            public readonly PropertyAccessor<DateTime?> LastModifiedProperty;
            public readonly PropertyAccessor<MultiInstanceSettings> MultiInstanceSettingsProperty;
            public readonly PropertyAccessor<IList<OutputFile>> OutputFilesProperty;
            public readonly PropertyAccessor<Common.TaskState?> PreviousStateProperty;
            public readonly PropertyAccessor<DateTime?> PreviousStateTransitionTimeProperty;
            public readonly PropertyAccessor<IList<ResourceFile>> ResourceFilesProperty;
            public readonly PropertyAccessor<Common.TaskState?> StateProperty;
            public readonly PropertyAccessor<DateTime?> StateTransitionTimeProperty;
            public readonly PropertyAccessor<TaskStatistics> StatisticsProperty;
            public readonly PropertyAccessor<string> UrlProperty;
            public readonly PropertyAccessor<UserIdentity> UserIdentityProperty;

            public PropertyContainer() : base(BindingState.Unbound)
            {
                this.AffinityInformationProperty = this.CreatePropertyAccessor<AffinityInformation>(nameof(AffinityInformation), BindingAccess.Read | BindingAccess.Write);
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor<IList<ApplicationPackageReference>>(nameof(ApplicationPackageReferences), BindingAccess.Read | BindingAccess.Write);
                this.AuthenticationTokenSettingsProperty = this.CreatePropertyAccessor<AuthenticationTokenSettings>(nameof(AuthenticationTokenSettings), BindingAccess.Read | BindingAccess.Write);
                this.CommandLineProperty = this.CreatePropertyAccessor<string>(nameof(CommandLine), BindingAccess.Read | BindingAccess.Write);
                this.ComputeNodeInformationProperty = this.CreatePropertyAccessor<ComputeNodeInformation>(nameof(ComputeNodeInformation), BindingAccess.None);
                this.ConstraintsProperty = this.CreatePropertyAccessor<TaskConstraints>(nameof(Constraints), BindingAccess.Read | BindingAccess.Write);
                this.ContainerSettingsProperty = this.CreatePropertyAccessor<TaskContainerSettings>(nameof(ContainerSettings), BindingAccess.Read | BindingAccess.Write);
                this.CreationTimeProperty = this.CreatePropertyAccessor<DateTime?>(nameof(CreationTime), BindingAccess.None);
                this.DependsOnProperty = this.CreatePropertyAccessor<TaskDependencies>(nameof(DependsOn), BindingAccess.Read | BindingAccess.Write);
                this.DisplayNameProperty = this.CreatePropertyAccessor<string>(nameof(DisplayName), BindingAccess.Read | BindingAccess.Write);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor<IList<EnvironmentSetting>>(nameof(EnvironmentSettings), BindingAccess.Read | BindingAccess.Write);
                this.ETagProperty = this.CreatePropertyAccessor<string>(nameof(ETag), BindingAccess.None);
                this.ExecutionInformationProperty = this.CreatePropertyAccessor<TaskExecutionInformation>(nameof(ExecutionInformation), BindingAccess.None);
                this.ExitConditionsProperty = this.CreatePropertyAccessor<ExitConditions>(nameof(ExitConditions), BindingAccess.Read | BindingAccess.Write);
                this.FilesToStageProperty = this.CreatePropertyAccessor<IList<IFileStagingProvider>>(nameof(FilesToStage), BindingAccess.Read | BindingAccess.Write);
                this.IdProperty = this.CreatePropertyAccessor<string>(nameof(Id), BindingAccess.Read | BindingAccess.Write);
                this.LastModifiedProperty = this.CreatePropertyAccessor<DateTime?>(nameof(LastModified), BindingAccess.None);
                this.MultiInstanceSettingsProperty = this.CreatePropertyAccessor<MultiInstanceSettings>(nameof(MultiInstanceSettings), BindingAccess.Read | BindingAccess.Write);
                this.OutputFilesProperty = this.CreatePropertyAccessor<IList<OutputFile>>(nameof(OutputFiles), BindingAccess.Read | BindingAccess.Write);
                this.PreviousStateProperty = this.CreatePropertyAccessor<Common.TaskState?>(nameof(PreviousState), BindingAccess.None);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>(nameof(PreviousStateTransitionTime), BindingAccess.None);
                this.ResourceFilesProperty = this.CreatePropertyAccessor<IList<ResourceFile>>(nameof(ResourceFiles), BindingAccess.Read | BindingAccess.Write);
                this.StateProperty = this.CreatePropertyAccessor<Common.TaskState?>(nameof(State), BindingAccess.None);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor<DateTime?>(nameof(StateTransitionTime), BindingAccess.None);
                this.StatisticsProperty = this.CreatePropertyAccessor<TaskStatistics>(nameof(Statistics), BindingAccess.None);
                this.UrlProperty = this.CreatePropertyAccessor<string>(nameof(Url), BindingAccess.None);
                this.UserIdentityProperty = this.CreatePropertyAccessor<UserIdentity>(nameof(UserIdentity), BindingAccess.Read | BindingAccess.Write);
            }

            public PropertyContainer(Models.CloudTask protocolObject) : base(BindingState.Bound)
            {
                this.AffinityInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AffinityInfo, o => new AffinityInformation(o).Freeze()),
                    nameof(AffinityInformation),
                    BindingAccess.Read);
                this.ApplicationPackageReferencesProperty = this.CreatePropertyAccessor(
                    ApplicationPackageReference.ConvertFromProtocolCollectionAndFreeze(protocolObject.ApplicationPackageReferences),
                    nameof(ApplicationPackageReferences),
                    BindingAccess.Read);
                this.AuthenticationTokenSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.AuthenticationTokenSettings, o => new AuthenticationTokenSettings(o).Freeze()),
                    nameof(AuthenticationTokenSettings),
                    BindingAccess.Read);
                this.CommandLineProperty = this.CreatePropertyAccessor(
                    protocolObject.CommandLine,
                    nameof(CommandLine),
                    BindingAccess.Read);
                this.ComputeNodeInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.NodeInfo, o => new ComputeNodeInformation(o).Freeze()),
                    nameof(ComputeNodeInformation),
                    BindingAccess.Read);
                this.ConstraintsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Constraints, o => new TaskConstraints(o)),
                    nameof(Constraints),
                    BindingAccess.Read | BindingAccess.Write);
                this.ContainerSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ContainerSettings, o => new TaskContainerSettings(o).Freeze()),
                    nameof(ContainerSettings),
                    BindingAccess.Read);
                this.CreationTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.CreationTime,
                    nameof(CreationTime),
                    BindingAccess.Read);
                this.DependsOnProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.DependsOn, o => new TaskDependencies(o).Freeze()),
                    nameof(DependsOn),
                    BindingAccess.Read);
                this.DisplayNameProperty = this.CreatePropertyAccessor(
                    protocolObject.DisplayName,
                    nameof(DisplayName),
                    BindingAccess.Read);
                this.EnvironmentSettingsProperty = this.CreatePropertyAccessor(
                    EnvironmentSetting.ConvertFromProtocolCollectionAndFreeze(protocolObject.EnvironmentSettings),
                    nameof(EnvironmentSettings),
                    BindingAccess.Read);
                this.ETagProperty = this.CreatePropertyAccessor(
                    protocolObject.ETag,
                    nameof(ETag),
                    BindingAccess.Read);
                this.ExecutionInformationProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExecutionInfo, o => new TaskExecutionInformation(o).Freeze()),
                    nameof(ExecutionInformation),
                    BindingAccess.Read);
                this.ExitConditionsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.ExitConditions, o => new ExitConditions(o).Freeze()),
                    nameof(ExitConditions),
                    BindingAccess.Read);
                this.FilesToStageProperty = this.CreatePropertyAccessor<IList<IFileStagingProvider>>(
                    nameof(FilesToStage),
                    BindingAccess.None);
                this.IdProperty = this.CreatePropertyAccessor(
                    protocolObject.Id,
                    nameof(Id),
                    BindingAccess.Read);
                this.LastModifiedProperty = this.CreatePropertyAccessor(
                    protocolObject.LastModified,
                    nameof(LastModified),
                    BindingAccess.Read);
                this.MultiInstanceSettingsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.MultiInstanceSettings, o => new MultiInstanceSettings(o).Freeze()),
                    nameof(MultiInstanceSettings),
                    BindingAccess.Read);
                this.OutputFilesProperty = this.CreatePropertyAccessor(
                    OutputFile.ConvertFromProtocolCollectionAndFreeze(protocolObject.OutputFiles),
                    nameof(OutputFiles),
                    BindingAccess.Read);
                this.PreviousStateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.TaskState, Common.TaskState>(protocolObject.PreviousState),
                    nameof(PreviousState),
                    BindingAccess.Read);
                this.PreviousStateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.PreviousStateTransitionTime,
                    nameof(PreviousStateTransitionTime),
                    BindingAccess.Read);
                this.ResourceFilesProperty = this.CreatePropertyAccessor(
                    ResourceFile.ConvertFromProtocolCollectionAndFreeze(protocolObject.ResourceFiles),
                    nameof(ResourceFiles),
                    BindingAccess.Read);
                this.StateProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.MapNullableEnum<Models.TaskState, Common.TaskState>(protocolObject.State),
                    nameof(State),
                    BindingAccess.Read);
                this.StateTransitionTimeProperty = this.CreatePropertyAccessor(
                    protocolObject.StateTransitionTime,
                    nameof(StateTransitionTime),
                    BindingAccess.Read);
                this.StatisticsProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Stats, o => new TaskStatistics(o).Freeze()),
                    nameof(Statistics),
                    BindingAccess.Read);
                this.UrlProperty = this.CreatePropertyAccessor(
                    protocolObject.Url,
                    nameof(Url),
                    BindingAccess.Read);
                this.UserIdentityProperty = this.CreatePropertyAccessor(
                    UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.UserIdentity, o => new UserIdentity(o).Freeze()),
                    nameof(UserIdentity),
                    BindingAccess.Read);
            }
        }

        private PropertyContainer propertyContainer;

        private readonly BatchClient parentBatchClient;
        private readonly string parentJobId;

        internal string ParentJobId
        {
            get
            {
                return this.parentJobId;
            }
        }

        #region Constructors

        internal CloudTask(
            BatchClient parentBatchClient,
            string parentJobId,
            Models.CloudTask protocolObject,
            IEnumerable<BatchClientBehavior> baseBehaviors)
        {
            this.parentJobId = parentJobId;
            this.parentBatchClient = parentBatchClient;
            InheritUtil.InheritClientBehaviorsAndSetPublicProperty(this, baseBehaviors);
            this.propertyContainer = new PropertyContainer(protocolObject);
        }

        #endregion Constructors

        #region IInheritedBehaviors

        /// <summary>
        /// Gets or sets a list of behaviors that modify or customize requests to the Batch service
        /// made via this <see cref="CloudTask"/>.
        /// </summary>
        /// <remarks>
        /// <para>These behaviors are inherited by child objects.</para>
        /// <para>Modifications are applied in the order of the collection. The last write wins.</para>
        /// </remarks>
        public IList<BatchClientBehavior> CustomBehaviors { get; set; }

        #endregion IInheritedBehaviors

        #region CloudTask

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service to select a node on which to start the task.
        /// </summary>
        public AffinityInformation AffinityInformation
        {
            get { return this.propertyContainer.AffinityInformationProperty.Value; }
            set { this.propertyContainer.AffinityInformationProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service will deploy to the compute node before running 
        /// the command line.
        /// </summary>
        public IList<ApplicationPackageReference> ApplicationPackageReferences
        {
            get { return this.propertyContainer.ApplicationPackageReferencesProperty.Value; }
            set
            {
                this.propertyContainer.ApplicationPackageReferencesProperty.Value = ConcurrentChangeTrackedModifiableList<ApplicationPackageReference>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets or sets the settings for an authentication token that the task can use to perform Batch service operations.
        /// </summary>
        /// <remarks>
        /// If this property is set, the Batch service provides the task with an authentication token which can be used to 
        /// authenticate Batch service operations without requiring an account access key. The token is provided via the 
        /// AZ_BATCH_AUTHENTICATION_TOKEN environment variable. The operations that the task can carry out using the token 
        /// depend on the settings. For example, a task can request job permissions in order to add other tasks to the job, 
        /// or check the status of the job or of other tasks.
        /// </remarks>
        public AuthenticationTokenSettings AuthenticationTokenSettings
        {
            get { return this.propertyContainer.AuthenticationTokenSettingsProperty.Value; }
            set { this.propertyContainer.AuthenticationTokenSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// The command line does not run under a shell, and therefore cannot take advantage of shell features such as environment 
        /// variable expansion. If you want to take advantage of such features, you should invoke the shell in the command 
        /// line, for example using \"cmd /c MyCommand\" in Windows or \"/bin/sh -c MyCommand\" in Linux. If the command 
        /// line refers to file paths, it should use a relative path (relative to the task working directory), or use the 
        /// Batch provided environment variables (https://docs.microsoft.com/en-us/azure/batch/batch-compute-node-environment-variables).
        /// </remarks>
        public string CommandLine
        {
            get { return this.propertyContainer.CommandLineProperty.Value; }
            set { this.propertyContainer.CommandLineProperty.Value = value; }
        }

        /// <summary>
        /// Gets information about the compute node on which the task ran.
        /// </summary>
        public ComputeNodeInformation ComputeNodeInformation
        {
            get { return this.propertyContainer.ComputeNodeInformationProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        public TaskConstraints Constraints
        {
            get { return this.propertyContainer.ConstraintsProperty.Value; }
            set { this.propertyContainer.ConstraintsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the settings for the container under which the task runs.
        /// </summary>
        /// <remarks>
        /// If the pool that will run this task has <see cref="VirtualMachineConfiguration.ContainerConfiguration"/> set, 
        /// this must be set as well. If the pool that will run this task doesn't have <see cref="VirtualMachineConfiguration.ContainerConfiguration"/> 
        /// set, this must not be set. When this is specified, all directories recursively below the AZ_BATCH_NODE_ROOT_DIR 
        /// (the root of Azure Batch directories on the node) are mapped into the container, all task environment variables 
        /// are mapped into the container, and the task command line is executed in the container. Files produced in the 
        /// container outside of AZ_BATCH_NODE_ROOT_DIR might not be reflected to the host disk, meaning that Batch file 
        /// APIs will not be able to access them.
        /// </remarks>
        public TaskContainerSettings ContainerSettings
        {
            get { return this.propertyContainer.ContainerSettingsProperty.Value; }
            set { this.propertyContainer.ContainerSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets the creation time of the task.
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this.propertyContainer.CreationTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets any other tasks that this <see cref="CloudTask"/> depends on. The task will not be scheduled until 
        /// all depended-on tasks have completed successfully.
        /// </summary>
        /// <remarks>
        /// The job must set <see cref="CloudJob.UsesTaskDependencies"/> to true in order to use task dependencies. If UsesTaskDependencies 
        /// is false (the default), adding a task with dependencies will fail with an error.
        /// </remarks>
        public TaskDependencies DependsOn
        {
            get { return this.propertyContainer.DependsOnProperty.Value; }
            set { this.propertyContainer.DependsOnProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets the display name of the task.
        /// </summary>
        public string DisplayName
        {
            get { return this.propertyContainer.DisplayNameProperty.Value; }
            set { this.propertyContainer.DisplayNameProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        public IList<EnvironmentSetting> EnvironmentSettings
        {
            get { return this.propertyContainer.EnvironmentSettingsProperty.Value; }
            set
            {
                this.propertyContainer.EnvironmentSettingsProperty.Value = ConcurrentChangeTrackedModifiableList<EnvironmentSetting>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets the ETag for the task.
        /// </summary>
        public string ETag
        {
            get { return this.propertyContainer.ETagProperty.Value; }
        }

        /// <summary>
        /// Gets the execution information for the task.
        /// </summary>
        public TaskExecutionInformation ExecutionInformation
        {
            get { return this.propertyContainer.ExecutionInformationProperty.Value; }
        }

        /// <summary>
        /// Gets or sets how the Batch service should respond when the task completes.
        /// </summary>
        public ExitConditions ExitConditions
        {
            get { return this.propertyContainer.ExitConditionsProperty.Value; }
            set { this.propertyContainer.ExitConditionsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files to be staged for the task.
        /// </summary>
        public IList<IFileStagingProvider> FilesToStage
        {
            get { return this.propertyContainer.FilesToStageProperty.Value; }
            set
            {
                this.propertyContainer.FilesToStageProperty.Value = ConcurrentChangeTrackedList<IFileStagingProvider>.TransformEnumerableToConcurrentList(value);
            }
        }

        /// <summary>
        /// Gets or sets the id of the task.
        /// </summary>
        public string Id
        {
            get { return this.propertyContainer.IdProperty.Value; }
            set { this.propertyContainer.IdProperty.Value = value; }
        }

        /// <summary>
        /// Gets the last modified time of the task.
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.propertyContainer.LastModifiedProperty.Value; }
        }

        /// <summary>
        /// Gets or sets information about how to run the multi-instance task.
        /// </summary>
        public MultiInstanceSettings MultiInstanceSettings
        {
            get { return this.propertyContainer.MultiInstanceSettingsProperty.Value; }
            set { this.propertyContainer.MultiInstanceSettingsProperty.Value = value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will upload from the compute node after running the command 
        /// line.
        /// </summary>
        public IList<OutputFile> OutputFiles
        {
            get { return this.propertyContainer.OutputFilesProperty.Value; }
            set
            {
                this.propertyContainer.OutputFilesProperty.Value = ConcurrentChangeTrackedModifiableList<OutputFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets the previous state of the task.
        /// </summary>
        /// <remarks>
        /// If the task is in its initial <see cref="Common.TaskState.Active"/> state, the PreviousState property is not 
        /// defined.
        /// </remarks>
        public Common.TaskState? PreviousState
        {
            get { return this.propertyContainer.PreviousStateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the task entered its previous state.
        /// </summary>
        /// <remarks>
        /// If the task is in its initial <see cref="Common.TaskState.Active"/> state, the PreviousStateTransitionTime property 
        /// is not defined.
        /// </remarks>
        public DateTime? PreviousStateTransitionTime
        {
            get { return this.propertyContainer.PreviousStateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download to the compute node before running the command 
        /// line.
        /// </summary>
        /// <remarks>
        /// There is a maximum size for the list of resource files. When the max size is exceeded, the request will fail 
        /// and the response error code will be RequestEntityTooLarge. If this occurs, the collection of resource files must 
        /// be reduced in size. This can be achieved using .zip files, Application Packages, or Docker Containers.
        /// </remarks>
        public IList<ResourceFile> ResourceFiles
        {
            get { return this.propertyContainer.ResourceFilesProperty.Value; }
            set
            {
                this.propertyContainer.ResourceFilesProperty.Value = ConcurrentChangeTrackedModifiableList<ResourceFile>.TransformEnumerableToConcurrentModifiableList(value);
            }
        }

        /// <summary>
        /// Gets the current state of the task.
        /// </summary>
        public Common.TaskState? State
        {
            get { return this.propertyContainer.StateProperty.Value; }
        }

        /// <summary>
        /// Gets the time at which the task entered its current state.
        /// </summary>
        public DateTime? StateTransitionTime
        {
            get { return this.propertyContainer.StateTransitionTimeProperty.Value; }
        }

        /// <summary>
        /// Gets resource usage statistics for the task.
        /// </summary>
        /// <remarks>
        /// This property is populated only if the <see cref="CloudTask"/> was retrieved with an <see cref="ODATADetailLevel.ExpandClause"/> 
        /// including the 'stats' attribute; otherwise it is null.
        /// </remarks>
        public TaskStatistics Statistics
        {
            get { return this.propertyContainer.StatisticsProperty.Value; }
        }

        /// <summary>
        /// Gets the URL of the task.
        /// </summary>
        public string Url
        {
            get { return this.propertyContainer.UrlProperty.Value; }
        }

        /// <summary>
        /// Gets or sets the user identity under which the task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to the task.
        /// </remarks>
        public UserIdentity UserIdentity
        {
            get { return this.propertyContainer.UserIdentityProperty.Value; }
            set { this.propertyContainer.UserIdentityProperty.Value = value; }
        }

        #endregion // CloudTask

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            get { return this.propertyContainer.HasBeenModified; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return this.propertyContainer.IsReadOnly; }
            set { this.propertyContainer.IsReadOnly = value; }
        }

        #endregion //IPropertyMetadata

        #region Internal/private methods
        /// <summary>
        /// Return a protocol object of the requested type.
        /// </summary>
        /// <returns>The protocol object of the requested type.</returns>
        Models.TaskAddParameter ITransportObjectProvider<Models.TaskAddParameter>.GetTransportObject()
        {
            Models.TaskAddParameter result = new Models.TaskAddParameter()
            {
                AffinityInfo = UtilitiesInternal.CreateObjectWithNullCheck(this.AffinityInformation, (o) => o.GetTransportObject()),
                ApplicationPackageReferences = UtilitiesInternal.ConvertToProtocolCollection(this.ApplicationPackageReferences),
                AuthenticationTokenSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.AuthenticationTokenSettings, (o) => o.GetTransportObject()),
                CommandLine = this.CommandLine,
                Constraints = UtilitiesInternal.CreateObjectWithNullCheck(this.Constraints, (o) => o.GetTransportObject()),
                ContainerSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.ContainerSettings, (o) => o.GetTransportObject()),
                DependsOn = UtilitiesInternal.CreateObjectWithNullCheck(this.DependsOn, (o) => o.GetTransportObject()),
                DisplayName = this.DisplayName,
                EnvironmentSettings = UtilitiesInternal.ConvertToProtocolCollection(this.EnvironmentSettings),
                ExitConditions = UtilitiesInternal.CreateObjectWithNullCheck(this.ExitConditions, (o) => o.GetTransportObject()),
                Id = this.Id,
                MultiInstanceSettings = UtilitiesInternal.CreateObjectWithNullCheck(this.MultiInstanceSettings, (o) => o.GetTransportObject()),
                OutputFiles = UtilitiesInternal.ConvertToProtocolCollection(this.OutputFiles),
                ResourceFiles = UtilitiesInternal.ConvertToProtocolCollection(this.ResourceFiles),
                UserIdentity = UtilitiesInternal.CreateObjectWithNullCheck(this.UserIdentity, (o) => o.GetTransportObject()),
            };

            return result;
        }


        #endregion // Internal/private methods
    }
}