using System;
using System.Collections.Generic;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Exceptions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Services
{
    public class PostTagsServices
    {
        private IPostTagRepository postTagRepository;

        public PostTagsServices(IPostTagRepository postTagRepository)
        {
            this.postTagRepository = postTagRepository;
        }

        public IEnumerable<PostTag> GetTagsByPostId(string id)
        {
            Guid guid = Guid.Empty;
            if (!Guid.TryParse(id, out guid))
                throw new Exception("Invalid guid format");
            var postTag = postTagRepository.GetTagsByPostId(guid) ?? throw new EntityNotFoundException(guid);
            return postTag;
        }
    }
}
