namespace SpecificationPattern.Application.Commands.DeveloperCommands;

public record UpdateDeveloperCommand(Developer developer) : ICommand { }
