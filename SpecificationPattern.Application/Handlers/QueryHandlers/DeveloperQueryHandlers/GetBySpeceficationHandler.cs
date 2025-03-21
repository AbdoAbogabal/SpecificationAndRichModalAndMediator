﻿namespace SpecificationPattern.Application.Handlers.QueryHandlers.DeveloperQueryHandlers;

public class GetBySpeceficationHandler : IQueryHandler<GetDevelopersBySpeceficationQuery, IEnumerable<Developer>>
{
    private readonly IGenericRepository<Developer> _repository;

    public GetBySpeceficationHandler(IGenericRepository<Developer> repository) => _repository = repository;
    public async Task<IEnumerable<Developer>> Handle(GetDevelopersBySpeceficationQuery request, CancellationToken cancellationToken)
    {
        var developers = _repository.FindWithSpecificationPattern(request.specification);

        return developers;
    }
}
