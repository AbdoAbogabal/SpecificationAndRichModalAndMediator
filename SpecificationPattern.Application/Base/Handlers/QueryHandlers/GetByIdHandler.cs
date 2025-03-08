namespace SpecificationPattern.Application.Handlers.QueryHandlers;

public sealed class GetByIdHandler<T> : IQueryHandler<GetByIdQuery<T>, T>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public GetByIdHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task<T> Handle(GetByIdQuery<T> request, CancellationToken cancellationToken)
    {
        T? entity = await _genericRepository.GetByIdAsync(request.id);

        if (entity is null)
            throw new Exception("entity is not found");

        return entity;
    }
}
