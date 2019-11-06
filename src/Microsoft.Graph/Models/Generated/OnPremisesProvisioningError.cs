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
    /// The type OnPremisesProvisioningError.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class OnPremisesProvisioningError
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OnPremisesProvisioningError"/> class.
        /// </summary>
        public OnPremisesProvisioningError()
        {
            this.ODataType = "microsoft.graph.onPremisesProvisioningError";
        }

        /// <summary>
        /// Gets or sets value.
        /// Value of the property causing the error.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "value", Required = Newtonsoft.Json.Required.Default)]
        public string Value { get; set; }
    
        /// <summary>
        /// Gets or sets category.
        /// Category of the provisioning error. Note: Currently, there is only one possible value. Possible value: PropertyConflict - indicates a property value is not unique. Other objects contain the same value for the property.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "category", Required = Newtonsoft.Json.Required.Default)]
        public string Category { get; set; }
    
        /// <summary>
        /// Gets or sets propertyCausingError.
        /// Name of the directory property causing the error. Current possible values: UserPrincipalName or ProxyAddress
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "propertyCausingError", Required = Newtonsoft.Json.Required.Default)]
        public string PropertyCausingError { get; set; }
    
        /// <summary>
        /// Gets or sets occurredDateTime.
        /// The date and time at which the error occurred.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "occurredDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? OccurredDateTime { get; set; }
    
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
