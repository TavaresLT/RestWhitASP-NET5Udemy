using prmToolkit.NotificationPattern;
using System.Linq;

namespace RestWhitASPNET5.Historias.Validations
{
    public class Validation : Notifiable
    {
        public Validation()
        {
        }

        public double ValidationNumber(string number)
        {

            if (VerifyIfIsNumeric(number) is false)
                return 0;

            var value = ConvertToDecimal(number);
            if (IsInvalid())
                return 0;

            return value;
        }

        private bool VerifyIfIsNumeric(string strNumber)
        {
            double number;
            bool isNumber = double.TryParse(strNumber,
                System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo,
                out number);
            if (isNumber is false)
                AddNotification("invalid-number", "The number add is invalid");

            return isNumber;
        }

        private double ConvertToDecimal(string strNumber)
        {
            double decimalValue;
            if (double.TryParse(strNumber, out decimalValue))
                return decimalValue;


            AddNotification("invalid-value", "Value add is invalid");
            return 0;
        }
    }
}
