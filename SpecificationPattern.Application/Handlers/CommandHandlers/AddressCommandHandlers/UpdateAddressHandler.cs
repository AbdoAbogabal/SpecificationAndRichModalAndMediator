namespace SpecificationPattern.Application.Handlers.CommandHandlers.AddressCommandHandlers;

public class UpdateAddressHandler : ICommandHandler<UpdateAddressCommand>
{
    private readonly IGenericRepository<Address> _repository;

    public UpdateAddressHandler(IGenericRepository<Address> repository) => _repository = repository;
    public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken) =>
           await _repository.Edit(request.address);
}
