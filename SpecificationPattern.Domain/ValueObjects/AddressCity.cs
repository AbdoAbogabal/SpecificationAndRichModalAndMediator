namespace SpecificationPattern.Domain.ValueObjects;

public partial class AddressCity : ValueObject<AddressCity>
{
    const int maxLength = 25;

    public string Value { get; set; }
}
