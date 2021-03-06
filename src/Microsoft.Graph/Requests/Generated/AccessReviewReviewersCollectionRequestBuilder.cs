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
    /// The type AccessReviewReviewersCollectionRequestBuilder.
    /// </summary>
    public partial class AccessReviewReviewersCollectionRequestBuilder : BaseRequestBuilder, IAccessReviewReviewersCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new AccessReviewReviewersCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AccessReviewReviewersCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAccessReviewReviewersCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAccessReviewReviewersCollectionRequest Request(IEnumerable<Option> options)
        {
            return new AccessReviewReviewersCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessReviewReviewerRequestBuilder"/> for the specified AccessReviewAccessReviewReviewer.
        /// </summary>
        /// <param name="id">The ID for the AccessReviewAccessReviewReviewer.</param>
        /// <returns>The <see cref="IAccessReviewReviewerRequestBuilder"/>.</returns>
        public IAccessReviewReviewerRequestBuilder this[string id]
        {
            get
            {
                return new AccessReviewReviewerRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}
