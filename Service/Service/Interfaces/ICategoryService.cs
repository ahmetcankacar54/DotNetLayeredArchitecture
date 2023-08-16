using System;
using Data.Entities.Concretes;
using Mediator.Commands.Category.CreateCategory;
using Mediator.Commands.Category.DeleteCategory;
using Mediator.Commands.Category.UpdateCategory;
using Mediator.Queries.Category.GetAllCategory;
using Mediator.Queries.Category.GetByIdCategory;
using MediatR;
using Models.Dto;

namespace Service.Interfaces
{
	public interface ICategoryService
	{
		public Task<GetAllCategoryQueryResponse> GetAll();
		public Task<CreateCategoryCommandResponse> Add(CategoryDto categoryDto);
		public Task<GetByIdCategoryQueryResponse> GetById(int Id);
		public Task<UpdateCategoryCommandResponse> Update(CategoryUpdateDto categoryDto);
		public Task<DeleteCategoryCommandResponse> DeleteAsync(int Id);
	}
}

