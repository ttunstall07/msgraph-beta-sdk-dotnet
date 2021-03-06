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
    /// The enum WindowsArchitecture.
    /// </summary>
    [JsonConverter(typeof(EnumConverter))]
	[System.Flags]
    public enum WindowsArchitecture
    {
    
        /// <summary>
        /// None
        /// </summary>
        None = 0,
	
        /// <summary>
        /// X86
        /// </summary>
        X86 = 1,
	
        /// <summary>
        /// X64
        /// </summary>
        X64 = 2,
	
        /// <summary>
        /// Arm
        /// </summary>
        Arm = 4,
	
        /// <summary>
        /// Neutral
        /// </summary>
        Neutral = 8,
	
        /// <summary>
        /// Arm64
        /// </summary>
        Arm64 = 16,
	
    }
}
