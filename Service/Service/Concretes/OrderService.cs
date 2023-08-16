using AutoMapper;
using Data;
using Data.Entities.Concretes;
using Mediator.Commands.Order.CreateOrder;
using Mediator.Commands.Order.DeleteOrder;
using Mediator.Commands.Order.UpdateOrder;
using Mediator.Queries.Order.GetAllOrder;
using Mediator.Queries.Order.GetByIdOrder;
using MediatR;
using Models.Dto;
using Service.Interfaces;

namespace Service.Concretes
{
    public class OrderService : IOrderService
    {
        protected  readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public OrderService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        public async Task<GetAllOrderQueryResponse> GetAll()
        {
            return await _mediator.Send(new GetAllOrderQueryRequest());
        }

        public async Task<CreateOrderCommandResponse> Add(OrderDto orderDto)
        {
            var entity = _mapper.Map<Order>(orderDto);
            CreateOrderCommandResponse response = await _mediator.Send(new CreateOrderCommandRequest(entity));
            return response;
        }

        public async Task<GetByIdOrderQueryResponse> GetById(int Id)
        {
            return await _mediator.Send(new GetByIdOrderQueryRequest(Id));
        }

        public async Task<UpdateOrderCommandResponse> Update(OrderUpdateDto orderDto)
        {
            var entity = _mapper.Map<Order>(orderDto);
            return await _mediator.Send(new UpdateOrderCommandRequest(entity));
        }

        public async Task<DeleteOrderCommandResponse> DeleteAsync(int Id)
        {
            return await _mediator.Send(new DeleteOrderCommandRequest(Id));
        }
    }
}

