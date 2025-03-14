namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperName : ValueObject<DeveloperName>
{
    protected DeveloperName() { }
    protected DeveloperName(string value) => Value = value;

    public static DeveloperName Create(string name)
    {
        if (name.Trim().Equals(string.Empty))
            throw new Exception("Name can't be empty");

        if (name.Length > maxLength)
            throw new Exception($"Name length can't be more than {maxLength}");

        return new(name);
    }

    protected override bool EqualsCore(DeveloperName other) => Value.Equals(other.Value, StringComparison.InvariantCultureIgnoreCase);

    protected override int GetHashCodeCore() => Value.GetHashCode();


    public static explicit operator DeveloperName(string value) => Create(value);
    public static implicit operator string(DeveloperName developerName) => developerName.Value;
}
