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
    /// The type PurchaseInvoiceRequestBuilder.
    /// </summary>
    public partial class PurchaseInvoiceRequestBuilder : EntityRequestBuilder, IPurchaseInvoiceRequestBuilder
    {

        /// <summary>
        /// Constructs a new PurchaseInvoiceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public PurchaseInvoiceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IPurchaseInvoiceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IPurchaseInvoiceRequest Request(IEnumerable<Option> options)
        {
            return new PurchaseInvoiceRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for PurchaseInvoiceLines.
        /// </summary>
        /// <returns>The <see cref="IPurchaseInvoicePurchaseInvoiceLinesCollectionRequestBuilder"/>.</returns>
        public IPurchaseInvoicePurchaseInvoiceLinesCollectionRequestBuilder PurchaseInvoiceLines
        {
            get
            {
                return new PurchaseInvoicePurchaseInvoiceLinesCollectionRequestBuilder(this.AppendSegmentToRequestUrl("purchaseInvoiceLines"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Vendor.
        /// </summary>
        /// <returns>The <see cref="IVendorRequestBuilder"/>.</returns>
        public IVendorRequestBuilder Vendor
        {
            get
            {
                return new VendorRequestBuilder(this.AppendSegmentToRequestUrl("vendor"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Currency.
        /// </summary>
        /// <returns>The <see cref="ICurrencyRequestBuilder"/>.</returns>
        public ICurrencyRequestBuilder Currency
        {
            get
            {
                return new CurrencyRequestBuilder(this.AppendSegmentToRequestUrl("currency"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for PurchaseInvoicePost.
        /// </summary>
        /// <returns>The <see cref="IPurchaseInvoicePostRequestBuilder"/>.</returns>
        public IPurchaseInvoicePostRequestBuilder Post()
        {
            return new PurchaseInvoicePostRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.post"),
                this.Client);
        }
    
    }
}
