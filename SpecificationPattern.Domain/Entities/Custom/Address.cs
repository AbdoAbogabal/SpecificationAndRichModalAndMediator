namespace SpecificationPattern.Domain;
public partial class Address : BaseEntity
{
    private string _city;
    public AddressCity AddressCity { get => (AddressCity)_city; set => _city = value; }


    private string _street;
    public AddressStreet AddressStreet { get => (AddressStreet)_street; set => _street = value; }
}