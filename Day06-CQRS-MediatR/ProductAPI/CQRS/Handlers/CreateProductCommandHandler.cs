using MediatR;
using ProductAPI.CQRS.Commands;
using ProductAPI.Models;
using ProductAPI.Repositories;

namespace ProductAPI.CQRS.Handlers;

public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, Product>
{
    public Task<Product> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var newProduct = new Product
        {
            Id = ProductStore.Products.Count + 1,
            Name = request.Name,
            Price = request.Price
        };

        ProductStore.Products.Add(newProduct);
        return Task.FromResult(newProduct);
    }
}
