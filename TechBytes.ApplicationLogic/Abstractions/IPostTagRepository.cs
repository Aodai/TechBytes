using System;
using System.Collections.Generic;
using System.Text;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface IPostTagRepository : IRepository<PostTag>
    {
        IEnumerable<PostTag> GetTagsByPostId(Guid postId);
    }
}
