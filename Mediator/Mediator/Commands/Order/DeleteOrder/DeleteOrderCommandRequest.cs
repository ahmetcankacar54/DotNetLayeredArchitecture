using MediatR;

namespace Mediator.Commands.Order.DeleteOrder;

public class DeleteOrderCommandRequest : IRequest<DeleteOrderCommandResponse>
{
    public int id { get; set; }

    public DeleteOrderCommandRequest(int id)
    {
        this.id = id;
    }
}