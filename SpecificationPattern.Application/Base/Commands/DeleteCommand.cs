namespace SpecificationPattern.Application.Base.Commands;

public record DeleteCommand<T>(Guid id) : ICommand;
