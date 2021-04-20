using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class PostTagRepository : BaseRepository<PostTag>, IPostTagRepository
    {
        public PostTagRepository(TechBytesDBContext dbContext) : base(dbContext)
        {
        }

        public IEnumerable<PostTag> GetTagsByPostId(Guid postId)
        {
            return dbContext.PostTags
                .Where(postTag => postTag.PostID == postId)
                .AsEnumerable();
        }
    }
}
