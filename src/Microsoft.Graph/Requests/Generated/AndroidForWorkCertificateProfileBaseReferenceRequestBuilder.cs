// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityReferenceRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The type AndroidForWorkCertificateProfileBaseReferenceRequestBuilder.
    /// </summary>
    public partial class AndroidForWorkCertificateProfileBaseReferenceRequestBuilder : BaseRequestBuilder, IAndroidForWorkCertificateProfileBaseReferenceRequestBuilder
    {
        /// <summary>
        /// Constructs a new AndroidForWorkCertificateProfileBaseReferenceRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public AndroidForWorkCertificateProfileBaseReferenceRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IAndroidForWorkCertificateProfileBaseReferenceRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IAndroidForWorkCertificateProfileBaseReferenceRequest Request(IEnumerable<Option> options)
        {
            return new AndroidForWorkCertificateProfileBaseReferenceRequest(this.RequestUrl, this.Client, options);
        }
    }
}
