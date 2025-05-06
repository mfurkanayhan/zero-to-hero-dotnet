using MediatR;

namespace ProductAPI.CQRS.Commands;

public record DeleteProductCommand(int Id) : IRequest<bool>;