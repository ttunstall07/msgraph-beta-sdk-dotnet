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
    /// The type IdentityContainerRequestBuilder.
    /// </summary>
    public partial class IdentityContainerRequestBuilder : EntityRequestBuilder, IIdentityContainerRequestBuilder
    {

        /// <summary>
        /// Constructs a new IdentityContainerRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public IdentityContainerRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new IIdentityContainerRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new IIdentityContainerRequest Request(IEnumerable<Option> options)
        {
            return new IdentityContainerRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for UserFlows.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerUserFlowsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerUserFlowsCollectionRequestBuilder UserFlows
        {
            get
            {
                return new IdentityContainerUserFlowsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("userFlows"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for FeatureConfigurations.
        /// </summary>
        /// <returns>The <see cref="IIdentityContainerFeatureConfigurationsCollectionRequestBuilder"/>.</returns>
        public IIdentityContainerFeatureConfigurationsCollectionRequestBuilder FeatureConfigurations
        {
            get
            {
                return new IdentityContainerFeatureConfigurationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("featureConfigurations"), this.Client);
            }
        }
    
    }
}
