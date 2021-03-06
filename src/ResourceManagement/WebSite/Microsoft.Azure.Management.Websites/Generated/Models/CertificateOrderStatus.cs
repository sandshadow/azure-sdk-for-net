// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CertificateOrderStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CertificateOrderStatus
    {
        [EnumMember(Value = "Pendingissuance")]
        Pendingissuance,
        [EnumMember(Value = "Issued")]
        Issued,
        [EnumMember(Value = "Revoked")]
        Revoked,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "Denied")]
        Denied,
        [EnumMember(Value = "Pendingrevocation")]
        Pendingrevocation,
        [EnumMember(Value = "PendingRekey")]
        PendingRekey,
        [EnumMember(Value = "Unused")]
        Unused,
        [EnumMember(Value = "Expired")]
        Expired,
        [EnumMember(Value = "NotSubmitted")]
        NotSubmitted
    }
}
