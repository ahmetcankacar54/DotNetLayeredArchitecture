using AutoMapper;
using Data;
using Data.Entities.Concretes;
using Mediator.Commands.User.CreateUser;
using Mediator.Commands.User.DeleteUser;
using Mediator.Commands.User.UpdateUser;
using Mediator.Queries.User.GetAllUser;
using Mediator.Queries.User.GetByIdUser;
using MediatR;
using Models.Dto;
using Service.Interfaces;

namespace Service.Concretes
{
    public class UserService : IUserService 
    {
        protected  readonly IMediator _mediator;
        protected readonly IMapper _mapper;

        public UserService(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        public async Task<GetAllUserQueryResponse> GetAll()
        {
            return await _mediator.Send(new GetAllUserQueryRequest());
        }

        public async Task<CreateUserCommandResponse> Add(UserDto userDto)
        {
            var entity = _mapper.Map<User>(userDto);
            CreateUserCommandResponse response = await _mediator.Send(new CreateUserCommandRequest(entity));
            return response;
        }

        public async Task<GetByIdUserQueryResponse> GetById(int Id)
        {
            return await _mediator.Send(new GetByIdUserQueryRequest(Id));
        }

        public async Task<UpdateUserCommandResponse> Update(UserUpdateDto userDto)
        {
            User entity = _mapper.Map<User>(userDto);
            return await _mediator.Send(new UpdateUserCommandRequest(entity));
        }


        public async Task<DeleteUserCommandResponse> DeleteAsync(int Id)
        {
            return await _mediator.Send(new DeleteUserCommandRequest(Id));
        }
    }
}

