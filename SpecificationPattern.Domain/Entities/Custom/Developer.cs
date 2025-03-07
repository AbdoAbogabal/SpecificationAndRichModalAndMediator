namespace SpecificationPattern.Domain;

public class Developer : BaseEntity
{
    public Address Address { get; set; }
    
    public string Name { get; set; }
    public string Email { get; set; }

    public int YearsOfExperience { get; set; }

    public decimal EstimatedIncome { get; set; }

}