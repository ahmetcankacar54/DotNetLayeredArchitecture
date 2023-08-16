using Data;
using Repository.Repository.Interfaces;

namespace Repository.Repository.Concretes;

public class UnitOfWork : IUnitOfWork
{
    private AppDbContext _context;
    public IUserRepository UserRepository { get; private set; }
    public IBrandRepository BrandRepository { get; private set;  }
    public ICategoryRepository CategoryRepository { get; private set; }
    public IProductRepository ProductRepository { get; private set; }
    public IOrderRepository OrderRepository { get; private set; }

    public UnitOfWork(AppDbContext context, IUserRepository userRepository, IBrandRepository brandRepository, ICategoryRepository categoryRepository, IProductRepository productRepository, IOrderRepository orderRepository)
    {
        _context = context;
        UserRepository = userRepository;
        BrandRepository = brandRepository;
        CategoryRepository = categoryRepository;
        ProductRepository = productRepository;
        OrderRepository = orderRepository;
    }

    public virtual void Dispose()
    {
        _context.Dispose();
    }

    public int Commit(bool state = true)
    {
        return _context.SaveChanges();
    }
}