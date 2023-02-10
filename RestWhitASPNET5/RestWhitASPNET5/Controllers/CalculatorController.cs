using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWhitASPNET5.Historias.Calculations;
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

        [HttpGet("Sum/{firstNumber}/{secondNumber}")]
        public IActionResult Sum(string firstNumber, string secondNumber, [FromServices] CalculateSum calculateSum)
        {
            var result = calculateSum.Executar(firstNumber, secondNumber);
            if (calculateSum.IsInvalid())
                return BadRequest(calculateSum.Notifications.FirstOrDefault().Message);                

            return Ok(result.ToString());
        }

        [HttpGet("subtraction/{firstNumber}/{secondNumber}")]
        public IActionResult Subctration(string firstNumber, string secondNumber, [FromServices] CalculateSubtraction calculateSubtraction)
        {
            var result = calculateSubtraction.Executar(firstNumber, secondNumber);
            if (calculateSubtraction.IsInvalid())
                return BadRequest(calculateSubtraction.Notifications.FirstOrDefault().Message);

            return Ok(result.ToString());
        }

        [HttpGet("Multipli/{firstNumber}/{secondNumber}")]
        public IActionResult Multiplication(string firstNumber, string secondNumber, [FromServices] CalculateMultiplication calculatesMultiplication) 
        {
            var result = calculatesMultiplication.Executar(firstNumber, secondNumber);
            if (calculatesMultiplication.IsInvalid())
                return BadRequest(calculatesMultiplication.Notifications.FirstOrDefault().Message);

            return Ok(result.ToString());
        }

        [HttpGet("division/{firstNumber}/{secondNumber}")]
        public IActionResult division(string firstNumber, string secondNumber, [FromServices] CalculateDivision calculateDivision) 
        {
            var result = calculateDivision.Executar(firstNumber, secondNumber);
            if (calculateDivision.IsInvalid())
                return BadRequest(calculateDivision.Notifications.FirstOrDefault().Message);

            return Ok(result.ToString());
        }

        [HttpGet("mean/{firstNumber}/{secondNumber}")]
        public IActionResult Mean(string firstNumber, string secondNumber, [FromServices] CalculateMean calculateMean)
        {
            var result = calculateMean.Executar(firstNumber, secondNumber);
            if (calculateMean.IsInvalid())
                return BadRequest(calculateMean.Notifications.FirstOrDefault().Message);

            return Ok(result.ToString());
        }

        [HttpGet("square/{firstNumber}/{secondNumber}")]
        public IActionResult Square(string firstNumber, string secondNumber, [FromServices] CalculateSquare calculateSquare)
        {
            var result = calculateSquare.Executar(firstNumber, secondNumber);
            if (calculateSquare.IsInvalid())
                return BadRequest(calculateSquare.Notifications.FirstOrDefault().Message);

            return Ok(result.ToString());
        }
    }
}
