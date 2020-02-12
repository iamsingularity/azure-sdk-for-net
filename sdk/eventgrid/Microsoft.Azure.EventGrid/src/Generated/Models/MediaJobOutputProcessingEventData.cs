// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Job output processing event data
    /// </summary>
    public partial class MediaJobOutputProcessingEventData : MediaJobOutputStateChangeEventData
    {
        /// <summary>
        /// Initializes a new instance of the MediaJobOutputProcessingEventData
        /// class.
        /// </summary>
        public MediaJobOutputProcessingEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MediaJobOutputProcessingEventData
        /// class.
        /// </summary>
        /// <param name="previousState">The previous state of the Job. Possible
        /// values include: 'Canceled', 'Canceling', 'Error', 'Finished',
        /// 'Processing', 'Queued', 'Scheduled'</param>
        /// <param name="output">Gets the output.</param>
        /// <param name="jobCorrelationData">Gets the Job correlation
        /// data.</param>
        public MediaJobOutputProcessingEventData(MediaJobState previousState = default(MediaJobState), MediaJobOutput output = default(MediaJobOutput), IDictionary<string, string> jobCorrelationData = default(IDictionary<string, string>))
            : base(previousState, output, jobCorrelationData)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
