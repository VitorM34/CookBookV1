using Microsoft.AspNetCore.Mvc;
using MyRecipeBook.Communication.Requests;

namespace MyRecipeBook.API.Controllers;

[Route("[controller]")]
[ApiController]

public class UserController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType( typeof(ResponserRegisterUserJson),StatusCodes.Status201Created)]
    public IActionResult Register(RequestRegisterUserJson request)
    {
        return Created();
    }
}