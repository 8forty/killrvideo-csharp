﻿using System;
using System.Threading.Tasks;
using Cassandra;
using DryIocAttributes;
using KillrVideo.Cassandra;
using KillrVideo.MessageBus;
using KillrVideo.Protobuf;
using KillrVideo.VideoCatalog.Events;

namespace KillrVideo.SampleData.Handlers
{
    /// <summary>
    /// Records the video id of any videos added to the site so that they can potentially be used when adding
    /// video-related sample data like comments, ratings, etc.
    /// </summary>
    [ExportMany, Reuse(ReuseType.Transient)]
    public class RecordVideosAddedHandler : IHandleMessage<UploadedVideoAdded>, IHandleMessage<YouTubeVideoAdded>
    {
        private readonly ISession _session;
        private readonly PreparedStatementCache _statementCache;

        public RecordVideosAddedHandler(ISession session, PreparedStatementCache statementCache)
        {
            if (session == null) throw new ArgumentNullException(nameof(session));
            if (statementCache == null) throw new ArgumentNullException(nameof(statementCache));
            _session = session;
            _statementCache = statementCache;
        }

        private async Task HandleImpl(Uuid videoId)
        {
            // Record the id in our sample data tracking table
            PreparedStatement prepared = await _statementCache.GetOrAddAsync("INSERT INTO sample_data_videos (videoid) VALUES (?)");
            await _session.ExecuteAsync(prepared.Bind(videoId.ToGuid())).ConfigureAwait(false);
        }

        public Task Handle(UploadedVideoAdded busEvent)
        {
            return HandleImpl(busEvent.VideoId);
        }

        public Task Handle(YouTubeVideoAdded busEvent)
        {
            return HandleImpl(busEvent.VideoId);
        }
    }
}
