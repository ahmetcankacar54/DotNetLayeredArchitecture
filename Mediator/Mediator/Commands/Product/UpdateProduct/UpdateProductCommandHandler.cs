using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Product.UpdateProduct;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public UpdateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = await UnitOfWork.ProductRepository.Update(request.Product);
        UnitOfWork.Commit();
        return new UpdateProductCommandResponse()
        {
            UpdatedProduct = product
        };
    }
}