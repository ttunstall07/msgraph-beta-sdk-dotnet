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
    /// The type TextColumn.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    [JsonConverter(typeof(DerivedTypeConverter))]
    public partial class TextColumn
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TextColumn"/> class.
        /// </summary>
        public TextColumn()
        {
            this.ODataType = "microsoft.graph.textColumn";
        }

        /// <summary>
        /// Gets or sets allowMultipleLines.
        /// Whether to allow multiple lines of text.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "allowMultipleLines", Required = Newtonsoft.Json.Required.Default)]
        public bool? AllowMultipleLines { get; set; }
    
        /// <summary>
        /// Gets or sets appendChangesToExistingText.
        /// Whether updates to this column should replace existing text, or append to it.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appendChangesToExistingText", Required = Newtonsoft.Json.Required.Default)]
        public bool? AppendChangesToExistingText { get; set; }
    
        /// <summary>
        /// Gets or sets linesForEditing.
        /// The size of the text box.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "linesForEditing", Required = Newtonsoft.Json.Required.Default)]
        public Int32? LinesForEditing { get; set; }
    
        /// <summary>
        /// Gets or sets maxLength.
        /// The maximum number of characters for the value.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "maxLength", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MaxLength { get; set; }
    
        /// <summary>
        /// Gets or sets textType.
        /// The type of text being stored. Must be one of plain or richText
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "textType", Required = Newtonsoft.Json.Required.Default)]
        public string TextType { get; set; }
    
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
