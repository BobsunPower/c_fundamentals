using System;
using System.Text;

namespace x05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            StringBuilder dgt = new StringBuilder();
            StringBuilder ltr = new StringBuilder();
            StringBuilder dif = new StringBuilder();
            foreach (char ch in str) {
                if (char.IsDigit(ch)) {dgt.Append(ch);}
                else if (char.IsLetter(ch)) {ltr.Append(ch);}
                else if (!char.IsLetterOrDigit(ch)) {dif.Append(ch);}}
            Console.WriteLine($"{dgt}\n{ltr}\n{dif}");
        }
    }
}
