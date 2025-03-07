namespace SpecificationPattern.Application.Handlers.QueryHandlers;

public sealed class GetWithSpecificationPatternHandler<T> :
    IQueryHandler<GetWithSpecificationPatternQuery<T>, IEnumerable<T>>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public GetWithSpecificationPatternHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task<Result<IEnumerable<T>>> Handle(GetWithSpecificationPatternQuery<T> request, CancellationToken cancellationToken) =>
                     Result.Success(_genericRepository.FindWithSpecificationPattern(request.specification));
}
