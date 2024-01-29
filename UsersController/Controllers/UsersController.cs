using Microsoft.AspNetCore.Mvc;
namespace UsersController.Controllers;

[ApiController]
[Route("/api/[controller]")]
public class UsersController : ControllerBase
{
    private static readonly List<string> Users =
    [
        "Stefan",
        "Dajana",
        "Milan"
    ];

    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetUsers")]
    public List<string> Get()
    {
        return Users;
    }
}