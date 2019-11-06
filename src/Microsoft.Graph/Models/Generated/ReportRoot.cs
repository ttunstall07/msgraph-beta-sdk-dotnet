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
    /// The type Report Root.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class ReportRoot : Entity
    {
    
		///<summary>
		/// The ReportRoot constructor
		///</summary>
        public ReportRoot()
        {
            this.ODataType = "microsoft.graph.reportRoot";
        }
	
        /// <summary>
        /// Gets or sets application sign in detailed summary.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "applicationSignInDetailedSummary", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootApplicationSignInDetailedSummaryCollectionPage ApplicationSignInDetailedSummary { get; set; }
    
        /// <summary>
        /// Gets or sets credential user registration details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "credentialUserRegistrationDetails", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootCredentialUserRegistrationDetailsCollectionPage CredentialUserRegistrationDetails { get; set; }
    
        /// <summary>
        /// Gets or sets user credential usage details.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "userCredentialUsageDetails", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootUserCredentialUsageDetailsCollectionPage UserCredentialUsageDetails { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage summaries by user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dailyPrintUsageSummariesByUser", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootDailyPrintUsageSummariesByUserCollectionWithReferencesPage DailyPrintUsageSummariesByUser { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage summaries by user.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "monthlyPrintUsageSummariesByUser", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootMonthlyPrintUsageSummariesByUserCollectionWithReferencesPage MonthlyPrintUsageSummariesByUser { get; set; }
    
        /// <summary>
        /// Gets or sets daily print usage summaries by printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "dailyPrintUsageSummariesByPrinter", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootDailyPrintUsageSummariesByPrinterCollectionWithReferencesPage DailyPrintUsageSummariesByPrinter { get; set; }
    
        /// <summary>
        /// Gets or sets monthly print usage summaries by printer.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "monthlyPrintUsageSummariesByPrinter", Required = Newtonsoft.Json.Required.Default)]
        public IReportRootMonthlyPrintUsageSummariesByPrinterCollectionWithReferencesPage MonthlyPrintUsageSummariesByPrinter { get; set; }
    
    }
}

