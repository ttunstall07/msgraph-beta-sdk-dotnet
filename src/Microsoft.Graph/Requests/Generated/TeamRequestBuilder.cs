// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

// **NOTE** This file was generated by a tool and any changes will be overwritten.
// <auto-generated/>

// Template Source: Templates\CSharp\Requests\EntityRequestBuilder.cs.tt

namespace Microsoft.Graph
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    /// <summary>
    /// The type TeamRequestBuilder.
    /// </summary>
    public partial class TeamRequestBuilder : EntityRequestBuilder, ITeamRequestBuilder
    {

        /// <summary>
        /// Constructs a new TeamRequestBuilder.
        /// </summary>
        /// <param name="requestUrl">The URL for the built request.</param>
        /// <param name="client">The <see cref="IBaseClient"/> for handling requests.</param>
        public TeamRequestBuilder(
            string requestUrl,
            IBaseClient client)
            : base(requestUrl, client)
        {
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <returns>The built request.</returns>
        public new ITeamRequest Request()
        {
            return this.Request(null);
        }

        /// <summary>
        /// Builds the request.
        /// </summary>
        /// <param name="options">The query and header options for the request.</param>
        /// <returns>The built request.</returns>
        public new ITeamRequest Request(IEnumerable<Option> options)
        {
            return new TeamRequest(this.RequestUrl, this.Client, options);
        }
    
        /// <summary>
        /// Gets the request builder for Schedule.
        /// </summary>
        /// <returns>The <see cref="IScheduleRequestBuilder"/>.</returns>
        public IScheduleRequestBuilder Schedule
        {
            get
            {
                return new ScheduleRequestBuilder(this.AppendSegmentToRequestUrl("schedule"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Group.
        /// </summary>
        /// <returns>The <see cref="IGroupWithReferenceRequestBuilder"/>.</returns>
        public IGroupWithReferenceRequestBuilder Group
        {
            get
            {
                return new GroupWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("group"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Template.
        /// </summary>
        /// <returns>The <see cref="ITeamsTemplateWithReferenceRequestBuilder"/>.</returns>
        public ITeamsTemplateWithReferenceRequestBuilder Template
        {
            get
            {
                return new TeamsTemplateWithReferenceRequestBuilder(this.AppendSegmentToRequestUrl("template"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Photo.
        /// </summary>
        /// <returns>The <see cref="IProfilePhotoRequestBuilder"/>.</returns>
        public IProfilePhotoRequestBuilder Photo
        {
            get
            {
                return new ProfilePhotoRequestBuilder(this.AppendSegmentToRequestUrl("photo"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Owners.
        /// </summary>
        /// <returns>The <see cref="ITeamOwnersCollectionWithReferencesRequestBuilder"/>.</returns>
        public ITeamOwnersCollectionWithReferencesRequestBuilder Owners
        {
            get
            {
                return new TeamOwnersCollectionWithReferencesRequestBuilder(this.AppendSegmentToRequestUrl("owners"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Channels.
        /// </summary>
        /// <returns>The <see cref="ITeamChannelsCollectionRequestBuilder"/>.</returns>
        public ITeamChannelsCollectionRequestBuilder Channels
        {
            get
            {
                return new TeamChannelsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("channels"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for PrimaryChannel.
        /// </summary>
        /// <returns>The <see cref="IChannelRequestBuilder"/>.</returns>
        public IChannelRequestBuilder PrimaryChannel
        {
            get
            {
                return new ChannelRequestBuilder(this.AppendSegmentToRequestUrl("primaryChannel"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Apps.
        /// </summary>
        /// <returns>The <see cref="ITeamAppsCollectionRequestBuilder"/>.</returns>
        public ITeamAppsCollectionRequestBuilder Apps
        {
            get
            {
                return new TeamAppsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("apps"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for InstalledApps.
        /// </summary>
        /// <returns>The <see cref="ITeamInstalledAppsCollectionRequestBuilder"/>.</returns>
        public ITeamInstalledAppsCollectionRequestBuilder InstalledApps
        {
            get
            {
                return new TeamInstalledAppsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("installedApps"), this.Client);
            }
        }

        /// <summary>
        /// Gets the request builder for Operations.
        /// </summary>
        /// <returns>The <see cref="ITeamOperationsCollectionRequestBuilder"/>.</returns>
        public ITeamOperationsCollectionRequestBuilder Operations
        {
            get
            {
                return new TeamOperationsCollectionRequestBuilder(this.AppendSegmentToRequestUrl("operations"), this.Client);
            }
        }
    
        /// <summary>
        /// Gets the request builder for TeamClone.
        /// </summary>
        /// <returns>The <see cref="ITeamCloneRequestBuilder"/>.</returns>
        public ITeamCloneRequestBuilder Clone(
            TeamVisibilityType visibility,
            ClonableTeamParts partsToClone,
            string displayName = null,
            string description = null,
            string mailNickname = null,
            string classification = null)
        {
            return new TeamCloneRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.clone"),
                this.Client,
                visibility,
                partsToClone,
                displayName,
                description,
                mailNickname,
                classification);
        }

        /// <summary>
        /// Gets the request builder for TeamArchive.
        /// </summary>
        /// <returns>The <see cref="ITeamArchiveRequestBuilder"/>.</returns>
        public ITeamArchiveRequestBuilder Archive(
            bool shouldSetSpoSiteReadOnlyForMembers)
        {
            return new TeamArchiveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.archive"),
                this.Client,
                shouldSetSpoSiteReadOnlyForMembers);
        }

        /// <summary>
        /// Gets the request builder for TeamUnarchive.
        /// </summary>
        /// <returns>The <see cref="ITeamUnarchiveRequestBuilder"/>.</returns>
        public ITeamUnarchiveRequestBuilder Unarchive()
        {
            return new TeamUnarchiveRequestBuilder(
                this.AppendSegmentToRequestUrl("microsoft.graph.unarchive"),
                this.Client);
        }
    
    }
}
