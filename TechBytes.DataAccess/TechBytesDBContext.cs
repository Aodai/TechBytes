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
            builder.Entity<IdentityUser>().HasData(
                new IdentityUser
                {
                    Id = userGuid.ToString(),
                    Email = "aodai100@gmail.com",
                    EmailConfirmed = true,
                    UserName = "aodai100@gmail.com",
                    PasswordHash = "AQAAAAEAACcQAAAAECXTeY9tKA1lcG1vX5/OaAuHvVHtFpKqP5QFQWblhlDdE7tE0A2VI/sBvMMzoftfqQ=="
                }
                );

            builder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "User", NormalizedName = "User" },
                new IdentityRole { Id = "2", Name = "Administrator", NormalizedName = "Admin" }
                );

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { RoleId = "1", UserId = userGuid.ToString() },
                new IdentityUserRole<string> { RoleId = "2", UserId = userGuid.ToString() }
                );
        }
    }
}
