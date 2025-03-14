namespace SpecificationPattern.Domain;

public partial class Developer : BaseEntity
{
    public Address Address { get; set; }

    private string _name;
    public DeveloperName DeveloperName { get => (DeveloperName)_name; set => _name = value; }

    private string _email;
    public DeveloperEmail DeveloperEmail { get => (DeveloperEmail)_email; set => _email = value; }

    private int _yearsOfExperience;
    public DeveloperYearsOfExperience DeveloperYearsOfExperience { get => (DeveloperYearsOfExperience)_yearsOfExperience; set => _yearsOfExperience = value; }

    private decimal _estimatedIncome;
    public DeveloperEstimatedIncome DeveloperEstimatedIncome { get => (DeveloperEstimatedIncome)_estimatedIncome; set => _estimatedIncome = value; }
}