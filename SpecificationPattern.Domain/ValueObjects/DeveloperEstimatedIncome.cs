namespace SpecificationPattern.Domain.ValueObjects;

public partial class DeveloperEstimatedIncome : ValueObject<DeveloperEstimatedIncome>
{
    public decimal Value { get; set; }
}
