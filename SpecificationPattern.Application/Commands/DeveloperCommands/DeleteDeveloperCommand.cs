namespace SpecificationPattern.Application.Commands.DeveloperCommands;

public record DeleteDeveloperCommand(Guid id) : ICommand { }
