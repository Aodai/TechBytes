using System;
using System.Collections.Generic;

namespace TechBytes.ApplicationLogic.Models
{
    public class Tag
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<PostTag> PostTags { get; set; }
    }
}