using RestWhitASPNET5.Historias.Validations;

namespace RestWhitASPNET5.Historias.Calculations
{
    public class CalculateSum : Validation
    {
        public CalculateSum()
        {
        }

        public double Executar(string firstNumber, string secondNumber)
        {
            var validationFirstNumber = ValidationNumber(firstNumber);
            var validationSecondNumber = ValidationNumber(secondNumber);
            if (IsValid())
                return validationFirstNumber + validationSecondNumber;

            return 0;
        }
    }
}
