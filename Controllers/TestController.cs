using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("test/")]
public class TestController : ControllerBase
{
    [HttpGet]
    //rota, metodo, head, body são os 4 cavalero do apocalpse
    public string QlquerNome()
    {
        return "My App is Working!";
    }
    [HttpGet("quadratica/{x}")]
    public string Get(int x, int a = 1, int b = 0, int c = 0)
    {
        int resultado = (a * x * x + b * x + c);
        return resultado.ToString();
    }
}
