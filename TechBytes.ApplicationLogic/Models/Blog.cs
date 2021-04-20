using System;
using System.Collections.Generic;
using System.Text;

namespace TechBytes.ApplicationLogic.Models
{
    public class Blog
    {
        public Guid ID { get; set; }
        public string Url { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
