namespace SpecificationPattern.Application.Handlers;

public sealed class UpdateCommandHandler<T> : ICommandHandler<UpdateCommand<T>>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public UpdateCommandHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task Handle(UpdateCommand<T> request, CancellationToken cancellationToken)
    {
        try
        {
            await _genericRepository.Edit(request.entity);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }

    }
}
