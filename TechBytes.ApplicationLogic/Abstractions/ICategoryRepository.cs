using System;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Abstractions
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category GetCategoryByID(Guid id);
    }
}
