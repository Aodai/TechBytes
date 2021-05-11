using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;

namespace TechBytes.ApplicationLogic.Models
{
    public class Post
    {
        public Guid ID { get; set; }
        public Guid BlogID { get; set; }
        public Blog Blog { get; set; }
        public IdentityUser Author { get; set; }
        public DateTime Published { get; set; }
        public DateTime Modified { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Category Category { get; set; }

        public ICollection<PostTag> PostTags { get; set; }
    }
}