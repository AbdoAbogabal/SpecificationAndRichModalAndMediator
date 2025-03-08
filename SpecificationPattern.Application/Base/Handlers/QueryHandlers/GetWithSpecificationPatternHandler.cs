namespace SpecificationPattern.Application.Handlers.QueryHandlers;

public sealed class GetWithSpecificationPatternHandler<T> :
    IQueryHandler<GetWithSpecificationPatternQuery<T>, IEnumerable<T>>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public GetWithSpecificationPatternHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task<IEnumerable<T>> Handle(GetWithSpecificationPatternQuery<T> request, CancellationToken cancellationToken) =>
                     _genericRepository.FindWithSpecificationPattern(request.specification);
}
