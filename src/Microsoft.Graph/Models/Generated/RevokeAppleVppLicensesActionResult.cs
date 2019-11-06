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
    /// The type RevokeAppleVppLicensesActionResult.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class RevokeAppleVppLicensesActionResult : DeviceActionResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeAppleVppLicensesActionResult"/> class.
        /// </summary>
        public RevokeAppleVppLicensesActionResult()
        {
            this.ODataType = "microsoft.graph.revokeAppleVppLicensesActionResult";
        }

        /// <summary>
        /// Gets or sets totalLicensesCount.
        /// Total number of Apple Vpp licenses associated
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "totalLicensesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? TotalLicensesCount { get; set; }
    
        /// <summary>
        /// Gets or sets failedLicensesCount.
        /// Total number of Apple Vpp licenses that failed to revoke
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedLicensesCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedLicensesCount { get; set; }
    
    }
}
