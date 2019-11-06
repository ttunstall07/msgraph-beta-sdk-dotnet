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
    /// The type Planner Bucket.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class PlannerBucket : PlannerDelta
    {
    
		///<summary>
		/// The PlannerBucket constructor
		///</summary>
        public PlannerBucket()
        {
            this.ODataType = "microsoft.graph.plannerBucket";
        }
	
        /// <summary>
        /// Gets or sets name.
        /// Name of the bucket.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets plan id.
        /// Plan ID to which the bucket belongs.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "planId", Required = Newtonsoft.Json.Required.Default)]
        public string PlanId { get; set; }
    
        /// <summary>
        /// Gets or sets order hint.
        /// Hint used to order items of this type in a list view. The format is defined as outlined here.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "orderHint", Required = Newtonsoft.Json.Required.Default)]
        public string OrderHint { get; set; }
    
        /// <summary>
        /// Gets or sets tasks.
        /// Read-only. Nullable. The collection of tasks in the bucket.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tasks", Required = Newtonsoft.Json.Required.Default)]
        public IPlannerBucketTasksCollectionPage Tasks { get; set; }
    
    }
}

