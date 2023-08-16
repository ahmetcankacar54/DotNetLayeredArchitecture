using MediatR;
using Models.Dto;

namespace Mediator.Commands.Order.CreateOrder;

public class CreateOrderCommandRequest: IRequest<CreateOrderCommandResponse>
{
    public Data.Entities.Concretes.Order Order { get; set; }

    public CreateOrderCommandRequest(Data.Entities.Concretes.Order order)
    {
        Order = order;
    }
}