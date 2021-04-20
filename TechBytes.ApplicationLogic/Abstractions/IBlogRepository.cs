using System;
using System.Collections.Generic;
using System.Text;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface IBlogRepository : IRepository<Blog>
    {
        Blog GetBlogById(Guid id);
    }
}
