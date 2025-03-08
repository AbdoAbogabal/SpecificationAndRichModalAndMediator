using SpecificationPattern.Domain.DTOS;

namespace SpecificationPattern.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DevelopersController : ControllerBase
{
    private readonly ISender _sender;

    public DevelopersController(ISender sender) => _sender = sender;

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllDevelopersQuery();

        var result = await _sender.Send(query);

        return Ok(Envelope.Ok(result));
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var query = new GetDeveloperByIdQuery(id);

        var developer = await _sender.Send(query);

        return Ok(Envelope.Ok(developer));
    }

    [HttpPost]
    public async Task<IActionResult> Add(Developer entity)
    {
        var command = new CreateDeveloperCommand(entity);

        await _sender.Send(command);

        return Ok(Envelope.Ok("Added"));
    }

    [HttpPut]
    public async Task<IActionResult> Edit(Developer entity)
    {
        var command = new UpdateDeveloperCommand(entity);

        await _sender.Send(command);

        return Ok(Envelope.Ok("Edited"));
    }


    [HttpGet("specify/{yearsOfExperience}/{estimatedIncome}")]
    public async Task<IActionResult> Specify(int yearsOfExperience, int estimatedIncome)
    {
        Pagination pagination = new() { Take = 1, Skip = 1 };
        OrderBySpecification<Developer> orderBySpecification = new() { IsAsending = true, OrderBy = (e) => e.Name };

        var specification = new BaseSpecifcation<Developer>(
            pagination: pagination,
            criteria: e => e.YearsOfExperience <= yearsOfExperience && e.EstimatedIncome <= estimatedIncome,
            orderBySpecification: orderBySpecification,
            includeExpression: [(e) => e.Address]
            );
        //var specification = new DeveloperByIncomeAndYearsOfExperienceSpecification(yearsOfExperience, estimatedIncome);

        var query = new GetDevelopersBySpeceficationQuery(specification);

        var developers = _sender.Send(query);

        return Ok(Envelope.Ok(developers));
    }

    [HttpGet("Pagenation/{take}/{skip}")]
    public async Task<IActionResult> Pagenation(int take = 0, int skip = 0)
    {
        Pagination pagination = new() { Take = take, Skip = skip };

        var specification = new BaseSpecifcation<Developer>(
                   pagination: pagination,
                   criteria: null,
                   orderBySpecification: null,
                   includeExpression: [(e) => e.Address]);

        var query = new GetDevelopersBySpeceficationQuery(specification);

        var developers = _sender.Send(query);

        return Ok(Envelope.Ok(developers));
    }
}