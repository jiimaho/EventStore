﻿namespace EventStore.Projections.Core.Messages.Persisted.Responses.Slave
{
    public class PartitionProcessingProgressResponse
    {
        public string Partition;
        public float Progress;
    }
}