using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace PasswordGeneratorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGeneratePassword_Click(object sender, EventArgs e)
        {
            // Setup password elements based on specifications
            string registrationNumberDigits = "17";
            char firstNameSecondLetter = 'i';
            char lastNameSecondLetter = 'h';
            string movieChars = "AB";

            string specialChars = "@$%^&*()!";
            Random random = new Random();
            StringBuilder password = new StringBuilder();

            // Append required elements
            password.Append(registrationNumberDigits);
            password.Append(firstNameSecondLetter);
            password.Append(lastNameSecondLetter);
            password.Append(movieChars);

            // Add special characters, excluding '#'
            for (int i = 0; i < 4; i++)
            {
                char specialChar;
                do
                {
                    specialChar = specialChars[random.Next(specialChars.Length)];
                } while (specialChar == '#');
                password.Append(specialChar);
            }

            // Fill to reach 14 characters length
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            while (password.Length < 14)
            {
                password.Append(alphabet[random.Next(alphabet.Length)]);
            }

            // Shuffle the generated password
            string finalPassword = ShuffleString(password.ToString());

            // Validate the final password
            string pattern = @"^(?=.{14}$)(?=.*[^\w#])"; // Length 14 with special character
            if (Regex.IsMatch(finalPassword, pattern))
            {
                txtPasswordOutput.Text = "Generated Password: " + finalPassword;
            }
            else
            {
                txtPasswordOutput.Text = "Password does not meet all specifications. Try again.";
            }
        }

        private string ShuffleString(string input)
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
