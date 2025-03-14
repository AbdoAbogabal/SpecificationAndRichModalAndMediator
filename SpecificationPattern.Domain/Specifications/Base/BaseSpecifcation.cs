namespace SpecificationPattern.Domain;

public class BaseSpecifcation<T> : IBaseSpecification<T> where T : BaseEntity
{
    public BaseSpecifcation() { }
    public BaseSpecifcation(Expression<Func<T, bool>> criteria) => Criteria = criteria;
    public BaseSpecifcation(
        Pagination? pagination = null,
        Expression<Func<T, bool>>? criteria = null,
        OrderBySpecification<T>? orderBySpecification = null,
        List<Expression<Func<T, object>>>? includeExpression = null)
    {
        if (criteria is not null)
            Criteria = criteria;

        if (includeExpression is not null)
            includeExpression.ForEach(AddInclude);

        if (pagination is not null)
        {
            Skip = pagination.Skip;
            Take = pagination.Take;
        }

        if (orderBySpecification is not null)
        {
            if (orderBySpecification.IsAsending)
                AddOrderBy(orderBySpecification.OrderBy);
            else
                AddOrderByDescending(orderBySpecification.OrderBy);
        }
    }

    public int Take { get; protected set; }
    public int Skip { get; protected set; }
    public bool IsPagingEnabled { get; protected set; }

    public Expression<Func<T, bool>> Criteria { get; }
    public List<Expression<Func<T, object>>> Includes { get; } = new List<Expression<Func<T, object>>>();
    public Expression<Func<T, object>> OrderBy { get; private set; }
    public Expression<Func<T, object>> OrderByDescending { get; private set; }

    protected void AddPagination(int take, int skip)
    {
        Take = take;
        Skip = skip;
        IsPagingEnabled = true;
    }

    protected void AddInclude(Expression<Func<T, object>> includeExpression) => Includes.Add(includeExpression);
    protected void AddOrderBy(Expression<Func<T, object>> orderByExpression) => OrderBy = orderByExpression;
    protected void AddOrderByDescending(Expression<Func<T, object>> orderByDescExpression) => OrderByDescending = orderByDescExpression;
}
