using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SecureController : ControllerBase
{
    [HttpGet("public")]
    public IActionResult Public() => Ok("This endpoint is accessible by anyone.");

    [Authorize]
    [HttpGet("authenticated")]
    public IActionResult Authenticated() =>
        Ok($"Welcome, {User.Identity?.Name}. This endpoint is only for authenticated users.");

    [Authorize(Roles = "Admin")]
    [HttpGet("admin")]
    public IActionResult AdminOnly() =>
        Ok("Only users with the Admin role can access this endpoint.");
}
