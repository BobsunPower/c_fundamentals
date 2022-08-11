using System;

namespace x04.TextFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ban = Console.ReadLine().Split(", ");
            string str = Console.ReadLine();
            foreach (string wrd in ban)
            {while (str.Contains(wrd))
                {str = str.Replace(wrd, new string('*', wrd.Length));}}
            Console.WriteLine(str);
        }
    }
}
