namespace SpecificationPattern.Domain.ValueObjects;

public partial class AddressStreet : ValueObject<AddressStreet>
{
    protected AddressStreet() { }
    protected AddressStreet(string value) => Value = value;

    protected override bool EqualsCore(AddressStreet other) => Value.Equals(other.Value, StringComparison.InvariantCultureIgnoreCase);

    protected override int GetHashCodeCore() => Value.GetHashCode();

    public static AddressStreet Create(string name)
    {
        if (name.Trim().Equals(string.Empty))
            throw new Exception("City can't be empty");

        if (name.Length > maxLength)
            throw new Exception($"City length can't be more than {maxLength}");
        return new(name);
    }

    public static explicit operator AddressStreet(string value) => Create(value);
    public static implicit operator string(AddressStreet addressStreet) => addressStreet.Value;
}
