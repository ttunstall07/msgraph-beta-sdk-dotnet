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
    /// The type GraphServiceAccessPackageAssignmentResourceRolesCollectionRequestBuilder.
    /// </summary>
    public partial class GraphServiceAccessPackageAssignmentResourceRolesCollectionRequestBuilder : BaseRequestBuilder, IGraphServiceAccessPackageAssignmentResourceRolesCollectionRequestBuilder
    {
        /// <summary>
        /// Constructs a new GraphServiceAccessPackageAssignmentResourceRolesCollectionRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public GraphServiceAccessPackageAssignmentResourceRolesCollectionRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public IGraphServiceAccessPackageAssignmentResourceRolesCollectionRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public IGraphServiceAccessPackageAssignmentResourceRolesCollectionRequest Request(IEnumerable<Option> options)
        {
            return new GraphServiceAccessPackageAssignmentResourceRolesCollectionRequest(this.RequestUrl, this.Client, options);
        }

        /// <summary>
        /// Gets an <see cref="IAccessPackageAssignmentResourceRoleRequestBuilder"/> for the specified GraphServiceAccessPackageAssignmentResourceRole.
        /// </summary>
        /// <param name="id">The ID for the GraphServiceAccessPackageAssignmentResourceRole.</param>
        /// <returns>The <see cref="IAccessPackageAssignmentResourceRoleRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentResourceRoleRequestBuilder this[string id]
        {
            get
            {
                return new AccessPackageAssignmentResourceRoleRequestBuilder(this.AppendSegmentToRequestUrl(id), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for AccessPackageAssignmentResourceRoleMy.
        /// </summary>
        /// <returns>The <see cref="IAccessPackageAssignmentResourceRoleMyRequestBuilder"/>.</returns>
        public IAccessPackageAssignmentResourceRoleMyRequestBuilder My()
        {
            return new AccessPackageAssignmentResourceRoleMyRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.My"),
                this.Client);
        }
    }
}
