namespace SpecificationPattern.Domain;

public partial class Developer : BaseEntity
{
    protected Developer() { }
    protected Developer(string name, string email, int yearsOfExperience, decimal estimatedIncome, Address address)
    {
        Address = address;

        DeveloperName = (DeveloperName)name;
        DeveloperEmail = (DeveloperEmail)email;
        DeveloperEstimatedIncome = (DeveloperEstimatedIncome)estimatedIncome;
        DeveloperYearsOfExperience = (DeveloperYearsOfExperience)yearsOfExperience;
    }

    public static Developer Create(string name, string email, int yearsOfExperience, decimal estimatedIncome, Address address)
    {
        if (name.Trim().Equals(string.Empty)) throw new Exception("name can't be empty");
        if (email.Trim().Equals(string.Empty)) throw new Exception("email can't be empty");

        if (estimatedIncome <= 0) throw new Exception("estimated Income can't be less than or equal to 0");
        if (yearsOfExperience <= 0) throw new Exception("years Of Experience can't be less than or equal to 0");

        if (address is null) throw new ArgumentNullException(nameof(address));

        return new(name, email, yearsOfExperience, estimatedIncome, address);
    }
}