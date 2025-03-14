namespace SpecificationPattern.Application.Handlers.QueryHandlers.AddressQueryHandlers;

public class GetAllAddressesHandler : IQueryHandler<GetAllAddressesQuery, IEnumerable<Address>>
{
    private readonly IGenericRepository<Address> _repository;

    public GetAllAddressesHandler(IGenericRepository<Address> repository) => _repository = repository;

    public async Task<IEnumerable<Address>> Handle(GetAllAddressesQuery request, CancellationToken cancellationToken)
    {
        var addresses = await _repository.GetAllAsync();

        return addresses;
    }
}
