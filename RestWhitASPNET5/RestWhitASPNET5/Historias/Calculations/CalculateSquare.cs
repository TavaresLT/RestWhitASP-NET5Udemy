using RestWhitASPNET5.Historias.Validations;
using System;

namespace RestWhitASPNET5.Historias.Calculations
{
    public class CalculateSquare : Validation
    {
        public double Executar(string firstNumber, string secondNumber)
        {
            var validationFirsNumber = ValidationNumber(firstNumber);
            var validationSecondNumber = ValidationNumber(secondNumber);
            if (IsValid())
            {
                return Math.Sqrt(validationFirsNumber + validationSecondNumber);
            }
            return 0;
        }
    }
}
