using CpfValidation.Domain;
using CpfValidation.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CpfValidation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CpfController : ControllerBase
    {
        private readonly ICpfInterface _cpfInterface;
        public CpfController(ICpfInterface cpf)
        {
            _cpfInterface = cpf;
        }

        [HttpPost]
        public IActionResult ValidateCPF([FromBody] string cpf)
        {
            var validateCPF = _cpfInterface.ValidateCPF(cpf);

            if (!validateCPF)
            {
                return BadRequest("CPF inválido");
            }

            return Ok("CPF válido");
        }
    }
}
