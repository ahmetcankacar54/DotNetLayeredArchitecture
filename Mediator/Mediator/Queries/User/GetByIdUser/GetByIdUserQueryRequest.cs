using MediatR;

namespace Mediator.Queries.User.GetByIdUser;

public class GetByIdUserQueryRequest : IRequest<GetByIdUserQueryResponse>
{
    public GetByIdUserQueryRequest(int id)
    {
        Id = id;
    }

    public int Id { get; set; }
}