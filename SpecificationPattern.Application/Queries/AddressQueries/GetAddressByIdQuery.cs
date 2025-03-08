namespace SpecificationPattern.Application.Queries.AddressQueries;

public record GetAddressByIdQuery(Guid id) : IQuery<Address> { }
