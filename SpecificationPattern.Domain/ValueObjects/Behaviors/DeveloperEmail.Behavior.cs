namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperEmail : ValueObject<DeveloperEmail>
{
    protected DeveloperEmail() { }
    protected DeveloperEmail(string value) => Value = value;

    protected override bool EqualsCore(DeveloperEmail other) => Value.Equals(other.Value, StringComparison.InvariantCultureIgnoreCase);

    protected override int GetHashCodeCore() => Value.GetHashCode();

    public static DeveloperEmail Create(string name)
    {
        if (name.Trim().Equals(string.Empty))
            throw new Exception("Name can't be empty");

        if (name.Length > maxLength)
            throw new Exception($"Name length can't be more than {maxLength}");
        return new(name);
    }

    public static explicit operator DeveloperEmail(string value) => Create(value);
    public static implicit operator string(DeveloperEmail developerEmail) => developerEmail.Value;
}
