namespace SpecificationPattern.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AddressesController : ControllerBase
{
    private readonly ISender _sender;

    public AddressesController(ISender sender) => _sender = sender;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllAddressesQuery();

        var result = await _sender.Send(query);

        return Ok(Envelope.Ok(result));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetAddressByIdQuery(id);

        var address = await _sender.Send(query);

        return Ok(Envelope.Ok(address));
    }

    [HttpPost]
    public async Task<IActionResult> Add(Address entity)
    {
        var command = new CreateAddressCommand(entity);

        await _sender.Send(command);

        return Ok(Envelope.Ok("Added"));
    }

    [HttpPut]
    public async Task<IActionResult> Edit(Address entity)
    {
        var command = new UpdateAddressCommand(entity);

        await _sender.Send(command);

        return Ok(Envelope.Ok("Edited"));
    }
}
