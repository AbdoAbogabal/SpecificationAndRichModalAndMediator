namespace SpecificationPattern.Application.Handlers.CommandHandlers.DeveloperCommandHandlers;

public class UpdateDeveloperHandler : ICommandHandler<UpdateDeveloperCommand>
{
    private readonly IGenericRepository<Developer> _repository;

    public UpdateDeveloperHandler(IGenericRepository<Developer> repository) => _repository = repository;

    public async Task Handle(UpdateDeveloperCommand request, CancellationToken cancellationToken) =>
           await _repository.Edit(request.developer);
}
