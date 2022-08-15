using System;

namespace x08.LettersChangeNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            decimal sum = 0;
            foreach (string word in words) {
                int fst = GetAlphabeticalPosition(word[0]);
                int lst = GetAlphabeticalPosition(word[word.Length - 1]);
                decimal n = GetNumberFromString(word);
                if (char.IsUpper(word[0]))
                {n /= fst;}
                else if (char.IsLower(word[0]))
                {n *= fst;}
                if (char.IsUpper(word[word.Length - 1]))
                {n -= lst;}
                else if (char.IsLower(word[word.Length - 1]))
                {n += lst;}
                sum += n;}
            Console.WriteLine($"{sum:f2}");}
        static int GetNumberFromString(string wrd)
        {
            int res;
            wrd = wrd.Substring(1, wrd.Length - 2);
            return res = int.Parse(wrd);
        }
        static int GetAlphabeticalPosition(char ch)
        {
            return char.ToLower(ch) - 96;
        }
    }
}
