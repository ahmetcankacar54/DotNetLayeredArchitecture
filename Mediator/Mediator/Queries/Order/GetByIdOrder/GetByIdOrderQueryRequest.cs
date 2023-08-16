using MediatR;

namespace Mediator.Queries.Order.GetByIdOrder;

public class GetByIdOrderQueryRequest : IRequest<GetByIdOrderQueryResponse>
{
    public int Id { get; set; }

    public GetByIdOrderQueryRequest(int id)
    {
        Id = id;
    }
}