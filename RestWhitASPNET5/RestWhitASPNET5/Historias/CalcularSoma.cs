using System.Collections.Generic;

namespace RestWhitASPNET5.Historias
{
    public class CalcularSoma
    {
        public Dictionary<string, string> Erros { get; set; }

        public CalcularSoma()
        {
            Erros = new Dictionary<string, string>();
        }

        public decimal Executar(string firstNumber, string secondNumber) 
        {
            if (IsNumeric(firstNumber) && IsNumeric(secondNumber)) 
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNumber);
                return sum;
            }
            return 0;
        }

        private bool IsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            if (isNumber is false) 
            {
                Erros.Add("a", "The value is not a number");
            }
            return isNumber;
        }
        private decimal ConvertToDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            Erros.Add("b", "Value add is invalid");
            return 0;
        }
    }
}
