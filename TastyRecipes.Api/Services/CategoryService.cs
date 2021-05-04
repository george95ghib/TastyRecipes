using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyRecipes.Api.Data;
using TastyRecipes.Api.Domain;

namespace TastyRecipes.Api.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<Category> CreateCategoryAsync(string categoryName)
        {
            var newCategory = new Category
            {
                Name = categoryName
            };

            await _dataContext.Categories.AddAsync(newCategory);
            await _dataContext.SaveChangesAsync();

            return newCategory;
        }

        public async Task<List<Category>> GetCategoriesAsync()
        {
            return await _dataContext.Categories.ToListAsync();
        }
    }
}
