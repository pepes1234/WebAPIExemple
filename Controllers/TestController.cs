using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    [HttpGet]
    public string QlquerNome()
    {
        return "My App is Working!";
    }
}
