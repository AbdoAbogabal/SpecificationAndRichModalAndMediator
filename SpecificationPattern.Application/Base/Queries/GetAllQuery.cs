namespace SpecificationPattern.Application.Base.Queries;

public sealed record GetAllQuery<T>() : IQuery<List<T>>
    where T : BaseEntity;
