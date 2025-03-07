namespace SpecificationPattern.Domain;

public class DeveloperByPagenationSpecification : BaseSpecifcation<Developer>
{
    public DeveloperByPagenationSpecification(int take, int skip)
    {
        AddPagination(take, skip);
    }
}