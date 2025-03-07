namespace SpecificationPattern.Domain.DTOS;

public class OrderBySpecification<T> where T : BaseEntity
{
    public bool IsAsending { get; set; } = true;

    public Expression<Func<T, object>> OrderBy { get; set; }
}
