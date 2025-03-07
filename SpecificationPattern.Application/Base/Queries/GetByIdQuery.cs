namespace SpecificationPattern.Application.Base.Queries;

public sealed record GetByIdQuery<T>(Guid id) : IQuery<T>
    where T : BaseEntity;