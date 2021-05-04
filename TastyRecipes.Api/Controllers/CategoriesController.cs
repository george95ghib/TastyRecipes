using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyRecipes.Api.Contracts;
using TastyRecipes.Api.Contracts.Requests;
using TastyRecipes.Api.Services;

namespace TastyRecipes.Api.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        /// <summary>
        /// Returns all the categories in the system
        /// </summary>
        /// <response code="200">Returns all the categories in the system</response>
        [HttpGet(ApiRoutes.Categories.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _categoryService.GetCategoriesAsync());
        }

        /// <summary>
        /// Creates a category in the system
        /// </summary>
        /// <response code="200">Creates a category in the system</response>
        /// <response code="400">Unable to create category due to validation error</response>
        [HttpPost(ApiRoutes.Categories.Create)]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequest request)
        {
            var createdCategory = await _categoryService.CreateCategoryAsync(request.Name);

            return Ok(createdCategory);

        }
    }
}
