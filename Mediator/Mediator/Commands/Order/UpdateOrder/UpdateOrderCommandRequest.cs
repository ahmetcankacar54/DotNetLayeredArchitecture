using MediatR;
using Models.Dto;

namespace Mediator.Commands.Order.UpdateOrder;

public class UpdateOrderCommandRequest : IRequest<UpdateOrderCommandResponse>
{
    public Data.Entities.Concretes.Order Order { get; set; }

    public UpdateOrderCommandRequest(Data.Entities.Concretes.Order order)
    {
        Order = order;
    }
}