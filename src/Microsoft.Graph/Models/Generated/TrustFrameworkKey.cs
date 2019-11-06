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
    /// The type TrustFrameworkKey.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TrustFrameworkKey
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrustFrameworkKey"/> class.
        /// </summary>
        public TrustFrameworkKey()
        {
            this.ODataType = "microsoft.graph.trustFrameworkKey";
        }

        /// <summary>
        /// Gets or sets k.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "k", Required = Newtonsoft.Json.Required.Default)]
        public string K { get; set; }
    
        /// <summary>
        /// Gets or sets x5c.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "x5c", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> X5c { get; set; }
    
        /// <summary>
        /// Gets or sets x5t.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "x5t", Required = Newtonsoft.Json.Required.Default)]
        public string X5t { get; set; }
    
        /// <summary>
        /// Gets or sets kty.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kty", Required = Newtonsoft.Json.Required.Default)]
        public string Kty { get; set; }
    
        /// <summary>
        /// Gets or sets use.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "use", Required = Newtonsoft.Json.Required.Default)]
        public string Use { get; set; }
    
        /// <summary>
        /// Gets or sets exp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "exp", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Exp { get; set; }
    
        /// <summary>
        /// Gets or sets nbf.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "nbf", Required = Newtonsoft.Json.Required.Default)]
        public Int64? Nbf { get; set; }
    
        /// <summary>
        /// Gets or sets kid.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "kid", Required = Newtonsoft.Json.Required.Default)]
        public string Kid { get; set; }
    
        /// <summary>
        /// Gets or sets e.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "e", Required = Newtonsoft.Json.Required.Default)]
        public string E { get; set; }
    
        /// <summary>
        /// Gets or sets n.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "n", Required = Newtonsoft.Json.Required.Default)]
        public string N { get; set; }
    
        /// <summary>
        /// Gets or sets d.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "d", Required = Newtonsoft.Json.Required.Default)]
        public string D { get; set; }
    
        /// <summary>
        /// Gets or sets p.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "p", Required = Newtonsoft.Json.Required.Default)]
        public string P { get; set; }
    
        /// <summary>
        /// Gets or sets q.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "q", Required = Newtonsoft.Json.Required.Default)]
        public string Q { get; set; }
    
        /// <summary>
        /// Gets or sets dp.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dp", Required = Newtonsoft.Json.Required.Default)]
        public string Dp { get; set; }
    
        /// <summary>
        /// Gets or sets dq.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dq", Required = Newtonsoft.Json.Required.Default)]
        public string Dq { get; set; }
    
        /// <summary>
        /// Gets or sets qi.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "qi", Required = Newtonsoft.Json.Required.Default)]
        public string Qi { get; set; }
    
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
