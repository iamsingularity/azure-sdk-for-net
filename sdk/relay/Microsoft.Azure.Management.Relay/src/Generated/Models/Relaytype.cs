// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Relay.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Relaytype.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Relaytype
    {
        [EnumMember(Value = "NetTcp")]
        NetTcp,
        [EnumMember(Value = "Http")]
        Http
    }
    internal static class RelaytypeEnumExtension
    {
        internal static string ToSerializedValue(this Relaytype? value)
        {
            return value == null ? null : ((Relaytype)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Relaytype value)
        {
            switch( value )
            {
                case Relaytype.NetTcp:
                    return "NetTcp";
                case Relaytype.Http:
                    return "Http";
            }
            return null;
        }

        internal static Relaytype? ParseRelaytype(this string value)
        {
            switch( value )
            {
                case "NetTcp":
                    return Relaytype.NetTcp;
                case "Http":
                    return Relaytype.Http;
            }
            return null;
        }
    }
}
