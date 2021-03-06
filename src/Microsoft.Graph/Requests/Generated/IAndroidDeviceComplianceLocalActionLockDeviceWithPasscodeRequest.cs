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
    /// The interface IAndroidDeviceComplianceLocalActionLockDeviceWithPasscodeRequest.
    /// </summary>
    public partial interface IAndroidDeviceComplianceLocalActionLockDeviceWithPasscodeRequest : IBaseRequest
    {
        /// <summary>
        /// Creates the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode using POST.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceWithPasscodeToCreate">The AndroidDeviceComplianceLocalActionLockDeviceWithPasscode to create.</param>
        /// <returns>The created AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.</returns>
        System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode> CreateAsync(AndroidDeviceComplianceLocalActionLockDeviceWithPasscode androidDeviceComplianceLocalActionLockDeviceWithPasscodeToCreate);        /// <summary>
        /// Creates the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode using POST.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceWithPasscodeToCreate">The AndroidDeviceComplianceLocalActionLockDeviceWithPasscode to create.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The created AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.</returns>
        System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode> CreateAsync(AndroidDeviceComplianceLocalActionLockDeviceWithPasscode androidDeviceComplianceLocalActionLockDeviceWithPasscodeToCreate, CancellationToken cancellationToken);

        /// <summary>
        /// Deletes the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.
        /// </summary>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync();

        /// <summary>
        /// Deletes the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The task to await.</returns>
        System.Threading.Tasks.Task DeleteAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Gets the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.
        /// </summary>
        /// <returns>The AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.</returns>
        System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode> GetAsync();

        /// <summary>
        /// Gets the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.
        /// </summary>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <returns>The AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.</returns>
        System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode> GetAsync(CancellationToken cancellationToken);

        /// <summary>
        /// Updates the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode using PATCH.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceWithPasscodeToUpdate">The AndroidDeviceComplianceLocalActionLockDeviceWithPasscode to update.</param>
        /// <returns>The updated AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.</returns>
        System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode> UpdateAsync(AndroidDeviceComplianceLocalActionLockDeviceWithPasscode androidDeviceComplianceLocalActionLockDeviceWithPasscodeToUpdate);

        /// <summary>
        /// Updates the specified AndroidDeviceComplianceLocalActionLockDeviceWithPasscode using PATCH.
        /// </summary>
        /// <param name="androidDeviceComplianceLocalActionLockDeviceWithPasscodeToUpdate">The AndroidDeviceComplianceLocalActionLockDeviceWithPasscode to update.</param>
        /// <param name="cancellationToken">The <see cref="CancellationToken"/> for the request.</param>
        /// <exception cref="ClientException">Thrown when an object returned in a response is used for updating an object in Microsoft Graph.</exception>
        /// <returns>The updated AndroidDeviceComplianceLocalActionLockDeviceWithPasscode.</returns>
        System.Threading.Tasks.Task<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode> UpdateAsync(AndroidDeviceComplianceLocalActionLockDeviceWithPasscode androidDeviceComplianceLocalActionLockDeviceWithPasscodeToUpdate, CancellationToken cancellationToken);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="value">The expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceComplianceLocalActionLockDeviceWithPasscodeRequest Expand(string value);

        /// <summary>
        /// Adds the specified expand value to the request.
        /// </summary>
        /// <param name="expandExpression">The expression from which to calculate the expand value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceComplianceLocalActionLockDeviceWithPasscodeRequest Expand(Expression<Func<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode, object>> expandExpression);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="value">The select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceComplianceLocalActionLockDeviceWithPasscodeRequest Select(string value);

        /// <summary>
        /// Adds the specified select value to the request.
        /// </summary>
        /// <param name="selectExpression">The expression from which to calculate the select value.</param>
        /// <returns>The request object to send.</returns>
        IAndroidDeviceComplianceLocalActionLockDeviceWithPasscodeRequest Select(Expression<Func<AndroidDeviceComplianceLocalActionLockDeviceWithPasscode, object>> selectExpression);

    }
}
