using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("cpf/")]
public class CpfController : ControllerBase
{
    [HttpGet("validate/{cpf}")]
    public object Validate([FromServices]CpfService cpfService, string cpf)
    {
        return cpfService.getValidationDigits(cpf);
    }

    [HttpGet("generate")]
    public object Generate([FromServices]CpfService cpfService
    )
    {
        throw new NotImplementedException();
    }
}