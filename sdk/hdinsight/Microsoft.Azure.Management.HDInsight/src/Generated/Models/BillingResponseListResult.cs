// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HDInsight.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The response for the operation to get regional billingSpecs for a
    /// subscription.
    /// </summary>
    public partial class BillingResponseListResult
    {
        /// <summary>
        /// Initializes a new instance of the BillingResponseListResult class.
        /// </summary>
        public BillingResponseListResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BillingResponseListResult class.
        /// </summary>
        /// <param name="vmSizes">The virtual machine sizes to include or
        /// exclude.</param>
        /// <param name="vmSizeFilters">The virtual machine filtering mode.
        /// Effectively this can enabling or disabling the virtual machine
        /// sizes in a particular set.</param>
        /// <param name="billingResources">The billing and managed disk billing
        /// resources for a region.</param>
        public BillingResponseListResult(IList<string> vmSizes = default(IList<string>), IList<VmSizeCompatibilityFilterV2> vmSizeFilters = default(IList<VmSizeCompatibilityFilterV2>), IList<BillingResources> billingResources = default(IList<BillingResources>))
        {
            VmSizes = vmSizes;
            VmSizeFilters = vmSizeFilters;
            BillingResources = billingResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the virtual machine sizes to include or exclude.
        /// </summary>
        [JsonProperty(PropertyName = "vmSizes")]
        public IList<string> VmSizes { get; set; }

        /// <summary>
        /// Gets or sets the virtual machine filtering mode. Effectively this
        /// can enabling or disabling the virtual machine sizes in a particular
        /// set.
        /// </summary>
        [JsonProperty(PropertyName = "vmSizeFilters")]
        public IList<VmSizeCompatibilityFilterV2> VmSizeFilters { get; set; }

        /// <summary>
        /// Gets or sets the billing and managed disk billing resources for a
        /// region.
        /// </summary>
        [JsonProperty(PropertyName = "billingResources")]
        public IList<BillingResources> BillingResources { get; set; }

    }
}
