using AutoMapper;
using Data.Entities.Concretes;
using Models.Dto;

namespace Service.AutoMapper.Profiles;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Brand, BrandDto>().ReverseMap();
        CreateMap<Brand, BrandUpdateDto>().ReverseMap();
        CreateMap<Category, CategoryDto>().ReverseMap();
        CreateMap<Category, CategoryUpdateDto>().ReverseMap();
        CreateMap<Order, OrderDto>().ReverseMap();
        CreateMap<Order, OrderUpdateDto>().ReverseMap();
        CreateMap<Product, ProductDto>().ReverseMap();
        CreateMap<Product, ProductUpdateDto>().ReverseMap();
        CreateMap<User, UserDto>().ReverseMap();
        CreateMap<User, UserUpdateDto>().ReverseMap();
        
    }
}