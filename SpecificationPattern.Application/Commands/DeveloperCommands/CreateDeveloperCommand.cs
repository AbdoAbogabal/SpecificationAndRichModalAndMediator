namespace SpecificationPattern.Application.Commands.DeveloperCommands;

public record CreateDeveloperCommand(Developer developer) : ICommand { }
