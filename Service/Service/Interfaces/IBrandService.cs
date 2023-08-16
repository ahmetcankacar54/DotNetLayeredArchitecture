using System;
using Mediator.Commands.Brand.CreateBrand;
using Mediator.Commands.Brand.DeleteBrand;
using Mediator.Commands.Brand.UpdateBrand;
using Mediator.Queries.Brand.GetAllBrand;
using Mediator.Queries.Brand.GetByIdBrand;
using MediatR;
using Models.Dto;

namespace Service.Interfaces
{
	public interface IBrandService
	{
		public Task<GetAllBrandQueryResponse> GetAll();
		public Task<CreateBrandCommandResponse> Add(BrandDto brandDto);
		public Task<GetByIdBrandQueryResponse> GetById(int Id);
		public Task<UpdateBrandCommandResponse> Update(BrandUpdateDto brandDto);
		public Task<DeleteBrandCommandResponse> DeleteAsync(int Id);
	}
}

