using Data;
using Data.Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Models.Dto;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(AppDbContext context) : base(context)
        {
        }
    }
}

