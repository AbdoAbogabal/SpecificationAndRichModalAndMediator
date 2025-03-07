namespace SpecificationPattern.Application.Abstraction;

public interface IQuery<TResponse> : IRequest<Result<TResponse>>
{
}
