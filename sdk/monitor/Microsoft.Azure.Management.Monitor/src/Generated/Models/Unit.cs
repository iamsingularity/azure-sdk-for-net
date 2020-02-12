// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Monitor.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for Unit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Unit
    {
        [EnumMember(Value = "Count")]
        Count,
        [EnumMember(Value = "Bytes")]
        Bytes,
        [EnumMember(Value = "Seconds")]
        Seconds,
        [EnumMember(Value = "CountPerSecond")]
        CountPerSecond,
        [EnumMember(Value = "BytesPerSecond")]
        BytesPerSecond,
        [EnumMember(Value = "Percent")]
        Percent,
        [EnumMember(Value = "MilliSeconds")]
        MilliSeconds,
        [EnumMember(Value = "ByteSeconds")]
        ByteSeconds,
        [EnumMember(Value = "Unspecified")]
        Unspecified,
        [EnumMember(Value = "Cores")]
        Cores,
        [EnumMember(Value = "MilliCores")]
        MilliCores,
        [EnumMember(Value = "NanoCores")]
        NanoCores,
        [EnumMember(Value = "BitsPerSecond")]
        BitsPerSecond
    }
    internal static class UnitEnumExtension
    {
        internal static string ToSerializedValue(this Unit? value)
        {
            return value == null ? null : ((Unit)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this Unit value)
        {
            switch( value )
            {
                case Unit.Count:
                    return "Count";
                case Unit.Bytes:
                    return "Bytes";
                case Unit.Seconds:
                    return "Seconds";
                case Unit.CountPerSecond:
                    return "CountPerSecond";
                case Unit.BytesPerSecond:
                    return "BytesPerSecond";
                case Unit.Percent:
                    return "Percent";
                case Unit.MilliSeconds:
                    return "MilliSeconds";
                case Unit.ByteSeconds:
                    return "ByteSeconds";
                case Unit.Unspecified:
                    return "Unspecified";
                case Unit.Cores:
                    return "Cores";
                case Unit.MilliCores:
                    return "MilliCores";
                case Unit.NanoCores:
                    return "NanoCores";
                case Unit.BitsPerSecond:
                    return "BitsPerSecond";
            }
            return null;
        }

        internal static Unit? ParseUnit(this string value)
        {
            switch( value )
            {
                case "Count":
                    return Unit.Count;
                case "Bytes":
                    return Unit.Bytes;
                case "Seconds":
                    return Unit.Seconds;
                case "CountPerSecond":
                    return Unit.CountPerSecond;
                case "BytesPerSecond":
                    return Unit.BytesPerSecond;
                case "Percent":
                    return Unit.Percent;
                case "MilliSeconds":
                    return Unit.MilliSeconds;
                case "ByteSeconds":
                    return Unit.ByteSeconds;
                case "Unspecified":
                    return Unit.Unspecified;
                case "Cores":
                    return Unit.Cores;
                case "MilliCores":
                    return Unit.MilliCores;
                case "NanoCores":
                    return Unit.NanoCores;
                case "BitsPerSecond":
                    return Unit.BitsPerSecond;
            }
            return null;
        }
    }
}
