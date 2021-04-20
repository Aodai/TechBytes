using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class TagRepository : BaseRepository<Tag>, ITagRepository
    {
        public TagRepository(TechBytesDBContext dbContext) : base(dbContext)
        {
        }

        public Tag GetTagById(Guid id)
        {
            return dbContext.Tags
                .Where(tag => tag.ID == id)
                .SingleOrDefault();
        }
    }
}
