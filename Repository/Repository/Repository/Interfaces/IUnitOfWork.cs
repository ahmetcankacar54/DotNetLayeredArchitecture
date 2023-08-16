namespace Repository.Repository.Interfaces;

public interface IUnitOfWork : IDisposable
{
    public IUserRepository UserRepository { get; }
    public IBrandRepository BrandRepository { get; }
    public ICategoryRepository CategoryRepository { get; }
    public IProductRepository ProductRepository { get; }
    public IOrderRepository OrderRepository { get; }
    public int Commit( bool state = true);
}