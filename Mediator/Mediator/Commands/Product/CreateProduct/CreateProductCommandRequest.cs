using MediatR;
using Models.Dto;

namespace Mediator.Commands.Product.CreateProduct;

public class CreateProductCommandRequest : IRequest<CreateProductCommandResponse>
{
    public Data.Entities.Concretes.Product Product;

    public CreateProductCommandRequest(Data.Entities.Concretes.Product product)
    {
        Product = product;
    }
}