using AutoMapper;
using Data;
using Data.Entities.Concretes;
using Mediator.Commands.Brand.CreateBrand;
using Mediator.Commands.Brand.DeleteBrand;
using Mediator.Commands.Brand.UpdateBrand;
using Mediator.Queries.Brand.GetAllBrand;
using Mediator.Queries.Brand.GetByIdBrand;
using MediatR;
using Models.Dto;
using Service.Interfaces;

namespace Service.Concretes
{
    public class BrandService : IBrandService
    {
        protected  readonly IMediator _mediator;
        protected readonly IMapper _mapper;


        public BrandService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public async Task<GetAllBrandQueryResponse> GetAll()
        {
            return await _mediator.Send(new GetAllBrandQueryRequest());
        }

        public async Task<CreateBrandCommandResponse> Add(BrandDto brandDto)
        {
            var entity = _mapper.Map<Brand>(brandDto);
            CreateBrandCommandResponse response = await _mediator.Send(new CreateBrandCommandRequest(entity));
            return response;
        }

        public async Task<GetByIdBrandQueryResponse> GetById(int Id)
        {
            return await _mediator.Send(new GetByIdBrandQueryRequest(Id));
        }

        public async Task<UpdateBrandCommandResponse> Update(BrandUpdateDto brandDto)
        {
            var entity = _mapper.Map<Brand>(brandDto);
            return await _mediator.Send(new UpdateBrandCommandRequest(entity));
        }

        public async Task<DeleteBrandCommandResponse> DeleteAsync(int Id)
        {
            return await _mediator.Send(new DeleteBrandCommandRequest(Id));
        }
    }
}

