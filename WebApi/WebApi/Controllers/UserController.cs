using Mediator.Commands.User.CreateUser;
using Mediator.Commands.User.DeleteUser;
using Mediator.Commands.User.UpdateUser;
using Mediator.Queries.User.GetAllUser;
using Mediator.Queries.User.GetByIdUser;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http.HttpResults;
using Service.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Models.Dto;

namespace WebApi.Controllers
{
    [EnableCors]
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase 
    {
        protected readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpGet]
        public async Task<ActionResult<GetAllUserQueryResponse>> GetAll()
        {
            return await userService.GetAll();
        }
        
        [HttpPost]
        public async Task<ActionResult<CreateUserCommandResponse>> Add(UserDto userDto)
        {
            return await userService.Add(userDto);
        }
        
        [HttpGet("{id}")]
        public async Task<ActionResult<GetByIdUserQueryResponse>> GetById(int id)
        {
            return await userService.GetById(id);
        }
        
        [HttpPut]
        public async Task<ActionResult<UpdateUserCommandResponse>> Update(UserUpdateDto userDto)
        {
            return await userService.Update(userDto);
        }
        
        [HttpDelete("{id}")]
        public async Task<ActionResult<DeleteUserCommandResponse>> Delete(int id)
        {
            
            return await userService.DeleteAsync(id);
        }
        
        
    }
}

