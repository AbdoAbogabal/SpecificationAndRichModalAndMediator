namespace SpecificationPattern.Infrastructure;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly ApplicationDbContext _context;

    public GenericRepository(ApplicationDbContext context) => _context = context;

    public async Task<T> Add(T entity)
    {
        await _context.Set<T>().AddAsync(entity);

        await _context.SaveChangesAsync();

        await _context.Entry(entity).ReloadAsync();

        return entity;
    }

    public async Task<T> Edit(T entity)
    {
        _context.Set<T>().Update(entity);

        await _context.SaveChangesAsync();

        await _context.Entry(entity).ReloadAsync();

        return entity;
    }

    public async Task Delete(Guid id)
    {
        T entity = await GetByIdAsync(id);
        if (entity is null)
            throw new ArgumentNullException(nameof(entity));

        _context.Remove(entity);

        await _context.SaveChangesAsync();
    }

    public async Task<List<T>> GetAllAsync() => await _context.Set<T>().ToListAsync();
    public async Task<T> GetByIdAsync(Guid id) => await _context.Set<T>().FirstOrDefaultAsync(e => e.Id.Equals(id));

    public IEnumerable<T> FindWithSpecificationPattern(IBaseSpecification<T> specification = null) =>
                          SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), specification);
}