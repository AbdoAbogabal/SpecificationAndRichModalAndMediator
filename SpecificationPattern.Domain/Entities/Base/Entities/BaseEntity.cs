namespace SpecificationPattern.Domain;

public class BaseEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    [NotMapped] public string Message { get; set; }
}
