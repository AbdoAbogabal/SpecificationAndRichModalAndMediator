namespace SpecificationPattern.Domain;

public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
{
    public DeveloperWithAddressSpecification(int years) : base(x => x.DeveloperEstimatedIncome > years)
    {
        AddInclude(x => x.Address);
    }
}