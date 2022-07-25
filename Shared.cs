using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace TechnicalService
{
    public class Shared
    {
        public static string user_id { get; set; }

        public static void showMessage(string result)
        {
            if (result.Contains("!") == true)
            {
                MessageBox.Show(result);
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        public static bool EmailChecker(string email)
        {
            const string emailRegex = @"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                                    @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                                    @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$";
            return (new Regex(emailRegex)).IsMatch(email);
        }

        public static bool PhoneNumberChecker(string number)
        {
            const string phoneRegex = @"^(0(\d{3})(\d{3})(\d{2})(\d{2}))$";
            return (new Regex(phoneRegex)).IsMatch(number);
        }
    }
}
