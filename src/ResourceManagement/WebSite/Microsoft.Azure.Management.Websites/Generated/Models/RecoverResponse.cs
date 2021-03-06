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
    /// Response for a recover site request
    /// </summary>
    [JsonTransformation]
    public partial class RecoverResponse : Resource
    {
        /// <summary>
        /// Initializes a new instance of the RecoverResponse class.
        /// </summary>
        public RecoverResponse() { }

        /// <summary>
        /// Initializes a new instance of the RecoverResponse class.
        /// </summary>
        public RecoverResponse(String name, String location, String id = default(String), String kind = default(String), String type = default(String), IDictionary<string, String> tags = default(IDictionary<string, String>), string operationId = default(string))
            : base(name, location, id, kind, type, tags)
        {
            OperationId = operationId;
        }

        /// <summary>
        /// ID of the recovery operation. Can be used to check the status of
        /// the corresponding operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; set; }

        /// <summary>
        /// Validate the object. Throws ValidationException if validation fails.
        /// </summary>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
