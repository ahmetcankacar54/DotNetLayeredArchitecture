using System;
using Mediator.Commands.User.CreateUser;
using Mediator.Commands.User.DeleteUser;
using Mediator.Commands.User.UpdateUser;
using Mediator.Queries.User.GetAllUser;
using Mediator.Queries.User.GetByIdUser;
using MediatR;
using Models.Dto;

namespace Service.Interfaces
{
    public interface IUserService 
	{
        public Task<GetAllUserQueryResponse> GetAll();
        public Task<CreateUserCommandResponse> Add(UserDto userDto);
        public Task<GetByIdUserQueryResponse> GetById(int Id);
        public Task<UpdateUserCommandResponse> Update(UserUpdateDto userDto);
        public Task<DeleteUserCommandResponse> DeleteAsync(int Id);
    }
}

