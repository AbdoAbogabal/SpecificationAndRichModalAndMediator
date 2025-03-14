namespace SpecificationPattern.Domain;

public class DeveloperByIncomeAndYearsOfExperienceSpecification : BaseSpecifcation<Developer>
{
    public DeveloperByIncomeAndYearsOfExperienceSpecification(int yearsOfExperience, int estimatedIncome) :
        base(e => e.DeveloperYearsOfExperience <= yearsOfExperience && e.DeveloperEstimatedIncome <= estimatedIncome)
    {
        AddInclude(e => e.Address);
    }
}