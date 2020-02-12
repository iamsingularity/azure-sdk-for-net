// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A Job resource type. The progress and state can be obtained by polling
    /// a Job or subscribing to events using EventGrid.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Job : ProxyResource
    {
        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        public Job()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Job class.
        /// </summary>
        /// <param name="input">The inputs for the Job.</param>
        /// <param name="outputs">The outputs for the Job.</param>
        /// <param name="id">Fully qualified resource ID for the
        /// resource.</param>
        /// <param name="name">The name of the resource.</param>
        /// <param name="type">The type of the resource.</param>
        /// <param name="created">The UTC date and time when the Job was
        /// created, in 'YYYY-MM-DDThh:mm:ssZ' format.</param>
        /// <param name="state">The current state of the job. Possible values
        /// include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="description">Optional customer supplied description of
        /// the Job.</param>
        /// <param name="lastModified">The UTC date and time when the Job was
        /// last updated, in 'YYYY-MM-DDThh:mm:ssZ' format.</param>
        /// <param name="priority">Priority with which the job should be
        /// processed. Higher priority jobs are processed before lower priority
        /// jobs. If not set, the default is normal. Possible values include:
        /// 'Low', 'Normal', 'High'</param>
        /// <param name="correlationData">Customer provided key, value pairs
        /// that will be returned in Job and JobOutput state events.</param>
        /// <param name="startTime">The UTC date and time at which this Job
        /// began processing.</param>
        /// <param name="endTime">The UTC date and time at which this Job
        /// finished processing.</param>
        public Job(JobInput input, IList<JobOutput> outputs, string id = default(string), string name = default(string), string type = default(string), System.DateTime created = default(System.DateTime), JobState state = default(JobState), string description = default(string), System.DateTime lastModified = default(System.DateTime), Priority? priority = default(Priority?), IDictionary<string, string> correlationData = default(IDictionary<string, string>), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?))
            : base(id, name, type)
        {
            Created = created;
            State = state;
            Description = description;
            Input = input;
            LastModified = lastModified;
            Outputs = outputs;
            Priority = priority;
            CorrelationData = correlationData;
            StartTime = startTime;
            EndTime = endTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the UTC date and time when the Job was created, in
        /// 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.created")]
        public System.DateTime Created { get; private set; }

        /// <summary>
        /// Gets the current state of the job. Possible values include:
        /// 'Canceled', 'Canceling', 'Error', 'Finished', 'Processing',
        /// 'Queued', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public JobState State { get; private set; }

        /// <summary>
        /// Gets or sets optional customer supplied description of the Job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the inputs for the Job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.input")]
        public JobInput Input { get; set; }

        /// <summary>
        /// Gets the UTC date and time when the Job was last updated, in
        /// 'YYYY-MM-DDThh:mm:ssZ' format.
        /// </summary>
        [JsonProperty(PropertyName = "properties.lastModified")]
        public System.DateTime LastModified { get; private set; }

        /// <summary>
        /// Gets or sets the outputs for the Job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputs")]
        public IList<JobOutput> Outputs { get; set; }

        /// <summary>
        /// Gets or sets priority with which the job should be processed.
        /// Higher priority jobs are processed before lower priority jobs. If
        /// not set, the default is normal. Possible values include: 'Low',
        /// 'Normal', 'High'
        /// </summary>
        [JsonProperty(PropertyName = "properties.priority")]
        public Priority? Priority { get; set; }

        /// <summary>
        /// Gets or sets customer provided key, value pairs that will be
        /// returned in Job and JobOutput state events.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlationData")]
        public IDictionary<string, string> CorrelationData { get; set; }

        /// <summary>
        /// Gets the UTC date and time at which this Job began processing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the UTC date and time at which this Job finished processing.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Input == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Input");
            }
            if (Outputs == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Outputs");
            }
        }
    }
}
