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
    /// The type Booking Staff Member.
    /// </summary>
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public partial class BookingStaffMember : BookingPerson
    {
    
		///<summary>
		/// The BookingStaffMember constructor
		///</summary>
        public BookingStaffMember()
        {
            this.ODataType = "microsoft.graph.bookingStaffMember";
        }
	
        /// <summary>
        /// Gets or sets availability is affected by personal calendar.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "availabilityIsAffectedByPersonalCalendar", Required = Newtonsoft.Json.Required.Default)]
        public bool? AvailabilityIsAffectedByPersonalCalendar { get; set; }
    
        /// <summary>
        /// Gets or sets color index.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "colorIndex", Required = Newtonsoft.Json.Required.Default)]
        public Int32? ColorIndex { get; set; }
    
        /// <summary>
        /// Gets or sets role.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "role", Required = Newtonsoft.Json.Required.Default)]
        public BookingStaffRole? Role { get; set; }
    
        /// <summary>
        /// Gets or sets use business hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "useBusinessHours", Required = Newtonsoft.Json.Required.Default)]
        public bool? UseBusinessHours { get; set; }
    
        /// <summary>
        /// Gets or sets working hours.
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore, PropertyName = "workingHours", Required = Newtonsoft.Json.Required.Default)]
        public IEnumerable<BookingWorkHours> WorkingHours { get; set; }
    
    }
}

