using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{   
    [HttpGet("validate/{cpf}")]
    public object Validate([FromServices]CpfService cpfService, string cpf)
    {
        cpf = cpf.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty)
        .Replace(" ", string.Empty).Replace(",", string.Empty).Replace(";", string.Empty).Replace("=", string.Empty)
        .Replace("|", string.Empty);
        if(cpf.Length > 11)
        {
            return new{
                status = "Fail",
            }
        }
        return new {
            status = cpfService.Validate(cpf),

        };
    }

    [HttpGet("generate")]
    public object Generate([FromServices]CpfService cpfService)
    {
        return cpfService.Generate();
    }
}