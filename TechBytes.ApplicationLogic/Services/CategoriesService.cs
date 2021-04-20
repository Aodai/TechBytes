using System;
using System.Collections.Generic;
using TechBytes.ApplicationLogic.Abstractions;
using TechBytes.ApplicationLogic.Exceptions;
using TechBytes.ApplicationLogic.Models;

namespace TechBytes.ApplicationLogic.Services
{
    public class CategoriesService
    {
        private ICategoryRepository categoryRepository;

        public CategoriesService(ICategoryRepository categoryRepository)
        {
            this.categoryRepository = categoryRepository;
        }

        public Category GetCategoryById(string id)
        {
            Guid guid = Guid.Empty;
            if (!Guid.TryParse(id, out guid))
                throw new Exception("Invalid guid format");
            var category = categoryRepository.GetCategoryByID(guid) ?? throw new EntityNotFoundException(guid);
            return category;
        }
    }
}
