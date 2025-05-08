using Microsoft.AspNetCore.Mvc;
using ProductAPI.Common;
using ProductAPI.Models;

namespace ProductAPI.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class ProductsController : ControllerBase
{
    private static readonly List<Product> _products = new();

    [HttpGet]
    public IActionResult GetAll()
    {
        return Ok(Result<List<Product>>.Ok(_products));
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
        return Ok(Result<Product>.Ok(product));
    }

    [HttpPost]
    public IActionResult Update(Product updated)
    {
        var product = _products.FirstOrDefault(p => p.Id == updated.Id);
        if (product == null)
            return NotFound(Result<string>.Fail("Product not found"));

        product.Name = updated.Name;
        product.Price = updated.Price;
        return Ok(Result<Product>.Ok(product));
    }

    [HttpPost]
    public IActionResult Delete(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
            return NotFound(Result<string>.Fail("Product not found"));

        _products.Remove(product);
        return Ok(Result<string>.Ok("Product deleted"));
    }
}
