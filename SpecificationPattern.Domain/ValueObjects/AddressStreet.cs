namespace SpecificationPattern.Domain.ValueObjects;

public partial class AddressStreet : ValueObject<AddressStreet>
{
    const int maxLength = 25;

    public string Value { get; set; }
}
