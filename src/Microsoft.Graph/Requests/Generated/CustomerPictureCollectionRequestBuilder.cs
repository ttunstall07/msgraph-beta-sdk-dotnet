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
    /// The type CustomerPictureCollectionRequestBuilder.
    /// </summary>
    public partial class CustomerPictureCollectionRequestBuilder : BaseRequestBuilder, ICustomerPictureCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CustomerPictureCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CustomerPictureCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICustomerPictureCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICustomerPictureCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CustomerPictureCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IPictureRequestBuilder"/> for the specified CustomerPicture.
        /// </summary>
        /// <param name="id">The ID for the CustomerPicture.</param>
        /// <returns>The <see cref="IPictureRequestBuilder"/>.</returns>
        public IPictureRequestBuilder this[string id]
        {
            get
            {
                return new PictureRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}