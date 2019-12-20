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
    /// The type Group Policy Setting Mapping.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class GroupPolicySettingMapping : Entity
    {
    
		///<summary>
		/// The GroupPolicySettingMapping constructor
		///</summary>
        public GroupPolicySettingMapping()
        {
            this.ODataType = "microsoft.graph.groupPolicySettingMapping";
        }
	
        /// <summary>
        /// Gets or sets parent id.
        /// Parent Id of the group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "parentId", Required = Newtonsoft.Json.Required.Default)]
        public string ParentId { get; set; }
    
        /// <summary>
        /// Gets or sets child id list.
        /// List of Child Ids of the group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "childIdList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> ChildIdList { get; set; }
    
        /// <summary>
        /// Gets or sets setting name.
        /// The name of this group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingName { get; set; }
    
        /// <summary>
        /// Gets or sets setting value.
        /// The value of this group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingValue", Required = Newtonsoft.Json.Required.Default)]
        public string SettingValue { get; set; }
    
        /// <summary>
        /// Gets or sets setting value type.
        /// The value type of this group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingValueType", Required = Newtonsoft.Json.Required.Default)]
        public string SettingValueType { get; set; }
    
        /// <summary>
        /// Gets or sets setting display name.
        /// The display name of this group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingDisplayName", Required = Newtonsoft.Json.Required.Default)]
        public string SettingDisplayName { get; set; }
    
        /// <summary>
        /// Gets or sets setting display value.
        /// The display value of this group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingDisplayValue", Required = Newtonsoft.Json.Required.Default)]
        public string SettingDisplayValue { get; set; }
    
        /// <summary>
        /// Gets or sets setting display value type.
        /// The display value type of this group policy setting.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingDisplayValueType", Required = Newtonsoft.Json.Required.Default)]
        public string SettingDisplayValueType { get; set; }
    
        /// <summary>
        /// Gets or sets setting value display units.
        /// The display units of this group policy setting value
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingValueDisplayUnits", Required = Newtonsoft.Json.Required.Default)]
        public string SettingValueDisplayUnits { get; set; }
    
        /// <summary>
        /// Gets or sets setting category.
        /// The category the group policy setting is in.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingCategory", Required = Newtonsoft.Json.Required.Default)]
        public string SettingCategory { get; set; }
    
        /// <summary>
        /// Gets or sets mdm csp name.
        /// The CSP name this group policy setting maps to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmCspName", Required = Newtonsoft.Json.Required.Default)]
        public string MdmCspName { get; set; }
    
        /// <summary>
        /// Gets or sets mdm setting uri.
        /// The MDM CSP URI this group policy setting maps to.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmSettingUri", Required = Newtonsoft.Json.Required.Default)]
        public string MdmSettingUri { get; set; }
    
        /// <summary>
        /// Gets or sets mdm minimum osversion.
        /// The minimum OS version this mdm setting supports.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmMinimumOSVersion", Required = Newtonsoft.Json.Required.Default)]
        public Int32? MdmMinimumOSVersion { get; set; }
    
        /// <summary>
        /// Gets or sets setting type.
        /// The setting type (security or admx) of the Group Policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingType", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicySettingType? SettingType { get; set; }
    
        /// <summary>
        /// Gets or sets is mdm supported.
        /// Indicates if the setting is supported by Intune or not
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "isMdmSupported", Required = Newtonsoft.Json.Required.Default)]
        public bool? IsMdmSupported { get; set; }
    
        /// <summary>
        /// Gets or sets mdm supported state.
        /// Indicates if the setting is supported in Mdm or not
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "mdmSupportedState", Required = Newtonsoft.Json.Required.Default)]
        public MdmSupportedState? MdmSupportedState { get; set; }
    
        /// <summary>
        /// Gets or sets setting scope.
        /// The scope of the setting
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "settingScope", Required = Newtonsoft.Json.Required.Default)]
        public GroupPolicySettingScope? SettingScope { get; set; }
    
        /// <summary>
        /// Gets or sets intune setting uri list.
        /// The list of Intune Setting URIs this group policy setting maps to
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "intuneSettingUriList", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> IntuneSettingUriList { get; set; }
    
    }
}

