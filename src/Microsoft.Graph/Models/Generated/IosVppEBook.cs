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
    /// The type Ios Vpp EBook.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class IosVppEBook : ManagedEBook
    {
    
		///<summary>
		/// The IosVppEBook constructor
		///</summary>
        public IosVppEBook()
        {
            this.ODataType = "microsoft.graph.iosVppEBook";
        }
	
        /// <summary>
        /// Gets or sets vpp token id.
        /// The Vpp token ID.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppTokenId", Required = Newtonsoft.Json.Required.Default)]
        public Guid? VppTokenId { get; set; }
    
        /// <summary>
        /// Gets or sets apple id.
        /// The Apple ID associated with Vpp token.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "appleId", Required = Newtonsoft.Json.Required.Default)]
        public string AppleId { get; set; }
    
        /// <summary>
        /// Gets or sets vpp organization name.
        /// The Vpp token's organization name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vppOrganizationName", Required = Newtonsoft.Json.Required.Default)]
        public string VppOrganizationName { get; set; }
    
        /// <summary>
        /// Gets or sets genres.
        /// Genres.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "genres", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> Genres { get; set; }
    
        /// <summary>
        /// Gets or sets language.
        /// Language.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "language", Required = Newtonsoft.Json.Required.Default)]
        public string Language { get; set; }
    
        /// <summary>
        /// Gets or sets seller.
        /// Seller.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "seller", Required = Newtonsoft.Json.Required.Default)]
        public string Seller { get; set; }
    
        /// <summary>
        /// Gets or sets total license count.
        /// Total license count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets used license count.
        /// Used license count.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "usedLicenseCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? UsedLicenseCount { get; set; }
    
        /// <summary>
        /// Gets or sets role scope tag ids.
        /// List of Scope Tags for this Entity instance.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "roleScopeTagIds", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<string> RoleScopeTagIds { get; set; }
    
    }
}

