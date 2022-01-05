
using System;

namespace email_validation
{
    class Program
    {
        static bool IsValidEmail(string email)
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
        static void Main(string[] args)
        {
            bool isOk = IsValidEmail("islamelshakhs@gmail.com");
            Console.WriteLine(isOk);
        }
    }
}