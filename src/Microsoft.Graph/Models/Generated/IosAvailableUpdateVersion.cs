// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\ComplexType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type IosAvailableUpdateVersion.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class IosAvailableUpdateVersion
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IosAvailableUpdateVersion"/> class.
        /// </summary>
        public IosAvailableUpdateVersion()
        {
            this.ODataType = "microsoft.graph.iosAvailableUpdateVersion";
        }

        /// <summary>
        /// Gets or sets productVersion.
        /// The version of the update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "productVersion", Required = Newtonsoft.Json.Required.Default)]
        public string ProductVersion { get; set; }
    
        /// <summary>
        /// Gets or sets postingDateTime.
        /// The posting date of the update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "postingDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? PostingDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets expirationDateTime.
        /// The expiration date of the update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "expirationDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ExpirationDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets supportedDevices.
        /// List of supported devices for the update.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "supportedDevices", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> SupportedDevices { get; set; }
    
        /// <summary>
        /// Gets or sets additional data.
        /// </summary>
        [JsonExtensionData(ReadData = true)]
        public IDictionary<string, object> AdditionalData { get; set; }

        /// <summary>
        /// Gets or sets @odata.type.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "@odata.type", Required = Newtonsoft.Json.Required.Default)]
        public string ODataType { get; set; }
    
    }
}
