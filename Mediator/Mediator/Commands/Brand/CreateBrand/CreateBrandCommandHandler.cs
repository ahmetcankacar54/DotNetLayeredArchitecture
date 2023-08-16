using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Brand.CreateBrand;

public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommandRequest, CreateBrandCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public CreateBrandCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        var brand = await UnitOfWork.BrandRepository.Add(request.brand);
        return new CreateBrandCommandResponse()
        {
            Brand = brand
        };
    }
}