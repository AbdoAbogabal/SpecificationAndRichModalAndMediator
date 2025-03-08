namespace SpecificationPattern.Application.Base.Handlers;

public sealed class CreateCommandHandler<T> : ICommandHandler<CreateCommand<T>>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public CreateCommandHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task Handle(CreateCommand<T> request, CancellationToken cancellationToken)
    {
        try
        {
            await _genericRepository.Add(request.entity);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
