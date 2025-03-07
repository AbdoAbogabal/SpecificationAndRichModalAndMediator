namespace SpecificationPattern.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressesController : BaseController<Address>
{
    public AddressesController(ISender sender) : base(sender) { }
}
