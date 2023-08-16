using System;
using Mediator.Commands.Brand.CreateBrand;
using Mediator.Commands.Brand.DeleteBrand;
using Mediator.Commands.Brand.UpdateBrand;
using Mediator.Queries.Brand.GetAllBrand;
using Mediator.Queries.Brand.GetByIdBrand;
using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Service.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BrandController : ControllerBase 
	{
        private readonly IBrandService brandService;

        public BrandController(IBrandService brandService)
        {
            this.brandService = brandService;
        }
        
        [HttpGet]
        public async Task<ActionResult<GetAllBrandQueryResponse>> GetAll()
        {
            return await brandService.GetAll();
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateBrandCommandResponse>> Add(BrandDto brandDto)
        {
            return await brandService.Add(brandDto);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdBrandQueryResponse>> GetById(int id)
        {
            return await brandService.GetById(id);
        }
        
        [HttpPut]
        public async Task<ActionResult<UpdateBrandCommandResponse>> Update(BrandUpdateDto brandDto)
        {
            return await brandService.Update(brandDto);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteBrandCommandResponse>> Delete(int id)
        {
            
            return await brandService.DeleteAsync(id);
        }
    }
}

