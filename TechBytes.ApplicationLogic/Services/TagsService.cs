
using System;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Exceptions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Services
{
    public class TagsService
    {
        private ITagRepository tagRepository;

        public TagsService(ITagRepository tagRepository)
        {
            this.tagRepository = tagRepository;
        }

        public Tag GetTagById(string id)
        {
            Guid guid = Guid.Empty;
            if (!Guid.TryParse(id, out guid))
                throw new Exception("Invalid guid format");
            var tag = tagRepository.GetTagById(guid) ?? throw new EntityNotFoundException(guid);
            return tag;
        }
    }
}
