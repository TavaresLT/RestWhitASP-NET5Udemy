using RestWhitASPNET5.Historias.Validations;

namespace RestWhitASPNET5.Historias.Calculations
{
    public class CalculateDivision : Validation
    {
        public double Executar(string firstNumber, string secondNumber)
        {
            var validationFirsNumber = ValidationNumber(firstNumber);
            var validationFirsNumber2 = ValidationNumber(secondNumber);
            if (IsValid())
                return validationFirsNumber / validationFirsNumber2;

            return 0;
        }
    }
}
