// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Model\EnumType.cs.tt


namespace Microsoft.Graph
{
    using Newtonsoft.Json;

    /// <summary>
    /// The enum DeviceManagementTemplateType.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
    public enum DeviceManagementTemplateType
    {
    
        /// <summary>
        /// Security Baseline
        /// </summary>
        SecurityBaseline = 0,
	
        /// <summary>
        /// Specialized Devices
        /// </summary>
        SpecializedDevices = 1,
	
        /// <summary>
        /// Advanced Threat Protection Security Baseline
        /// </summary>
        AdvancedThreatProtectionSecurityBaseline = 2,
	
        /// <summary>
        /// Device Configuration
        /// </summary>
        DeviceConfiguration = 3,
	
        /// <summary>
        /// Custom
        /// </summary>
        Custom = 4,
	
        /// <summary>
        /// Security Template
        /// </summary>
        SecurityTemplate = 5,
	
        /// <summary>
        /// Microsoft Edge Security Baseline
        /// </summary>
        MicrosoftEdgeSecurityBaseline = 6,
	
        /// <summary>
        /// Microsoft Office365Pro Plus Security Baseline
        /// </summary>
        MicrosoftOffice365ProPlusSecurityBaseline = 7,
	
    }
}
