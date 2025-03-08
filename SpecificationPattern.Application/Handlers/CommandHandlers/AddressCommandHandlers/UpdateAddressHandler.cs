namespace SpecificationPattern.Application.Handlers.CommandHandlers.AddressCommandHandlers;

public class UpdateAddressHandler : ICommandHandler<UpdateAddressCommand>
{
    private readonly IGenericRepository<Address> _repository;

    public UpdateAddressHandler(IGenericRepository<Address> repository) => _repository = repository;
    public async Task Handle(UpdateAddressCommand request, CancellationToken cancellationToken)
    {
        try
        {
            await _repository.Edit(request.address);
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}
