using System;
using Mediator.Commands.Order.CreateOrder;
using Mediator.Commands.Order.DeleteOrder;
using Mediator.Commands.Order.UpdateOrder;
using Mediator.Queries.Order.GetAllOrder;
using Mediator.Queries.Order.GetByIdOrder;
using MediatR;
using Models.Dto;

namespace Service.Interfaces
{
	public interface IOrderService
	{
		public Task<GetAllOrderQueryResponse> GetAll();
		public Task<CreateOrderCommandResponse> Add(OrderDto orderDto);
		public Task<GetByIdOrderQueryResponse> GetById(int Id);
		public Task<UpdateOrderCommandResponse> Update(OrderUpdateDto orderDto);
		public Task<DeleteOrderCommandResponse> DeleteAsync(int Id);
	}
}

