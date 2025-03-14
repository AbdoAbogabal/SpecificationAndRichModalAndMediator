namespace SpecificationPattern.Domain;

public class DeveloperByIncomeSpecification : BaseSpecifcation<Developer>
{
    public DeveloperByIncomeSpecification()
    {
        AddOrderByDescending(x => x.DeveloperEstimatedIncome);
    }
}