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
    /// The interface IItemFacetRequest.
    /// </summary>
    public partial interface IItemFacetRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified ItemFacet using POST.
        /// </summary>
        /// <param name="itemFacetToCreate">The ItemFacet to create.</param>
        /// <returns>The created ItemFacet.</returns>
        System.Threading.Tasks.Task<ItemFacet> CreateAsync(ItemFacet itemFacetToCreate);        /// <summary>
        /// Creates the specified ItemFacet using POST.
        /// </summary>
        /// <param name="itemFacetToCreate">The ItemFacet to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created ItemFacet.</returns>
        System.Threading.Tasks.Task<ItemFacet> CreateAsync(ItemFacet itemFacetToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified ItemFacet.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified ItemFacet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified ItemFacet.
        /// </summary>
        /// <returns>The ItemFacet.</returns>
        System.Threading.Tasks.Task<ItemFacet> GetAsync();

        /// <summary>
        /// Gets the specified ItemFacet.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The ItemFacet.</returns>
        System.Threading.Tasks.Task<ItemFacet> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified ItemFacet using PATCH.
        /// </summary>
        /// <param name="itemFacetToUpdate">The ItemFacet to update.</param>
        /// <returns>The updated ItemFacet.</returns>
        System.Threading.Tasks.Task<ItemFacet> UpdateAsync(ItemFacet itemFacetToUpdate);

        /// <summary>
        /// Updates the specified ItemFacet using PATCH.
        /// </summary>
        /// <param name="itemFacetToUpdate">The ItemFacet to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated ItemFacet.</returns>
        System.Threading.Tasks.Task<ItemFacet> UpdateAsync(ItemFacet itemFacetToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemFacetRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IItemFacetRequest Expand(Expression<Func<ItemFacet, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IItemFacetRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IItemFacetRequest Select(Expression<Func<ItemFacet, object>> selectExpression);

    }
}
