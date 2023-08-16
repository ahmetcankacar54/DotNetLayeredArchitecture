using MediatR;
using Models.Dto;

namespace Mediator.Commands.Product.UpdateProduct;

public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
{
    public Data.Entities.Concretes.Product Product;

    public UpdateProductCommandRequest(Data.Entities.Concretes.Product product)
    {
        Product = product;
    }
}