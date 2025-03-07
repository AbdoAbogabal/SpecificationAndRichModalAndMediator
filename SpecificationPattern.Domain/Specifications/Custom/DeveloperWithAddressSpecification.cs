namespace SpecificationPattern.Domain;

public class DeveloperWithAddressSpecification : BaseSpecifcation<Developer>
{
    public DeveloperWithAddressSpecification(int years) : base(x => x.EstimatedIncome > years)
    {
        AddInclude(x => x.Address);
    }
}