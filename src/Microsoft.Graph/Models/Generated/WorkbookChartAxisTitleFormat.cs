// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EntityType.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Runtime.Serialization;
    using Newtonsoft.Json;

    /// <summary>
    /// The type Workbook Chart Axis Title Format.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WorkbookChartAxisTitleFormat : Entity
    {
    
		///<summary>
		/// The WorkbookChartAxisTitleFormat constructor
		///</summary>
        public WorkbookChartAxisTitleFormat()
        {
            this.ODataType = "microsoft.graph.workbookChartAxisTitleFormat";
        }
	
        /// <summary>
        /// Gets or sets font.
        /// Represents the font attributes, such as font name, font size, color, etc. of chart axis title object. Read-only.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "font", Required = Newtonsoft.Json.Required.Default)]
        public WorkbookChartFont Font { get; set; }
    
    }
}

