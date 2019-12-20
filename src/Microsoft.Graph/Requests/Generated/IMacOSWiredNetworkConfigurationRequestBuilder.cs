// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The interface IMacOSWiredNetworkConfigurationRequestBuilder.
    /// </summary>
    public partial interface IMacOSWiredNetworkConfigurationRequestBuilder : IDeviceConfigurationRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        new IMacOSWiredNetworkConfigurationRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        new IMacOSWiredNetworkConfigurationRequest Request(IEnumerable<Option> options);
    
        /// <summary>
        /// Gets the request builder for RootCertificateForServerValidation.
        /// </summary>
        /// <returns>The <see cref="IMacOSTrustedRootCertificateWithReferenceRequestBuilder"/>.</returns>
        IMacOSTrustedRootCertificateWithReferenceRequestBuilder RootCertificateForServerValidation { get; }

        /// <summary>
        /// Gets the request builder for IdentityCertificateForClientAuthentication.
        /// </summary>
        /// <returns>The <see cref="IMacOSCertificateProfileBaseWithReferenceRequestBuilder"/>.</returns>
        IMacOSCertificateProfileBaseWithReferenceRequestBuilder IdentityCertificateForClientAuthentication { get; }
    
    }
}
