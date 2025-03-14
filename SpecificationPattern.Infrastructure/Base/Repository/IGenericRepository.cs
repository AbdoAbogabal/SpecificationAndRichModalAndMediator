namespace SpecificationPattern.Infrastructure.Base;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(Guid id);
    Task<List<T>> GetAllAsync();

    IEnumerable<T> FindWithSpecificationPattern(IBaseSpecification<T> specification = null);
    Task<T> Add(T entity);
    Task<T> Edit(T entity);
    Task Delete(Guid id);
}