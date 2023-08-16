using System;
using Mediator.Commands.Order.CreateOrder;
using Mediator.Commands.Order.DeleteOrder;
using Mediator.Commands.Order.UpdateOrder;
using Mediator.Queries.Order.GetAllOrder;
using Mediator.Queries.Order.GetByIdOrder;
using Microsoft.AspNetCore.Mvc;
using Models.Dto;
using Service.Interfaces;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        protected readonly IOrderService orderService;

        public OrderController(IOrderService orderService)
        {
            this.orderService = orderService;
        }
        [HttpGet]
        public async Task<ActionResult<GetAllOrderQueryResponse>> GetAll()
        {
            return await orderService.GetAll();
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateOrderCommandResponse>> Add(OrderDto orderDto)
        {
            return await orderService.Add(orderDto);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdOrderQueryResponse>> GetById(int id)
        {
            return await orderService.GetById(id);
        }
        
        [HttpPut]
        public async Task<ActionResult<UpdateOrderCommandResponse>> Update(OrderUpdateDto orderDto)
        {
            return await orderService.Update(orderDto);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteOrderCommandResponse>> Delete(int id)
        {
            
            return await orderService.DeleteAsync(id);
        }
    }
}

