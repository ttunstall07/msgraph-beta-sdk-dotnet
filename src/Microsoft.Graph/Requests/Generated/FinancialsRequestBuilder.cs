// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type FinancialsRequestBuilder.
    /// </summary>
    public partial class FinancialsRequestBuilder : EntityRequestBuilder, IFinancialsRequestBuilder
    {

        /// <summary>
        /// Constructs a new FinancialsRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public FinancialsRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IFinancialsRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IFinancialsRequest Request(IEnumerable<Option> options)
        {
            return new FinancialsRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Companies.
        /// </summary>
        /// <returns>The <see cref="IFinancialsCompaniesCollectionRequestBuilder"/>.</returns>
        public IFinancialsCompaniesCollectionRequestBuilder Companies
        {
            get
            {
                return new FinancialsCompaniesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("companies"), this.Client);
            }
        }
    
    }
}
