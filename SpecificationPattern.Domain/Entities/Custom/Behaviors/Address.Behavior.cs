namespace SpecificationPattern.Domain;
public partial class Address : BaseEntity
{
    protected Address() { }
    protected Address(string city, string street)
    {
        AddressCity = (AddressCity)city;
        AddressStreet = (AddressStreet)street;
    }

    public static Address Create(string city, string street)
    {
        if (city.Trim().Equals(string.Empty)) throw new Exception("City can't be empty");
        if (street.Trim().Equals(string.Empty)) throw new Exception("Street can't be empty");

        return new(city, street);
    }
}
