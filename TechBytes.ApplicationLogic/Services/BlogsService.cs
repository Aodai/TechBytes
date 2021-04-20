using System;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Exceptions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Services
{
    public class BlogsService
    {
        private IBlogRepository blogRepository;
        
        public BlogsService(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }

        public Blog GetBlogById(string id)
        {
            Guid guid = Guid.Empty;
            if (!Guid.TryParse(id, out guid))
                throw new Exception("Invalid guid format");
            var blog = blogRepository.GetBlogById(guid) ?? throw new EntityNotFoundException(guid);
            return blog;
        }
    }
}
