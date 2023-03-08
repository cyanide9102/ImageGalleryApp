using Ardalis.Specification.EntityFrameworkCore;

using ImageGalleryApp.Core.Interfaces;

namespace ImageGalleryApp.Infrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IRepository<T>, IReadRepository<T> where T : class, IAggregateRoot
{
    private readonly AppDbContext _context;

    public EfRepository(AppDbContext context) : base(context)
    {
        _context = context;
    }

    public IQueryable<T> GetAll()
    {
        return _context.Set<T>();
    }
}
