using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Booking_Management_System.UserControls
{
    public static class UtilityHelper
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidPhoneNumber(string phoneNumber)
        {
            return phoneNumber.Length == 11 && phoneNumber.StartsWith("09") && phoneNumber.All(char.IsDigit);
        }

        public static bool IsNumeric(string str)
        {
            double number;
            bool isNumber = double.TryParse(str, out number);
            return isNumber;
        }
    }
}
