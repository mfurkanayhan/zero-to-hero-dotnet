using MediatR;
using ProductAPI.CQRS.Queries;
using ProductAPI.Models;
using ProductAPI.Repositories;

namespace ProductAPI.CQRS.Handlers;

public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, List<Product>>
{
    public Task<List<Product>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
    {
        var products = ProductStore.Products;
        return Task.FromResult(products);
    }
}
