namespace SpecificationPattern.Domain.ValueObjects;

public partial class AddressCity : ValueObject<AddressCity>
{
    protected AddressCity() { }
    protected AddressCity(string value) => Value = value;

    protected override bool EqualsCore(AddressCity other) => Value.Equals(other.Value, StringComparison.InvariantCultureIgnoreCase);

    protected override int GetHashCodeCore() => Value.GetHashCode();

    public static AddressCity Create(string name)
    {
        if (string.IsNullOrEmpty(name))
            throw new Exception("City can't be empty");

        if (name.Length > maxLength)
            throw new Exception($"City length can't be more than {maxLength}");

        return new(name);
    }

    public static explicit operator AddressCity(string value) => Create(value);
    public static implicit operator string(AddressCity addressCity) => addressCity.Value;
}
