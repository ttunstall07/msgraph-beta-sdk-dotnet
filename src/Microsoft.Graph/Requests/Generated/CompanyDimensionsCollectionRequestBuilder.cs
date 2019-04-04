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
    /// The type CompanyDimensionsCollectionRequestBuilder.
    /// </summary>
    public partial class CompanyDimensionsCollectionRequestBuilder : BaseRequestBuilder, ICompanyDimensionsCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new CompanyDimensionsCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public CompanyDimensionsCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public ICompanyDimensionsCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public ICompanyDimensionsCollectionRequest Request(IEnumerable<Option> options)
        {
            return new CompanyDimensionsCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IDimensionRequestBuilder"/> for the specified CompanyDimension.
        /// </summary>
        /// <param name="id">The ID for the CompanyDimension.</param>
        /// <returns>The <see cref="IDimensionRequestBuilder"/>.</returns>
        public IDimensionRequestBuilder this[string id]
        {
            get
            {
                return new DimensionRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        
    }
}