// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityCollectionWithReferencesPage.cs.tt

namespace Microsoft.Graph
{
    using System;

    /// <summary>
    /// The type WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesPage.
    /// </summary>
    public partial class WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesPage : CollectionPage<DeviceConfiguration>, IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesPage
    {
        /// <summary>
        /// Gets the next page <see cref="IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequest"/> instance.
        /// </summary>
        public IWindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequest NextPageRequest { get; private set; }

        /// <summary>
        /// Initializes the NextPageRequest property.
        /// </summary>
        public void InitializeNextPageRequest(IBaseClient client, string nextPageLinkString)
        {
            if (!string.IsNullOrEmpty(nextPageLinkString))
            {
                this.NextPageRequest = new WindowsDomainJoinConfigurationNetworkAccessConfigurationsCollectionWithReferencesRequest(
                    nextPageLinkString,
                    client,
                    null);
            }
        }
    }
}
