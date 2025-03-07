namespace SpecificationPattern.Application.Base.Handlers;

public sealed class DeleteCommandHandler<T> : ICommandHandler<DeleteCommand<T>>
    where T : BaseEntity
{
    private readonly IGenericRepository<T> _genericRepository;

    public DeleteCommandHandler(IGenericRepository<T> genericRepository) => _genericRepository = genericRepository;

    public async Task<Result> Handle(DeleteCommand<T> request, CancellationToken cancellationToken)
    {
        try
        {
            await _genericRepository.Delete(request.id);

            return Result.Success("Deleted");
        }
        catch (Exception ex)
        {
            return Result.Failure(ex.Message);
        }

    }
}
