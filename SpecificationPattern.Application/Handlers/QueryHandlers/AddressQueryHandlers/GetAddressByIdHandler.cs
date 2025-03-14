namespace SpecificationPattern.Application.Handlers.QueryHandlers.AddressQueryHandlers;

public class GetAddressByIdHandler : IQueryHandler<GetAddressByIdQuery, Address>
{
    private readonly IGenericRepository<Address> _repository;

    public GetAddressByIdHandler(IGenericRepository<Address> repository) => _repository = repository;
    public async Task<Address> Handle(GetAddressByIdQuery request, CancellationToken cancellationToken)
    {
        var address = await _repository.GetByIdAsync(request.id);

        return address;
    }
}
