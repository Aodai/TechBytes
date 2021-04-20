using System;
using System.Collections.Generic;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Exceptions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Services
{
    public class PostsService
    {
        private IPostRepository postRepository;

        public PostsService(IPostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public Post GetPostById(string id)
        {
            Guid guid = Guid.Empty;
            if (!Guid.TryParse(id, out guid))
                throw new Exception("Invalid guid format");
            var post = postRepository.GetPostById(guid) ?? throw new EntityNotFoundException(guid);
            return post;
        }
    }
}
