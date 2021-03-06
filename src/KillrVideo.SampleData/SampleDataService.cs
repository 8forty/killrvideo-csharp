﻿using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Google.Protobuf.Reflection;
using Grpc.Core;
using KillrVideo.MessageBus;
using KillrVideo.Protobuf.Services;

namespace KillrVideo.SampleData
{
    /// <summary>
    /// Implementation of sample data service that simply sends commands on the bus to a backend worker.
    /// </summary>
    [Export(typeof(IGrpcServerService))]
    public class SampleDataServiceImpl : SampleDataService.SampleDataServiceBase, IGrpcServerService
    {
        private readonly IBus _bus;

        public ServiceDescriptor Descriptor => SampleDataService.Descriptor;

        public SampleDataServiceImpl(IBus bus)
        {
            if (bus == null) throw new ArgumentNullException(nameof(bus));
            _bus = bus;
        }

        /// <summary>
        /// Convert this instance to a ServerServiceDefinition that can be run on a Grpc server.
        /// </summary>
        public ServerServiceDefinition ToServerServiceDefinition()
        {
            return SampleDataService.BindService(this);
        }

        /// <summary>
        /// Adds sample comments to the site.
        /// </summary>
        public override async Task<AddSampleCommentsResponse> AddSampleComments(AddSampleCommentsRequest request, ServerCallContext context)
        {
            // Publish the request so a handler can pick it up and run it in the background
            await _bus.Publish(request).ConfigureAwait(false);
            return new AddSampleCommentsResponse();
        }

        /// <summary>
        /// Adds sample video ratings to the site.
        /// </summary>
        public override async Task<AddSampleRatingsResponse> AddSampleRatings(AddSampleRatingsRequest request, ServerCallContext context)
        {
            // Publish the request so a handler can pick it up and run it in the background
            await _bus.Publish(request).ConfigureAwait(false);
            return new AddSampleRatingsResponse();
        }

        /// <summary>
        /// Adds sample users to the site.
        /// </summary>
        public override async Task<AddSampleUsersResponse> AddSampleUsers(AddSampleUsersRequest request, ServerCallContext context)
        {
            // Publish the request so a handler can pick it up and run it in the background
            await _bus.Publish(request).ConfigureAwait(false);
            return new AddSampleUsersResponse();
        }

        /// <summary>
        /// Adds sample video views to the site.
        /// </summary>
        public override async Task<AddSampleVideoViewsResponse> AddSampleVideoViews(AddSampleVideoViewsRequest request, ServerCallContext context)
        {
            // Publish the request so a handler can pick it up and run it in the background
            await _bus.Publish(request).ConfigureAwait(false);
            return new AddSampleVideoViewsResponse();
        }

        /// <summary>
        /// Adds sample YouTube videos to the site.
        /// </summary>
        public override async Task<AddSampleYouTubeVideosResponse> AddSampleYouTubeVideos(AddSampleYouTubeVideosRequest request, ServerCallContext context)
        {
            // Publish the request so a handler can pick it up and run it in the background
            await _bus.Publish(request).ConfigureAwait(false);
            return new AddSampleYouTubeVideosResponse();
        }

        /// <summary>
        /// Triggers a refresh of the YouTube sample video sources.
        /// </summary>
        public override async Task<RefreshYouTubeSourcesResponse> RefreshYouTubeSources(RefreshYouTubeSourcesRequest request, ServerCallContext context)
        {
            // Publish the request so a handler can pick it up and run it in the background
            await _bus.Publish(request).ConfigureAwait(false);
            return new RefreshYouTubeSourcesResponse();
        }
    }
}