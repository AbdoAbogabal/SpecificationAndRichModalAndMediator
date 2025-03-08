namespace SpecificationPattern.Application.Commands.AddressCommands;

public record CreateAddressCommand(Address address) : ICommand { }
