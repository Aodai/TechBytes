using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class TechBytesDBContext : IdentityDbContext<IdentityUser>
    {
        public TechBytesDBContext(DbContextOptions<TechBytesDBContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<PostTag> PostTags { get; set; }
        public DbSet<Tag> Tags { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            Guid userGuid = Guid.NewGuid();
            Guid blogGuid = Guid.NewGuid();
            IdentityUser user = new IdentityUser {
                Id = userGuid.ToString(),
                Email = "aodai100@gmail.com",
                EmailConfirmed = true,
                UserName = "aodai100@gmail.com",
                PasswordHash = "AQAAAAEAACcQAAAAECXTeY9tKA1lcG1vX5/OaAuHvVHtFpKqP5QFQWblhlDdE7tE0A2VI/sBvMMzoftfqQ==" // Test.123 
            };
            Blog blog = new Blog { ID = blogGuid, Url = "/TechBytes" };
            ICollection<Post> posts = new List<Post>
            {
                new Post { ID = Guid.NewGuid(), AuthorID = user.Id, BlogID = blogGuid, Title = "Post1", Content = "Bla bla", Published = DateTime.UtcNow },
                new Post { ID = Guid.NewGuid(), AuthorID = user.Id, BlogID = blogGuid, Title = "Post2", Content = "Bla bla", Published = DateTime.UtcNow },
                new Post { ID = Guid.NewGuid(), AuthorID = user.Id, BlogID = blogGuid, Title = "Post3", Content = "Bla bla", Published = DateTime.UtcNow },
                new Post { ID = Guid.NewGuid(), AuthorID = user.Id, BlogID = blogGuid, Title = "Post4", Content = "Bla bla", Published = DateTime.UtcNow }
            };


            builder.Entity<IdentityUser>().HasData(user);

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "User", NormalizedName = "User" },
                new IdentityRole { Id = "2", Name = "Administrator", NormalizedName = "Admin" }
                );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = userGuid.ToString() },
                new IdentityUserRole<string> { RoleId = "2", UserId = userGuid.ToString() }
                );

            builder.Entity<Blog>().HasData(blog);

            builder.Entity<Post>().HasData(posts);
        }
    }
}
