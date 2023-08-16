using AutoMapper;
using Data;
using Data.Entities.Concretes;
using Mediator.Commands.Category.CreateCategory;
using Mediator.Commands.Category.DeleteCategory;
using Mediator.Commands.Category.UpdateCategory;
using Mediator.Queries.Category.GetAllCategory;
using Mediator.Queries.Category.GetByIdCategory;
using MediatR;
using Models.Dto;
using Service.Interfaces;

namespace Service.Concretes
{
    public class CategoryService : ICategoryService
    {
        protected  readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public CategoryService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public async Task<GetAllCategoryQueryResponse> GetAll()
        {
            return await _mediator.Send(new GetAllCategoryQueryRequest());
        }

        public async Task<CreateCategoryCommandResponse> Add(CategoryDto categoryDto)
        {
            var entity = _mapper.Map<Category>(categoryDto);
            CreateCategoryCommandResponse response = await _mediator.Send(new CreateCategoryCommandRequest(entity));
            return response;
        }

        public async Task<GetByIdCategoryQueryResponse> GetById(int Id)
        {
            return await _mediator.Send(new GetByIdCategoryQueryRequest(Id));
        }

        public async Task<UpdateCategoryCommandResponse> Update(CategoryUpdateDto categoryDto)
        {
            var entity = _mapper.Map<Category>(categoryDto);
            return await _mediator.Send(new UpdateCategoryCommandRequest(entity));
        }

        public async Task<DeleteCategoryCommandResponse> DeleteAsync(int Id)
        {
            return await _mediator.Send(new DeleteCategoryCommandRequest(Id));
        }
    }
}

