// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\IEntityCollectionWithReferencesRequestBuilder.cs.tt
namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The interface IReportRootMonthlyPrintUsageSummariesByPrinterCollectionWithReferencesRequestBuilder.
    /// </summary>
    public partial interface IReportRootMonthlyPrintUsageSummariesByPrinterCollectionWithReferencesRequestBuilder : IBaseRequestBuilder
    {
        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        IReportRootMonthlyPrintUsageSummariesByPrinterCollectionWithReferencesRequest Request();

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        IReportRootMonthlyPrintUsageSummariesByPrinterCollectionWithReferencesRequest Request(IEnumerable<Option> options);

        /// <summary>
        /// Gets an <see cref="IPrintUsageSummaryByPrinterWithReferenceRequestBuilder"/> for the specified PrintUsageSummaryByPrinter.
        /// </summary>
        /// <param name="id">The ID for the PrintUsageSummaryByPrinter.</param>
        /// <returns>The <see cref="IPrintUsageSummaryByPrinterWithReferenceRequestBuilder"/>.</returns>
        IPrintUsageSummaryByPrinterWithReferenceRequestBuilder this[string id] { get; }
        
        /// <summary>
        /// Gets an <see cref="IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder"/> for the references in the collection.
        /// </summary>
        /// <returns>The <see cref="IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder"/>.</returns>
        IReportRootMonthlyPrintUsageSummariesByPrinterCollectionReferencesRequestBuilder References { get; }

    }
}
