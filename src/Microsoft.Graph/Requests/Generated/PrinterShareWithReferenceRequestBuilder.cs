// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityWithReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type PrinterShareWithReferenceRequestBuilder.
    /// </summary>
    public partial class PrinterShareWithReferenceRequestBuilder : BaseRequestBuilder, IPrinterShareWithReferenceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PrinterShareWithReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PrinterShareWithReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IPrinterShareWithReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IPrinterShareWithReferenceRequest Request(IEnumerable<Option> options)
        {
            return new PrinterShareWithReferenceRequest(this.RequestUrl, this.Client, options);
        }
        
        /// <summary>
        /// Gets the request builder for the reference of the printerShare.
        /// </summary>
        /// <returns>The <see cref="IPrinterShareReferenceRequestBuilder"/>.</returns>
        public IPrinterShareReferenceRequestBuilder Reference
        {
            get
            {
                return new PrinterShareReferenceRequestBuilder(this.AppendSegmentToRequestUrl("$ref"), this.Client);
            }
        }

    }
}