// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Represents a certificate action
    /// </summary>
    [JsonTransformation]
    public partial class CertificateOrderAction : Resource
    {
        /// <summary>
        /// Initializes a new instance of the CertificateOrderAction class.
        /// </summary>
        public CertificateOrderAction() { }

        /// <summary>
        /// Initializes a new instance of the CertificateOrderAction class.
        /// </summary>
        public CertificateOrderAction(string name, string location, string id = default(string), string kind = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), CertificateOrderActionType? certificateOrderActionType = default(CertificateOrderActionType?), DateTime? createdAt = default(DateTime?))
            : base(name, location, id, kind, type, tags)
        {
            CertificateOrderActionType = certificateOrderActionType;
            CreatedAt = createdAt;
        }

        /// <summary>
        /// Type. Possible values include: 'CertificateIssued',
        /// 'CertificateOrderCanceled', 'CertificateOrderCreated',
        /// 'CertificateRevoked', 'DomainValidationComplete',
        /// 'FraudDetected', 'OrgNameChange', 'OrgValidationComplete',
        /// 'SanDrop'
        /// </summary>
        [JsonProperty(PropertyName = "properties.type")]
        public CertificateOrderActionType? CertificateOrderActionType { get; set; }

        /// <summary>
        /// Time at which the certificate action was performed
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdAt")]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
