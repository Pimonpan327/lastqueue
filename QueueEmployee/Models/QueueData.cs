﻿namespace QMS.Models
{
    public class QueueData
    {
        
            public int queue_id { get; set; }
            public DateTime queue_date { get; set; }
            public string QueueStatus { get; set; }
            public string QueueType { get; set; }
            public string QueueNumber { get; set; }
            public int counter { get; set; }
            public string? Source { get; set; }

        
    }
}
