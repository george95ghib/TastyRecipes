using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyRecipes.Api.Domain;

namespace TastyRecipes.Api.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> GetCategoriesAsync();
        Task<bool> CreateCategoryAsync(Category newCategory);
    }
}
