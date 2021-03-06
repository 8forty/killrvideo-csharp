﻿using System;
using System.ComponentModel.Composition;
using System.Threading.Tasks;
using Cassandra;
using KillrVideo.Cassandra;
using KillrVideo.MessageBus;

namespace KillrVideo.SampleData.Scheduler.Jobs
{
    /// <summary>
    /// Scheduled job that runs to add sample ratings to videos.
    /// </summary>
    [Export(typeof(SampleDataJob))]
    public class AddSampleRatingsJob : SampleDataJob
    {
        private readonly IBus _bus;

        /// <summary>
        /// Runs every 2 minutes.
        /// </summary>
        protected override int MinutesBetweenRuns => 2;

        public AddSampleRatingsJob(ISession session, PreparedStatementCache statementCache, IBus bus) 
            : base(session, statementCache)
        {
            if (bus == null) throw new ArgumentNullException(nameof(bus));
            _bus = bus;
        }

        protected override Task RunImpl()
        {
            return _bus.Publish(new AddSampleRatingsRequest { NumberOfRatings = 5 });
        }
    }
}