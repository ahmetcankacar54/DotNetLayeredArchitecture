using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.User.GetAllUser;

public class GetAllUserQueryHandler : IRequestHandler<GetAllUserQueryRequest, GetAllUserQueryResponse>
{
    protected readonly IUserRepository _userRepository;

    public GetAllUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<GetAllUserQueryResponse> Handle(GetAllUserQueryRequest request, CancellationToken cancellationToken)
    {
        var users =  _userRepository.GetAll();
        return new GetAllUserQueryResponse()
        {
            Users = users
        }; 
    }
}