namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperEstimatedIncome : ValueObject<DeveloperEstimatedIncome>
{
    protected DeveloperEstimatedIncome() { }
    protected DeveloperEstimatedIncome(decimal value) => Value = value;

    public static DeveloperEstimatedIncome Create(decimal value)
    {
        if (value <= 0) throw new Exception("value can't be less than or equal to 0");

        return new(value);
    }

    protected override bool EqualsCore(DeveloperEstimatedIncome other) => Value.Equals(other.Value);

    protected override int GetHashCodeCore() => Value.GetHashCode();

    public static explicit operator DeveloperEstimatedIncome(decimal value) => Create(value);
    public static implicit operator decimal(DeveloperEstimatedIncome developerEstimatedIncome) =>
                           developerEstimatedIncome.Value;

}
