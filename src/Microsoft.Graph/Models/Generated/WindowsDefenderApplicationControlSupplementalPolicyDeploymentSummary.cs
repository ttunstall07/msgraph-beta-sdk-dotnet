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
    /// The type Windows Defender Application Control Supplemental Policy Deployment Summary.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary : Entity
    {
    
		///<summary>
		/// The WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary constructor
		///</summary>
        public WindowsDefenderApplicationControlSupplementalPolicyDeploymentSummary()
        {
            this.ODataType = "microsoft.graph.windowsDefenderApplicationControlSupplementalPolicyDeploymentSummary";
        }
	
        /// <summary>
        /// Gets or sets deployed device count.
        /// Number of Devices that have successfully deployed this WindowsDefenderApplicationControl supplemental policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "deployedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? DeployedDeviceCount { get; set; }
    
        /// <summary>
        /// Gets or sets failed device count.
        /// Number of Devices that have failed to deploy this WindowsDefenderApplicationControl supplemental policy.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "failedDeviceCount", Required = Newtonsoft.Json.Required.Default)]
        public Int32? FailedDeviceCount { get; set; }
    
    }
}

