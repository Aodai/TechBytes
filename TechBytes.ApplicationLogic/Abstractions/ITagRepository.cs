using System;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface ITagRepository : IRepository<Tag>
    {
        Tag GetTagById(Guid id);
    }
}
