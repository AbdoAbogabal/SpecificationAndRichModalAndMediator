namespace SpecificationPattern.Application.Commands.AddressCommands;

public record DeleteAddressCommand(Guid id) : ICommand { }
