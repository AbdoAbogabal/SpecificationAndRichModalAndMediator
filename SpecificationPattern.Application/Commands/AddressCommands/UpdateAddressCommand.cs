namespace SpecificationPattern.Application.Commands.AddressCommands;

public record UpdateAddressCommand(Address address) : ICommand { }
