// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// AzureFileShare Restore Request
    /// </summary>
    public partial class AzureFileShareRestoreRequest : RestoreRequest
    {
        /// <summary>
        /// Initializes a new instance of the AzureFileShareRestoreRequest
        /// class.
        /// </summary>
        public AzureFileShareRestoreRequest()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureFileShareRestoreRequest
        /// class.
        /// </summary>
        /// <param name="recoveryType">Type of this recovery. Possible values
        /// include: 'Invalid', 'OriginalLocation', 'AlternateLocation',
        /// 'RestoreDisks', 'Offline'</param>
        /// <param name="sourceResourceId">Source storage account ARM
        /// Id</param>
        /// <param name="copyOptions">Options to resolve copy conflicts.
        /// Possible values include: 'Invalid', 'CreateCopy', 'Skip',
        /// 'Overwrite', 'FailOnConflict'</param>
        /// <param name="restoreRequestType">Restore Type (FullShareRestore or
        /// ItemLevelRestore). Possible values include: 'Invalid',
        /// 'FullShareRestore', 'ItemLevelRestore'</param>
        /// <param name="restoreFileSpecs">List of Source Files/Folders(which
        /// need to recover) and TargetFolderPath details</param>
        /// <param name="targetDetails">Target File Share Details</param>
        public AzureFileShareRestoreRequest(string recoveryType = default(string), string sourceResourceId = default(string), string copyOptions = default(string), string restoreRequestType = default(string), IList<RestoreFileSpecs> restoreFileSpecs = default(IList<RestoreFileSpecs>), TargetAFSRestoreInfo targetDetails = default(TargetAFSRestoreInfo))
        {
            RecoveryType = recoveryType;
            SourceResourceId = sourceResourceId;
            CopyOptions = copyOptions;
            RestoreRequestType = restoreRequestType;
            RestoreFileSpecs = restoreFileSpecs;
            TargetDetails = targetDetails;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets type of this recovery. Possible values include:
        /// 'Invalid', 'OriginalLocation', 'AlternateLocation', 'RestoreDisks',
        /// 'Offline'
        /// </summary>
        [JsonProperty(PropertyName = "recoveryType")]
        public string RecoveryType { get; set; }

        /// <summary>
        /// Gets or sets source storage account ARM Id
        /// </summary>
        [JsonProperty(PropertyName = "sourceResourceId")]
        public string SourceResourceId { get; set; }

        /// <summary>
        /// Gets or sets options to resolve copy conflicts. Possible values
        /// include: 'Invalid', 'CreateCopy', 'Skip', 'Overwrite',
        /// 'FailOnConflict'
        /// </summary>
        [JsonProperty(PropertyName = "copyOptions")]
        public string CopyOptions { get; set; }

        /// <summary>
        /// Gets or sets restore Type (FullShareRestore or ItemLevelRestore).
        /// Possible values include: 'Invalid', 'FullShareRestore',
        /// 'ItemLevelRestore'
        /// </summary>
        [JsonProperty(PropertyName = "restoreRequestType")]
        public string RestoreRequestType { get; set; }

        /// <summary>
        /// Gets or sets list of Source Files/Folders(which need to recover)
        /// and TargetFolderPath details
        /// </summary>
        [JsonProperty(PropertyName = "restoreFileSpecs")]
        public IList<RestoreFileSpecs> RestoreFileSpecs { get; set; }

        /// <summary>
        /// Gets or sets target File Share Details
        /// </summary>
        [JsonProperty(PropertyName = "targetDetails")]
        public TargetAFSRestoreInfo TargetDetails { get; set; }

    }
}