using MediatR;
using ProductAPI.CQRS.Commands;
using ProductAPI.Repositories;

namespace ProductAPI.CQRS.Handlers;

public class DeleteProductCommandHandler : IRequestHandler<DeleteProductCommand, bool>
{
    public Task<bool> Handle(DeleteProductCommand request, CancellationToken cancellationToken)
    {
        var product = ProductStore.Products.FirstOrDefault(p => p.Id == request.Id);
        if (product == null)
            return Task.FromResult(false);

        ProductStore.Products.Remove(product);
        return Task.FromResult(true);
    }
}
