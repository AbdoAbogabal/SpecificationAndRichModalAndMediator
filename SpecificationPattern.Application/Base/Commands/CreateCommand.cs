namespace SpecificationPattern.Application.Base.Commands;

public record CreateCommand<T>(T entity) : ICommand
    where T : BaseEntity;
