namespace SpecificationPattern.Application.Queries.DeveloperQueries;

public record GetDevelopersBySpeceficationQuery(IBaseSpecification<Developer> specification = null) :
    IQuery<IEnumerable<Developer>>
{ }
