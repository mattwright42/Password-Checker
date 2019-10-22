using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class PasswordChecker
    {
        public static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "!@#$%^&*()-_+=\\/':,{}[]~.";

            Console.WriteLine("Please enter the password");
            string password = Console.ReadLine();

            int score = 0;

            if (password.Length >= minLength)
            {
                score++;
            }
            if (password.Contains(lowercase))
            {
                score++;
            }
            if (password.Contains(uppercase))
            {
                score++;
            }
            if (password.Contains(digits))
            {
                score++;
            }
            if (password.Contains(specialChars))
            {
                score++;
            }

            Console.WriteLine("Your password score is: " + score);

            switch(score)
            {
                case 5:
                    Console.WriteLine("Congratulations! Your password is extrememly strong.");
                    break;
                case 4:
                    Console.WriteLine("Congratualations! Your password is extrememly strong.");
                    break;
                case 3:
                    Console.WriteLine("Congratulations! Your password is strong.");
                    break;
                case 2:
                    Console.WriteLine("Your password is medium.");
                    break;
                case 1:
                    Console.WriteLine("Your password is weak.");
                    break;
                default:
                    Console.WriteLine("Your password does not meet the requirements. Please try again.");
                    break;
            }
        }
    }
}
