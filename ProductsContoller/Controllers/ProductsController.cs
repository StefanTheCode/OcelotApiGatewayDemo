using Microsoft.AspNetCore.Mvc;

namespace ProductsContoller.Controllers;
[ApiController]
[Route("/api/[controller]")]
public class ProductsController : ControllerBase
{
    private static readonly List<string> Products =
    [
        "Apple",
        "Milk",
        "Juice"
    ];

    private readonly ILogger<ProductsController> _logger;

    public ProductsController(ILogger<ProductsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetProducts")]
    public List<string> Get()
    {
        return Products;
    }
}