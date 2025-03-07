using SpecificationPattern.Domain.DTOS;

namespace SpecificationPattern.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DevelopersController : BaseController<Developer>
{
    private readonly ISender _sender;

    public DevelopersController(ISender sender) : base(sender) => _sender = sender;

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

        var query = new GetWithSpecificationPatternQuery<Developer>(specification);

        var developers = _sender.Send(query);

        return Ok(Envelope.Ok(developers));
    }

    [HttpGet("Pagenation/{take}/{skip}")]
    public async Task<IActionResult> Pagenation(int take = 0, int skip = 0)
    {
        var specification = new DeveloperByPagenationSpecification(take, skip);

        var query = new GetWithSpecificationPatternQuery<Developer>(specification);

        var developers = _sender.Send(query);

        return Ok(Envelope.Ok(developers));
    }
}