namespace SpecificationPattern.Application.Queries.DeveloperQueries;

public record GetDeveloperByIdQuery(Guid id) : IQuery<Developer> { }
