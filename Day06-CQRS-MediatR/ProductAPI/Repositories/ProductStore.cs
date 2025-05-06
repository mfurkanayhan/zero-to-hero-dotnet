using ProductAPI.Models;

namespace ProductAPI.Repositories;

public class ProductStore
{
    private static readonly List<Product> _products = new()
    {
        new Product { Id = 1, Name = "Samsung", Price = 35000 },
        new Product { Id = 2, Name = "iPhone", Price = 60000 }
    };

    public static List<Product> Products => _products;
}