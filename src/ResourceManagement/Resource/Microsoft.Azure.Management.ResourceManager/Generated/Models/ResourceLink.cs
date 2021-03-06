// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// The resource link.
    /// </summary>
    public partial class ResourceLink
    {
        /// <summary>
        /// Initializes a new instance of the ResourceLink class.
        /// </summary>
        public ResourceLink() { }

        /// <summary>
        /// Initializes a new instance of the ResourceLink class.
        /// </summary>
        /// <param name="id">The fully qualified Id of the resource link.</param>
        /// <param name="name">The name of the resource link.</param>
        public ResourceLink(string id = default(string), string name = default(string), ResourceLinkProperties properties = default(ResourceLinkProperties))
        {
            Id = id;
            Name = name;
            Properties = properties;
        }

        /// <summary>
        /// Gets the fully qualified Id of the resource link.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the name of the resource link.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public ResourceLinkProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Properties != null)
            {
                this.Properties.Validate();
            }
        }
    }
}
