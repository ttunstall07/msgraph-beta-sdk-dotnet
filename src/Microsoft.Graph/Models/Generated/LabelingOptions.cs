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
    /// The type LabelingOptions.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class LabelingOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LabelingOptions"/> class.
        /// </summary>
        public LabelingOptions()
        {
            this.ODataType = "microsoft.graph.labelingOptions";
        }

        /// <summary>
        /// Gets or sets labelId.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "labelId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? LabelId { get; set; }
    
        /// <summary>
        /// Gets or sets assignmentMethod.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "assignmentMethod", Required = Newtonsoft.Json.Required.Default)]
        public AssignmentMethod? AssignmentMethod { get; set; }
    
        /// <summary>
        /// Gets or sets downgradeJustification.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "downgradeJustification", Required = Newtonsoft.Json.Required.Default)]
        public DowngradeJustification DowngradeJustification { get; set; }
    
        /// <summary>
        /// Gets or sets extendedProperties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "extendedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<KeyValuePair> ExtendedProperties { get; set; }
    
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
