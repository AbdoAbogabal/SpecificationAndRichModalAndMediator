namespace SpecificationPattern.Application.Base.Queries;

public sealed record GetWithSpecificationPatternQuery<T>(IBaseSpecification<T> specification = null) :
    IQuery<IEnumerable<T>>
    where T : BaseEntity;
