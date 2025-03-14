namespace SpecificationPattern.Application.Handlers.CommandHandlers.DeveloperCommandHandlers;

public class DeleteDeveloperHandler : ICommandHandler<DeleteDeveloperCommand>
{
    private readonly IGenericRepository<Developer> _repository;

    public DeleteDeveloperHandler(IGenericRepository<Developer> repository) => _repository = repository;

    public async Task Handle(DeleteDeveloperCommand request, CancellationToken cancellationToken) =>
           await _repository.Delete(request.id);
}
