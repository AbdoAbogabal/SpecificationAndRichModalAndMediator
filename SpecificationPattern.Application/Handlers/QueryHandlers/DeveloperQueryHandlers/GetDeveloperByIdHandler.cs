namespace SpecificationPattern.Application.Handlers.QueryHandlers.DeveloperQueryHandlers;

public class GetDeveloperByIdHandler : IQueryHandler<GetDeveloperByIdQuery, Developer>
{
    private readonly IGenericRepository<Developer> _repository;

    public GetDeveloperByIdHandler(IGenericRepository<Developer> repository) => _repository = repository;

    public async Task<Developer> Handle(GetDeveloperByIdQuery request, CancellationToken cancellationToken)
    {
        var developer = await _repository.GetByIdAsync(request.id);

        return developer;
    }
}
