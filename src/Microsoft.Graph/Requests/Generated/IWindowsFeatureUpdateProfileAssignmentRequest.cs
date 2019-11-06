// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityRequest.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Threading;
    using System.Linq.Expressions;

    /// <summary>
    /// The interface IWindowsFeatureUpdateProfileAssignmentRequest.
    /// </summary>
    public partial interface IWindowsFeatureUpdateProfileAssignmentRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified WindowsFeatureUpdateProfileAssignment using POST.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileAssignmentToCreate">The WindowsFeatureUpdateProfileAssignment to create.</param>
        /// <returns>The created WindowsFeatureUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfileAssignment> CreateAsync(WindowsFeatureUpdateProfileAssignment windowsFeatureUpdateProfileAssignmentToCreate);        /// <summary>
        /// Creates the specified WindowsFeatureUpdateProfileAssignment using POST.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileAssignmentToCreate">The WindowsFeatureUpdateProfileAssignment to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created WindowsFeatureUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfileAssignment> CreateAsync(WindowsFeatureUpdateProfileAssignment windowsFeatureUpdateProfileAssignmentToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified WindowsFeatureUpdateProfileAssignment.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified WindowsFeatureUpdateProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified WindowsFeatureUpdateProfileAssignment.
        /// </summary>
        /// <returns>The WindowsFeatureUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfileAssignment> GetAsync();

        /// <summary>
        /// Gets the specified WindowsFeatureUpdateProfileAssignment.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The WindowsFeatureUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfileAssignment> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified WindowsFeatureUpdateProfileAssignment using PATCH.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileAssignmentToUpdate">The WindowsFeatureUpdateProfileAssignment to update.</param>
        /// <returns>The updated WindowsFeatureUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfileAssignment> UpdateAsync(WindowsFeatureUpdateProfileAssignment windowsFeatureUpdateProfileAssignmentToUpdate);

        /// <summary>
        /// Updates the specified WindowsFeatureUpdateProfileAssignment using PATCH.
        /// </summary>
        /// <param name="windowsFeatureUpdateProfileAssignmentToUpdate">The WindowsFeatureUpdateProfileAssignment to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated WindowsFeatureUpdateProfileAssignment.</returns>
        System.Threading.Tasks.Task<WindowsFeatureUpdateProfileAssignment> UpdateAsync(WindowsFeatureUpdateProfileAssignment windowsFeatureUpdateProfileAssignmentToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileAssignmentRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileAssignmentRequest Expand(Expression<Func<WindowsFeatureUpdateProfileAssignment, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileAssignmentRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IWindowsFeatureUpdateProfileAssignmentRequest Select(Expression<Func<WindowsFeatureUpdateProfileAssignment, object>> selectExpression);

    }
}
