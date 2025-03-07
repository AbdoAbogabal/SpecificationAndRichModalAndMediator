namespace SpecificationPattern.Domain;

public class DeveloperByIncomeAndYearsOfExperienceSpecification : BaseSpecifcation<Developer>
{
    public DeveloperByIncomeAndYearsOfExperienceSpecification(int yearsOfExperience, int estimatedIncome) :
        base(e => e.YearsOfExperience <= yearsOfExperience && e.EstimatedIncome <= estimatedIncome)
    {
        AddInclude(e => e.Address);
    }
}