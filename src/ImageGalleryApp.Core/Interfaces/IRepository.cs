using Ardalis.Specification;

namespace ImageGalleryApp.Core.Interfaces;
public interface IRepository<T> : IRepositoryBase<T> where T : class, IAggregateRoot
{
}
