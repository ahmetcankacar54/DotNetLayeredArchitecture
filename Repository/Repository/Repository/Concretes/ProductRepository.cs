using Data;
using Data.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }
    }
}

