using RestWhitASPNET5.Historias.Validations;

namespace RestWhitASPNET5.Historias.Calculations
{
    public class CalculateMean : Validation
    {
        public double Executar(string firstNumber, string secondNumber) 
        {
            var validationFirstNumber = ValidationNumber(firstNumber);
            var validationSecondNumber = ValidationNumber(secondNumber);
            if (IsValid())
                return (validationFirstNumber + validationSecondNumber) / 2;

            return 0;
        }
    }
}
