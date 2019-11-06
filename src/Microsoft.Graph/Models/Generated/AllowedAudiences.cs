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
    /// The enum AllowedAudiences.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum AllowedAudiences
    {
    
        /// <summary>
        /// Me
        /// </summary>
        Me = 0,
	
        /// <summary>
        /// Family
        /// </summary>
        Family = 1,
	
        /// <summary>
        /// Contacts
        /// </summary>
        Contacts = 2,
	
        /// <summary>
        /// Group Members
        /// </summary>
        GroupMembers = 4,
	
        /// <summary>
        /// Organization
        /// </summary>
        Organization = 8,
	
        /// <summary>
        /// Federated Organizations
        /// </summary>
        FederatedOrganizations = 16,
	
        /// <summary>
        /// Everyone
        /// </summary>
        Everyone = 32,
	
        /// <summary>
        /// Unknown Future Value
        /// </summary>
        UnknownFutureValue = 64,
	
    }
}
