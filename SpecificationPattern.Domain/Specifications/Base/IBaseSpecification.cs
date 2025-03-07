namespace SpecificationPattern.Domain;

public interface IBaseSpecification<T> where T : BaseEntity
{
    int Skip { get; }
    int Take { get; }
    bool IsPagingEnabled { get; }

    Expression<Func<T, bool>> Criteria { get; } // WHERE
    List<Expression<Func<T, object>>> Includes { get; } // INCLUDES
    Expression<Func<T, object>> OrderBy { get; }
    Expression<Func<T, object>> OrderByDescending { get; }
}