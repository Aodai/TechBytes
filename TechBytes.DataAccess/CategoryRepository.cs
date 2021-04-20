using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.DataAccess
{
    public class CategoryRepository : BaseRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(TechBytesDBContext dbContext) : base(dbContext)
        {
        }

        public Category GetCategoryByID(Guid id)
        {
            return dbContext.Categories
                .Where(category => category.ID == id)
                .SingleOrDefault();
        }
    }
}
