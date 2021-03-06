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
    /// The type DeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequestBuilder.
    /// </summary>
    public partial class DeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequestBuilder : BaseRequestBuilder, IDeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new DeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public DeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IDeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IDeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new DeviceManagementImportedWindowsAutopilotDeviceIdentitiesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IImportedWindowsAutopilotDeviceIdentityRequestBuilder"/> for the specified DeviceManagementImportedWindowsAutopilotDeviceIdentity.
        /// </summary>
        /// <param name="id">The ID for the DeviceManagementImportedWindowsAutopilotDeviceIdentity.</param>
        /// <returns>The <see cref="IImportedWindowsAutopilotDeviceIdentityRequestBuilder"/>.</returns>
        public IImportedWindowsAutopilotDeviceIdentityRequestBuilder this[string id]
        {
            get
            {
                return new ImportedWindowsAutopilotDeviceIdentityRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for ImportedWindowsAutopilotDeviceIdentityImport.
        /// </summary>
        /// <returns>The <see cref="IImportedWindowsAutopilotDeviceIdentityImportRequestBuilder"/>.</returns>
        public IImportedWindowsAutopilotDeviceIdentityImportRequestBuilder Import(
            IEnumerable<ImportedWindowsAutopilotDeviceIdentity> importedWindowsAutopilotDeviceIdentities = null)
        {
            return new ImportedWindowsAutopilotDeviceIdentityImportRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.import"),
                this.Client,
                importedWindowsAutopilotDeviceIdentities);
        }
    }
}
