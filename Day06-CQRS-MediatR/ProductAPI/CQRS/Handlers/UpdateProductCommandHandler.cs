using MediatR;
using ProductAPI.CQRS.Commands;
using ProductAPI.Models;
using ProductAPI.Repositories;

namespace ProductAPI.CQRS.Handlers;

public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommand, Product>
{

    public Task<Product> Handle(UpdateProductCommand request, CancellationToken cancellationToken)
    {
        var product = ProductStore.Products.FirstOrDefault(p=> p.Id == request.Id);
        if (product == null)
            return Task.FromResult<Product>(null!);

        product.Name = request.Name;
        product.Price = request.Price;

        return Task.FromResult(product);
    }
}
