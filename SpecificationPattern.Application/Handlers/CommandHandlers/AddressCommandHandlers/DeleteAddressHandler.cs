namespace SpecificationPattern.Application.Handlers.CommandHandlers.AddressCommandHandlers;

public class DeleteAddressHandler : ICommandHandler<DeleteAddressCommand>
{
    private readonly IGenericRepository<Address> _repository;

    public DeleteAddressHandler(IGenericRepository<Address> repository) => _repository = repository;
    public async Task Handle(DeleteAddressCommand request, CancellationToken cancellationToken) =>
           await _repository.Delete(request.id);
}
