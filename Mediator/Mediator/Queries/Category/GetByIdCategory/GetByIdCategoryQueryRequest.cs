using MediatR;

namespace Mediator.Queries.Category.GetByIdCategory;

public class GetByIdCategoryQueryRequest : IRequest<GetByIdCategoryQueryResponse>
{
    public int Id { get; set; }

    public GetByIdCategoryQueryRequest(int id)
    {
        Id = id;
    }
}