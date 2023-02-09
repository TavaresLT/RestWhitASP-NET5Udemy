using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWhitASPNET5.Historias;
using System;
using System.Collections;
using System.Linq;

namespace RestWhitASPNET5.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : Controller
    {
        private readonly ILogger<CalculatorController> _logger;
        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber, [FromServices] CalcularSoma calcularSoma)
        {
            var resultado = calcularSoma.Executar(firstNumber, secondNumber);
            if (calcularSoma.Erros.Any()) 
            {
                return BadRequest("Invalid Input");                
            }
            return Ok(resultado.ToString());
        }

        //[HttpGet("subtration/{firstNumber}/{secondnumber}")]
        //public IActionResult Subtration(string firstNumber, string secondNumber, [FromServices] CalcularSubtracao calcularSubtracao) 
        //{
        //    var resultado = calcularSubtracao.Executar(firstNumber, secondNumber);
        //    if (resultado is null) 
        //    {
        //        return NotFound();
        //    }
        //    return NotFound()
        //}
    }
}
