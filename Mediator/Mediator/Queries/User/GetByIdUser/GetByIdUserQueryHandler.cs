using System.Runtime.CompilerServices;
using Mediator.Queries.Product.GetByIdProduct;
using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Queries.User.GetByIdUser;

public class GetByIdUserQueryHandler : IRequestHandler<GetByIdUserQueryRequest, GetByIdUserQueryResponse>
{
    protected readonly IUserRepository _userRepository;

    public GetByIdUserQueryHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }
    
    public async Task<GetByIdUserQueryResponse> Handle(GetByIdUserQueryRequest request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetById(request.Id);
        return new GetByIdUserQueryResponse()
        {
            User = user
        };
    }
}