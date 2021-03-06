// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IGraphServicePrivilegedApprovalCollectionRequestBuilder.
    /// </summary>
    public partial interface IGraphServicePrivilegedApprovalCollectionRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IGraphServicePrivilegedApprovalCollectionRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IGraphServicePrivilegedApprovalCollectionRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrivilegedApprovalRequestBuilder"/> for the specified PrivilegedApproval.
        /// </summary>
        /// <param name="id">The ID for the PrivilegedApproval.</param>
        /// <returns>The <see cref="IPrivilegedApprovalRequestBuilder"/>.</returns>
        IPrivilegedApprovalRequestBuilder this[string id] { get; }

        /// <summary>
        /// Gets the request builder for PrivilegedApprovalMyRequests.
        /// </summary>
        /// <returns>The <see cref="IPrivilegedApprovalMyRequestsRequestBuilder"/>.</returns>
        IPrivilegedApprovalMyRequestsRequestBuilder MyRequests();
    }
}
