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
    /// The interface IPrintUsageSummaryByUserRequest.
    /// </summary>
    public partial interface IPrintUsageSummaryByUserRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified PrintUsageSummaryByUser using POST.
        /// </summary>
        /// <param name="printUsageSummaryByUserToCreate">The PrintUsageSummaryByUser to create.</param>
        /// <returns>The created PrintUsageSummaryByUser.</returns>
        System.Threading.Tasks.Task<PrintUsageSummaryByUser> CreateAsync(PrintUsageSummaryByUser printUsageSummaryByUserToCreate);        /// <summary>
        /// Creates the specified PrintUsageSummaryByUser using POST.
        /// </summary>
        /// <param name="printUsageSummaryByUserToCreate">The PrintUsageSummaryByUser to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created PrintUsageSummaryByUser.</returns>
        System.Threading.Tasks.Task<PrintUsageSummaryByUser> CreateAsync(PrintUsageSummaryByUser printUsageSummaryByUserToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified PrintUsageSummaryByUser.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified PrintUsageSummaryByUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified PrintUsageSummaryByUser.
        /// </summary>
        /// <returns>The PrintUsageSummaryByUser.</returns>
        System.Threading.Tasks.Task<PrintUsageSummaryByUser> GetAsync();

        /// <summary>
        /// Gets the specified PrintUsageSummaryByUser.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The PrintUsageSummaryByUser.</returns>
        System.Threading.Tasks.Task<PrintUsageSummaryByUser> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified PrintUsageSummaryByUser using PATCH.
        /// </summary>
        /// <param name="printUsageSummaryByUserToUpdate">The PrintUsageSummaryByUser to update.</param>
        /// <returns>The updated PrintUsageSummaryByUser.</returns>
        System.Threading.Tasks.Task<PrintUsageSummaryByUser> UpdateAsync(PrintUsageSummaryByUser printUsageSummaryByUserToUpdate);

        /// <summary>
        /// Updates the specified PrintUsageSummaryByUser using PATCH.
        /// </summary>
        /// <param name="printUsageSummaryByUserToUpdate">The PrintUsageSummaryByUser to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated PrintUsageSummaryByUser.</returns>
        System.Threading.Tasks.Task<PrintUsageSummaryByUser> UpdateAsync(PrintUsageSummaryByUser printUsageSummaryByUserToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageSummaryByUserRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageSummaryByUserRequest Expand(Expression<Func<PrintUsageSummaryByUser, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageSummaryByUserRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IPrintUsageSummaryByUserRequest Select(Expression<Func<PrintUsageSummaryByUser, object>> selectExpression);

    }
}
