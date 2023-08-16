using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.Category.GetAllCategory;

public class GetAllCategoryQueryHandler : IRequestHandler<GetAllCategoryQueryRequest, GetAllCategoryQueryResponse>
{
    protected readonly ICategoryRepository _categoryRepository;

    public GetAllCategoryQueryHandler(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<GetAllCategoryQueryResponse> Handle(GetAllCategoryQueryRequest request, CancellationToken cancellationToken)
    {
        var categories =  _categoryRepository.GetAll();
        return new GetAllCategoryQueryResponse()
        {
            Categories = categories
        };
    }
}