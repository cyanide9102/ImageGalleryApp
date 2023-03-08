using Ardalis.Specification;

namespace ImageGalleryApp.Core.Interfaces;
public interface IReadRepository<T> : IReadRepositoryBase<T> where T : class, IAggregateRoot
{
    IQueryable<T> GetAll();
}
