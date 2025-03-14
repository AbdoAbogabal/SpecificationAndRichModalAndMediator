namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperYearsOfExperience : ValueObject<DeveloperYearsOfExperience>
{
    protected DeveloperYearsOfExperience() { }
    protected DeveloperYearsOfExperience(int value) => Value = value;

    public static DeveloperYearsOfExperience Create(int value)
    {
        if (value <= 0) throw new Exception("value can't be less than 0");

        return new(value);
    }
    protected override bool EqualsCore(DeveloperYearsOfExperience other) => Value.Equals(other.Value);

    protected override int GetHashCodeCore() => Value.GetHashCode();

    public static explicit operator DeveloperYearsOfExperience(int value) => Create(value);
    public static implicit operator int(DeveloperYearsOfExperience developerYearsOfExperience) =>
                                                                   developerYearsOfExperience.Value;
}
