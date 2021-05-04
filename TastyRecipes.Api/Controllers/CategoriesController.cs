using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TastyRecipes.Api.Contracts;
using TastyRecipes.Api.Contracts.Requests;
using TastyRecipes.Api.Contracts.Responses;
using TastyRecipes.Api.Domain;
using TastyRecipes.Api.Services;

namespace TastyRecipes.Api.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        /// <summary>
        /// Returns all the categories in the system
        /// </summary>
        /// <response code="200">Returns all the categories in the system</response>
        [HttpGet(ApiRoutes.Categories.GetAll)]
        public async Task<IActionResult> GetAll()
        {
            var allCategories = await _categoryService.GetCategoriesAsync();

            return Ok(_mapper.Map<List<CategoryResponse>>(allCategories));
        }

        /// <summary>
        /// Creates a category in the system
        /// </summary>
        /// <response code="200">Creates a category in the system</response>
        /// <response code="400">Unable to create category due to validation error</response>
        [HttpPost(ApiRoutes.Categories.Create)]
        public async Task<IActionResult> Create([FromBody] CreateCategoryRequest request)
        {
            var newCategory = _mapper.Map<Category>(request);

            var createdCategory = await _categoryService.CreateCategoryAsync(newCategory);

            if (createdCategory == false)
            {
                return BadRequest(new { error = "Unable to create category" });
            }

            return Ok(_mapper.Map<CategoryResponse>(newCategory));
        }
    }
}
