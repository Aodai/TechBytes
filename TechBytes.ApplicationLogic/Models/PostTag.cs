using System;

namespace TechBytes.ApplicationLogic.Models
{
    public class PostTag
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public Guid PostID { get; set; }
        public Post Post { get; set; }
        public Guid TagID { get; set; }
        public Tag Tag { get; set; }
    }
}