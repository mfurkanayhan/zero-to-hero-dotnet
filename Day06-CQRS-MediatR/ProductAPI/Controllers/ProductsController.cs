using MediatR;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.CQRS.Commands;
using ProductAPI.CQRS.Queries;
using ProductAPI.Models;

namespace ProductAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class ProductsController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProductsController(IMediator mediator)
    {
        _mediator = mediator;        
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetAll()
    {
        var products = await _mediator.Send(new GetAllProductsQuery());
        return Ok(products);
    }

    [HttpPost]
    public async Task<ActionResult<Product>> Create([FromBody] CreateProductCommand command)
    {
        var createdProduct = await _mediator.Send(command);
        return CreatedAtAction(nameof(GetAll), new { id = createdProduct.Id }, createdProduct);
    }

    [HttpPost("update")]
    public async Task<ActionResult<Product>> Update([FromBody] UpdateProductCommand command)
    {
        var updatedProduct = await _mediator.Send(command);

        if (updatedProduct == null)
            return NotFound("Product not found.");

        return Ok(updatedProduct);
    }

    [HttpPost("delete")]
    public async Task<IActionResult> Delete([FromBody] DeleteProductCommand command)
    {
        var deleted = await _mediator.Send(command);

        if (!deleted)
            return NotFound("Product to delete not found.");

        return NoContent();
    }
}
