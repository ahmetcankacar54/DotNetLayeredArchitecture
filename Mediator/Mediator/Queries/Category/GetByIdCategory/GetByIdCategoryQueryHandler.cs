using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Category.GetByIdCategory;

public class GetByIdCategoryQueryHandler : IRequestHandler<GetByIdCategoryQueryRequest, GetByIdCategoryQueryResponse>
{
    protected readonly ICategoryRepository _categoryRepository;

    public GetByIdCategoryQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<GetByIdCategoryQueryResponse> Handle(GetByIdCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        var category = await _categoryRepository.GetById(request.Id);
        return new GetByIdCategoryQueryResponse()
        {
            Category = category
        };
    }
}