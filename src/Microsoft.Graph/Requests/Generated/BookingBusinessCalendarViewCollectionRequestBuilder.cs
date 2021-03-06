// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type BookingBusinessCalendarViewCollectionRequestBuilder.
    /// </summary>
    public partial class BookingBusinessCalendarViewCollectionRequestBuilder : BaseRequestBuilder, IBookingBusinessCalendarViewCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new BookingBusinessCalendarViewCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public BookingBusinessCalendarViewCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IBookingBusinessCalendarViewCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IBookingBusinessCalendarViewCollectionRequest Request(IEnumerable<Option> options)
        {
            return new BookingBusinessCalendarViewCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IBookingAppointmentRequestBuilder"/> for the specified BookingBusinessBookingAppointment.
        /// </summary>
        /// <param name="id">The ID for the BookingBusinessBookingAppointment.</param>
        /// <returns>The <see cref="IBookingAppointmentRequestBuilder"/>.</returns>
        public IBookingAppointmentRequestBuilder this[string id]
        {
            get
            {
                return new BookingAppointmentRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
