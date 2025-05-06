using MediatR;
using ProductAPI.Models;

namespace ProductAPI.CQRS.Commands;

public record UpdateProductCommand(int Id, string Name, decimal Price) : IRequest<Product>;