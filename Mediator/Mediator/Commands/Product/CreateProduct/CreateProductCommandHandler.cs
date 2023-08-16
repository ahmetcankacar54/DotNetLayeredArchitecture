using MediatR;
using Repository.Repository.Interfaces;

namespace Mediator.Commands.Product.CreateProduct;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommandRequest, CreateProductCommandResponse>
{
    protected readonly IUnitOfWork UnitOfWork;

    public CreateProductCommandHandler(IUnitOfWork unitOfWork)
    {
        UnitOfWork = unitOfWork;
    }

    public async Task<CreateProductCommandResponse> Handle(CreateProductCommandRequest request, CancellationToken cancellationToken)
    {
        var product = await UnitOfWork.ProductRepository.Add(request.Product);
        return new CreateProductCommandResponse()
        {
            Product = product
        };
    }
}