using System;
using System.Text;

namespace PasswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 12; // Length of the password
            Console.WriteLine("Generated Password: " + GeneratePassword(length));

            Console.ReadLine();
        }

        static string GeneratePassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            StringBuilder password = new StringBuilder();
            Random random = new Random();

            // Ensure minimum length is 10 characters
            length = Math.Max(length, 50);

            // Generate random characters for the password
            for (int i = 0; i < length; i++)
            {
                int index = random.Next(validChars.Length);
                password.Append(validChars[index]);
            }

            return password.ToString();
        }
    }
}
