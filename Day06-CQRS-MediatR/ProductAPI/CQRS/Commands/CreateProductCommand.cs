using MediatR;
using ProductAPI.Models;

namespace ProductAPI.CQRS.Commands;

public record CreateProductCommand(string Name, decimal Price) : IRequest<Product>;