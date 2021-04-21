using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class PostRepository : BaseRepository<Post>, IPostRepository
    {
        public PostRepository(TechBytesDBContext dbContext) : base(dbContext)
        {
        }

        public override IEnumerable<Post> GetAll()
        {
            var posts = dbContext.Posts
                .Include(p => p.Blog);
            return posts;
        }

        public Post GetPostById(Guid id)
        {
            return dbContext.Posts
                .Where(post => post.ID == id)
                .Include(p => p.Blog)
                .SingleOrDefault();
        }
    }
}
