using System;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface IPostRepository : IRepository<Post>
    {
        Post GetPostById(Guid id);
    }
}
