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

        public IEnumerable<Post> GetAll()
        {
            var posts = postRepository.GetAll() ?? throw new EntityNotFoundException("No entities found");
            return posts;
        }

        public Post Add(Post post)
        {
            return postRepository.Add(post);
        }

        public Post Update(Post post)
        {
            return postRepository.Update(post);
        }

        public bool Delete(Post post)
        {
            return postRepository.Delete(post);
        }
    }
}
