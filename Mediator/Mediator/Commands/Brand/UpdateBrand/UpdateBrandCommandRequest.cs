using MediatR;
using Models.Dto;

namespace Mediator.Commands.Brand.UpdateBrand;

public class UpdateBrandCommandRequest : IRequest<UpdateBrandCommandResponse>
{
    public Data.Entities.Concretes.Brand Brand { get; set; }

    public UpdateBrandCommandRequest(Data.Entities.Concretes.Brand brand)
    {
        Brand = brand;
    }
}