namespace SpecificationPattern.Application.Base.Commands;

public record UpdateCommand<T>(T entity) : ICommand
    where T : BaseEntity;
