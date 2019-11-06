// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\MethodRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type GroupEvaluateDynamicMembershipRequestBuilder.
    /// </summary>
    public partial class GroupEvaluateDynamicMembershipRequestBuilder : BaseActionMethodRequestBuilder<IGroupEvaluateDynamicMembershipRequest>, IGroupEvaluateDynamicMembershipRequestBuilder
    {
        /// <summary>
        /// Constructs a new <see cref="GroupEvaluateDynamicMembershipRequestBuilder"/>.
        /// </summary>
        /// <param name="requestUrl">The URL for the request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        /// <param name="memberId">A memberId parameter for the OData method call.</param>
        /// <param name="membershipRule">A membershipRule parameter for the OData method call.</param>
        public GroupEvaluateDynamicMembershipRequestBuilder(
            string requestUrl,
            IBaseClient client,
            string memberId,
            string membershipRule)
            : base(requestUrl, client)
        {
            this.SetParameter("memberId", memberId, true);
            this.SetParameter("membershipRule", membershipRule, true);
        }

        /// <summary>
        /// A method used by the base class to construct a request class instance.
        /// </summary>
        /// <param name="functionUrl">The request URL to </param>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>An instance of a specific request class.</returns>
        protected override IGroupEvaluateDynamicMembershipRequest CreateRequest(string functionUrl, IEnumerable<Option> options)
        {
            var request = new GroupEvaluateDynamicMembershipRequest(functionUrl, this.Client, options);

            if (this.HasParameter("memberId"))
            {
                request.RequestBody.MemberId = this.GetParameter<string>("memberId");
            }

            if (this.HasParameter("membershipRule"))
            {
                request.RequestBody.MembershipRule = this.GetParameter<string>("membershipRule");
            }

            return request;
        }
    }
}
