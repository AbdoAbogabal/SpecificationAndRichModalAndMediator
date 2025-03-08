namespace SpecificationPattern.Domain;

public static class SpecificationEvaluator<T> where T : BaseEntity
{
    public static IQueryable<T> GetQuery(IQueryable<T> inputQuery, IBaseSpecification<T> specification)
    {
        var query = inputQuery;

        if (specification.Includes is not null && specification.Includes.Any())
            query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));

        if (specification.Criteria is not null)
            query = query.Where(specification.Criteria);

        if (specification.OrderBy is not null)
            query = query.OrderBy(specification.OrderBy);
        else if (specification.OrderByDescending is not null)
            query = query.OrderByDescending(specification.OrderByDescending);

        if (specification.IsPagingEnabled)
            query = query.Skip(specification.Skip)
                         .Take(specification.Take);

        return query;
    }
}