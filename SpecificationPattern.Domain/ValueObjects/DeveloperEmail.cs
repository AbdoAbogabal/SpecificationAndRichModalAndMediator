namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperEmail : ValueObject<DeveloperEmail>
{
    const int maxLength = 25;

    public string Value { get; set; }
}
