using System;
using Mediator.Commands.Category.CreateCategory;
using Mediator.Commands.Category.DeleteCategory;
using Mediator.Commands.Category.UpdateCategory;
using Mediator.Queries.Category.GetAllCategory;
using Mediator.Queries.Category.GetByIdCategory;
using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Service.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : ControllerBase 
	{
        private readonly ICategoryService categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        
        [HttpGet]
        public async Task<ActionResult<GetAllCategoryQueryResponse>> GetAll()
        {
            return await categoryService.GetAll();
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateCategoryCommandResponse>> Add(CategoryDto categoryDto)
        {
            return await categoryService.Add(categoryDto);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdCategoryQueryResponse>> GetById(int id)
        {
            return await categoryService.GetById(id);
        }
        
        [HttpPut]
        public async Task<ActionResult<UpdateCategoryCommandResponse>> Update(CategoryUpdateDto categoryDto)
        {
            return await categoryService.Update(categoryDto);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteCategoryCommandResponse>> Delete(int id)
        {
            
            return await categoryService.DeleteAsync(id);
        }
    }
}

