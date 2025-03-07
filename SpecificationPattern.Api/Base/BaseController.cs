namespace SpecificationPattern.Api.Base;

[Route("api/[controller]")]
[ApiController]
public class BaseController<T> : ControllerBase
    where T : BaseEntity
{
    private readonly ISender _sender;

    public BaseController(ISender sender) => _sender = sender;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllQuery<T>();

        var result = await _sender.Send(query);

        if (result.IsSuccess)
            return Ok(Envelope.Ok(result));

        else return BadRequest(Envelope.Error(result.Error));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetByIdQuery<T>(id);

        var developer = await _sender.Send(query);

        return Ok(Envelope.Ok(developer));
    }

    [HttpPost]
    public async Task<IActionResult> Add(T entity)
    {
        var command = new CreateCommand<T>(entity);

        return Ok(Envelope.Ok(await _sender.Send(command)));
    }

    [HttpPut]
    public async Task<IActionResult> Edit(T entity)
    {
        var command = new UpdateCommand<T>(entity);

        return Ok(Envelope.Ok(await _sender.Send(command)));
    }
}
