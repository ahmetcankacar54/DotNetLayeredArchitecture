using MediatR;
using Models.Dto;

namespace Mediator.Commands.Brand.CreateBrand;

public class CreateBrandCommandRequest : IRequest<CreateBrandCommandResponse>
{
    public Data.Entities.Concretes.Brand brand { get; set; }

    public CreateBrandCommandRequest(Data.Entities.Concretes.Brand brand)
    {
        this.brand = brand;
    }
}