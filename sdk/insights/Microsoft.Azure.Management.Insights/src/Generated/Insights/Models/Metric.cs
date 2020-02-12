// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Insights.Models
{
    using System.Linq;

    /// <summary>
    /// A set of metric values in a time range.
    /// </summary>
    public partial class Metric
    {
        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        public Metric() { }

        /// <summary>
        /// Initializes a new instance of the Metric class.
        /// </summary>
        /// <param name="name">the name and the display name of the metric,
        /// i.e. it is localizable string.</param>
        /// <param name="unit">the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'</param>
        /// <param name="data">Array of data points representing the metric
        /// values.</param>
        public Metric(LocalizableString name, Unit unit, System.Collections.Generic.IList<MetricValue> data)
        {
            Name = name;
            Unit = unit;
            Data = data;
        }

        /// <summary>
        /// Gets or sets the name and the display name of the metric, i.e. it
        /// is localizable string.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public LocalizableString Name { get; set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'CountPerSecond', 'BytesPerSecond',
        /// 'Percent', 'MilliSeconds'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "unit")]
        public Unit Unit { get; set; }

        /// <summary>
        /// Gets or sets array of data points representing the metric values.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "data")]
        public System.Collections.Generic.IList<MetricValue> Data { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (Data == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Data");
            }
            if (this.Name != null)
            {
                this.Name.Validate();
            }
            if (this.Data != null)
            {
                foreach (var element in this.Data)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
