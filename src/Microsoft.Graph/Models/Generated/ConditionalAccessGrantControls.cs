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
    /// The type ConditionalAccessGrantControls.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class ConditionalAccessGrantControls
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConditionalAccessGrantControls"/> class.
        /// </summary>
        public ConditionalAccessGrantControls()
        {
            this.ODataType = "microsoft.graph.conditionalAccessGrantControls";
        }

        /// <summary>
        /// Gets or sets operator.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "operator", Required = Newtonsoft.Json.Required.Default)]
        public string Operator { get; set; }
    
        /// <summary>
        /// Gets or sets builtInControls.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "builtInControls", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ConditionalAccessGrantControl> BuiltInControls { get; set; }
    
        /// <summary>
        /// Gets or sets customAuthenticationFactors.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "customAuthenticationFactors", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> CustomAuthenticationFactors { get; set; }
    
        /// <summary>
        /// Gets or sets termsOfUse.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "termsOfUse", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> TermsOfUse { get; set; }
    
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
