using MediatR;
using ProductAPI.Models;

namespace ProductAPI.CQRS.Queries;

public record GetAllProductsQuery() : IRequest<List<Product>>;
