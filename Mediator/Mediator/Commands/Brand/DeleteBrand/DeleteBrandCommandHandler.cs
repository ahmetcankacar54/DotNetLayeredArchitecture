using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Brand.DeleteBrand;

public class DeleteBrandCommandHandler : IRequestHandler<DeleteBrandCommandRequest, DeleteBrandCommandResponse>
{
    protected readonly IBrandRepository _brandRepository;

    public DeleteBrandCommandHandler(IBrandRepository brandRepository)
    {
        _brandRepository = brandRepository;
    }

    public async Task<DeleteBrandCommandResponse> Handle(DeleteBrandCommandRequest request, CancellationToken cancellationToken)
    {
        await _brandRepository.DeleteAsync(request.id);
        return new DeleteBrandCommandResponse();
    }
}