namespace SpecificationPattern.Application.Handlers.CommandHandlers.DeveloperCommandHandlers;

public class CreateDeveloperHandler : ICommandHandler<CreateDeveloperCommand>
{
    private readonly IGenericRepository<Developer> _repository;

    public CreateDeveloperHandler(IGenericRepository<Developer> repository) => _repository = repository;

    public async Task Handle(CreateDeveloperCommand request, CancellationToken cancellationToken) =>
           await _repository.Add(request.developer);
}
