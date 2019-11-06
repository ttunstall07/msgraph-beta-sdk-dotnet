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
    /// The type Provisioning Object Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ProvisioningObjectSummary : Entity
    {
    
		///<summary>
		/// The ProvisioningObjectSummary constructor
		///</summary>
        public ProvisioningObjectSummary()
        {
            this.ODataType = "microsoft.graph.provisioningObjectSummary";
        }
	
        /// <summary>
        /// Gets or sets activity date time.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "activityDateTime", Required = Newtonsoft.Json.Required.Default)]
        public DateTimeOffset? ActivityDateTime { get; set; }
    
        /// <summary>
        /// Gets or sets tenant id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "tenantId", Required = Newtonsoft.Json.Required.Default)]
        public string TenantId { get; set; }
    
        /// <summary>
        /// Gets or sets job id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "jobId", Required = Newtonsoft.Json.Required.Default)]
        public string JobId { get; set; }
    
        /// <summary>
        /// Gets or sets cycle id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "cycleId", Required = Newtonsoft.Json.Required.Default)]
        public string CycleId { get; set; }
    
        /// <summary>
        /// Gets or sets change id.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "changeId", Required = Newtonsoft.Json.Required.Default)]
        public string ChangeId { get; set; }
    
        /// <summary>
        /// Gets or sets action.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "action", Required = Newtonsoft.Json.Required.Default)]
        public string Action { get; set; }
    
        /// <summary>
        /// Gets or sets duration in milliseconds.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "durationInMilliseconds", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DurationInMilliseconds { get; set; }
    
        /// <summary>
        /// Gets or sets initiated by.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "initiatedBy", Required = Newtonsoft.Json.Required.Default)]
        public Initiator InitiatedBy { get; set; }
    
        /// <summary>
        /// Gets or sets source system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceSystem", Required = Newtonsoft.Json.Required.Default)]
        public ProvisioningSystemDetails SourceSystem { get; set; }
    
        /// <summary>
        /// Gets or sets target system.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetSystem", Required = Newtonsoft.Json.Required.Default)]
        public ProvisioningSystemDetails TargetSystem { get; set; }
    
        /// <summary>
        /// Gets or sets source identity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "sourceIdentity", Required = Newtonsoft.Json.Required.Default)]
        public ProvisionedIdentity SourceIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets target identity.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "targetIdentity", Required = Newtonsoft.Json.Required.Default)]
        public ProvisionedIdentity TargetIdentity { get; set; }
    
        /// <summary>
        /// Gets or sets status info.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "statusInfo", Required = Newtonsoft.Json.Required.Default)]
        public StatusBase StatusInfo { get; set; }
    
        /// <summary>
        /// Gets or sets provisioning steps.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "provisioningSteps", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ProvisioningStep> ProvisioningSteps { get; set; }
    
        /// <summary>
        /// Gets or sets modified properties.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "modifiedProperties", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<ModifiedProperty> ModifiedProperties { get; set; }
    
    }
}

