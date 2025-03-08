namespace SpecificationPattern.Application.Handlers.QueryHandlers;

public sealed class GetAllHandler<T> : IQueryHandler<GetAllQuery<T>, List<T>>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public GetAllHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task<List<T>> Handle(GetAllQuery<T> request, CancellationToken cancellationToken)
    {
        var entities = await _genericRepository.GetAllAsync();

        return entities;
    }
}
