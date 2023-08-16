using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Brand.UpdateBrand;

public class UpdateBrandCommandHandler : IRequestHandler<UpdateBrandCommandRequest, UpdateBrandCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public UpdateBrandCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<UpdateBrandCommandResponse> Handle(UpdateBrandCommandRequest request, CancellationToken cancellationToken)
    {
        var brand = await UnitOfWork.BrandRepository.Update(request.Brand);
        UnitOfWork.Commit();
        return new UpdateBrandCommandResponse()
        {
            UpdatedBrand = brand
        };
    }
}