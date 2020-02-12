// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ServerManagement.Models
{

    /// <summary>
    /// Defines values for PromptFieldType.
    /// </summary>
    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum PromptFieldType
    {
        [System.Runtime.Serialization.EnumMember(Value = "String")]
        String,
        [System.Runtime.Serialization.EnumMember(Value = "SecureString")]
        SecureString,
        [System.Runtime.Serialization.EnumMember(Value = "Credential")]
        Credential
    }
}
