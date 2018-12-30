﻿using Newtonsoft.Json.Linq;

namespace Flowsharp.Models
{
    public class WorkflowMetadata
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public JObject CustomFields { get; set; }
    }
}