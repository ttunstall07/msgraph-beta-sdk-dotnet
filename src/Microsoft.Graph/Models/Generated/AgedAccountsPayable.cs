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
    /// The type Aged Accounts Payable.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class AgedAccountsPayable : Entity
    {
    
		///<summary>
		/// The AgedAccountsPayable constructor
		///</summary>
        public AgedAccountsPayable()
        {
            this.ODataType = "microsoft.graph.agedAccountsPayable";
        }
	
        /// <summary>
        /// Gets or sets vendor number.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "vendorNumber", Required = Newtonsoft.Json.Required.Default)]
        public string VendorNumber { get; set; }
    
        /// <summary>
        /// Gets or sets name.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "name", Required = Newtonsoft.Json.Required.Default)]
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets currency code.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currencyCode", Required = Newtonsoft.Json.Required.Default)]
        public string CurrencyCode { get; set; }
    
        /// <summary>
        /// Gets or sets balance due.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "balanceDue", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? BalanceDue { get; set; }
    
        /// <summary>
        /// Gets or sets current amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "currentAmount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? CurrentAmount { get; set; }
    
        /// <summary>
        /// Gets or sets period1amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period1Amount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? Period1Amount { get; set; }
    
        /// <summary>
        /// Gets or sets period2amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period2Amount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? Period2Amount { get; set; }
    
        /// <summary>
        /// Gets or sets period3amount.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "period3Amount", Required = Newtonsoft.Json.Required.Default)]
        public Decimal? Period3Amount { get; set; }
    
        /// <summary>
        /// Gets or sets aged as of date.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "agedAsOfDate", Required = Newtonsoft.Json.Required.Default)]
        public Date AgedAsOfDate { get; set; }
    
        /// <summary>
        /// Gets or sets period length filter.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "periodLengthFilter", Required = Newtonsoft.Json.Required.Default)]
        public string PeriodLengthFilter { get; set; }
    
    }
}

