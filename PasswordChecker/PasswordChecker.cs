using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordChecker
{
    class PasswordChecker
    {
        public static bool Contains(string target, string list)
		{
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

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
            if (Contains(password,lowercase))
            {
                score++;
            }
            if (Contains(password,uppercase))
            {
                score++;
            }
            if (Contains(password,digits))
            {
                score++;
            }
            if (Contains(password,specialChars))
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
                    Console.WriteLine("Congratualations! Your password is extremely strong.");
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
