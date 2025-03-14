namespace SpecificationPattern.Application.Handlers.CommandHandlers.AddressCommandHandlers;

public class CreateAddressHandler : ICommandHandler<CreateAddressCommand>
{
    private readonly IGenericRepository<Address> _repository;

    public CreateAddressHandler(IGenericRepository<Address> repository) => _repository = repository;
    public async Task Handle(CreateAddressCommand request, CancellationToken cancellationToken) =>
           await _repository.Add(request.address);
}
