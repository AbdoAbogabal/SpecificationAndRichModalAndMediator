namespace SpecificationPattern.Application.Handlers.CommandHandlers.DeveloperCommandHandlers;

public class UpdateDeveloperHandler : ICommandHandler<UpdateDeveloperCommand>
{
    private readonly IGenericRepository<Developer> _repository;

    public UpdateDeveloperHandler(IGenericRepository<Developer> repository) => _repository = repository;

    public async Task Handle(UpdateDeveloperCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _repository.Edit(request.developer);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
