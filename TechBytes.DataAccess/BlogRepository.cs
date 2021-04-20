using System;
using System.Linq;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class BlogRepository : BaseRepository<Blog>, IBlogRepository
    {
        public BlogRepository(TechBytesDBContext dbContext) : base(dbContext) { }

        public Blog GetBlogById(Guid id)
        {
            return dbContext.Blogs
                .Where(blog => blog.ID == id)
                .SingleOrDefault();
        }
    }
}
