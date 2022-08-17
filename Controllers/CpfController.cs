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

        
        long cpflong;
        if(long.TryParse(cpf, out cpflong) == false)
        {
            return new{
                status = "Fail",
                message = "Cpf não pode conter caracteres especiais ou letras."
            };
        }
        if(cpf.Length < 11)
        {
            return new{
                status = "Fail",
                message = "Cpf com quantidade de digitos insuficientes"
            };
        }

        if(cpf.Length > 11)
        {
            return new{
                status = "Fail",
                message = "Cpf com quantidade de digitos excedentes"
            };
        }

        
        if(cpfService.Validate(cpf) == true)
        {
            return new {
                status = "Sucess",
                message = "Cpf Valido"
            };  
        }

        if(cpfService.Validate(cpf) == false)
        {
            return new {
                status = "Fail",
                message = "Cpf Invalido"
            };  
        }

        return new {
            status = "fail"
        };
        
    }

    [HttpGet("generate")]
    public object Generate([FromServices]CpfService cpfService)
    {
        return cpfService.Generate();
    }
}