namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperName : ValueObject<DeveloperName>
{
    const int maxLength = 25;
    public string Value { get; set; }
}
