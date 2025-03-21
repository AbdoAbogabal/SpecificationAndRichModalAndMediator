﻿namespace SpecificationPattern.Application.Handlers.QueryHandlers.DeveloperQueryHandlers;

public class GetAllDeveloperHandler : IQueryHandler<GetAllDevelopersQuery, List<Developer>>
{
    private readonly IGenericRepository<Developer> _repository;

    public GetAllDeveloperHandler(IGenericRepository<Developer> repository) => _repository = repository;
    public async Task<List<Developer>> Handle(GetAllDevelopersQuery request, CancellationToken cancellationToken)
    {
        var developers = await _repository.GetAllAsync();

        return developers;
    }
}
