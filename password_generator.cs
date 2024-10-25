using System;
using System.Text;
using System.Text.RegularExpressions;

namespace PasswordGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string registrationNumberDigits = "17"; 
            char firstNameSecondLetter = 'i';
            char lastNameSecondLetter = 'h'; 
            string movieChars = "AB"; 
            

            string specialChars = "@$%^&*()!";
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            password.Append(registrationNumberDigits);

            password.Append(firstNameSecondLetter);
            password.Append(lastNameSecondLetter);

            password.Append(movieChars);

            for (int i = 0; i < 4; i++)
            {
                char specialChar;
                do
                {
                    specialChar = specialChars[random.Next(specialChars.Length)];
                } while (specialChar == '#');
                password.Append(specialChar);
            }



            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (password.Length < 14)
            {
                password.Append(alphabet[random.Next(alphabet.Length)]);
            }

            string finalPassword = ShuffleString(password.ToString());
            
            string pattern = @"^(?=.{14}$)(?=.*[^\w#])"; 
            
            if (Regex.IsMatch(finalPassword, pattern))
            {
                Console.WriteLine("Generated Password: " + finalPassword);
            }
            else
            {
                Console.WriteLine("Password does not meet all specifications. Please try again.");
            }
        }

        static string ShuffleString(string input)
        {
            char[] array = input.ToCharArray();
            Random random = new Random();
            for (int i = array.Length - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                (array[i], array[j]) = (array[j], array[i]);
            }
            return new string(array);
        }
    }
}
