using System;
using System.Collections.Generic;

namespace TechBytes.ApplicationLogic.Models
{
    public class Category
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public ICollection<Post> Posts { get; set; }
    }
}