using System;

namespace x04.PasswordValidator
{
    internal class Program
    {       

        static bool PasswordValidator(string pwd, int min, int max)
        {
            bool vld = true;
            if (!LengthValidator(pwd, min, max)) {Console.WriteLine($"Password must be between {min} and {max} characters"); vld = false;}
            if (!LetterDigitValidator(pwd)) {Console.WriteLine($"Password must consist only of letters and digits");vld = false;}
            if (!DigitValidator(pwd)) {Console.WriteLine("Password must have at least 2 digits"); vld = false;}
            return vld;
        }

        static bool LengthValidator(string pwd, int min, int max)
        {

            if (pwd.Length >= min && pwd.Length <= max) {return true;}
            return false;
        }

        static bool LetterDigitValidator(string pwd)
        {
            foreach (char ch in pwd)
            {if (!char.IsLetterOrDigit(ch)) {return false;}}
            return true;
        }

        static bool DigitValidator(string password)
        {
            int dgt = 0;
            foreach (char ch in password)
            {if (char.IsDigit(ch)) {dgt++;}}
            if (dgt >= 2) {return true;}
            return false;
        }
        static void Main(string[] args)
        {
            string pwd = Console.ReadLine();
            const int min = 6;
            const int max = 10;
            bool vld = PasswordValidator(pwd, min, max);
            if (vld) { Console.WriteLine("Password is valid"); }
        }
    }
}
