using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Example1
{
    public class Email
    {
        public string Value { get; }

        public Email(string email)
        {
            if (email is null)
            {
                throw new ArgumentNullException(nameof(email));
            }

            if (!IsValidEmailAddress(email))
            {
                throw new ArgumentException("Invalid email address", nameof(email));
            }

            Value = email;
        }

        public static bool IsValidEmailAddress(string email)
        {
            var regex = new Regex(@"[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?");
            return regex.IsMatch(email);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            var email = new Example1.Email("@gmail.com");
            string domain = GetDomains(email);
            Console.WriteLine(domain);  // Output: example.com
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    public static string GetDomains(Example1.Email email) => email.Value.Split('@').LastOrDefault();
}

