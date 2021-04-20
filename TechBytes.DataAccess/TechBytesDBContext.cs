using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class TechBytesDBContext : DbContext
    {
        public TechBytesDBContext(DbContextOptions<TechBytesDBContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
