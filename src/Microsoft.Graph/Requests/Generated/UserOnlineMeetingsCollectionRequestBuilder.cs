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
    /// The type UserOnlineMeetingsCollectionRequestBuilder.
    /// </summary>
    public partial class UserOnlineMeetingsCollectionRequestBuilder : BaseRequestBuilder, IUserOnlineMeetingsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new UserOnlineMeetingsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public UserOnlineMeetingsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IUserOnlineMeetingsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IUserOnlineMeetingsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new UserOnlineMeetingsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IOnlineMeetingRequestBuilder"/> for the specified UserOnlineMeeting.
        /// </summary>
        /// <param name="id">The ID for the UserOnlineMeeting.</param>
        /// <returns>The <see cref="IOnlineMeetingRequestBuilder"/>.</returns>
        public IOnlineMeetingRequestBuilder this[string id]
        {
            get
            {
                return new OnlineMeetingRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
