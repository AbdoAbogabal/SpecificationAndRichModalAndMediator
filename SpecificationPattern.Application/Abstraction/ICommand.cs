namespace SpecificationPattern.Application.Abstraction;

public interface ICommand : IRequest
{
}

public interface ICommand<TResponse> : IRequest<TResponse>
{
}

