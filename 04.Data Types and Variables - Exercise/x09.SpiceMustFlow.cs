using System;

namespace x09.SpiceMustFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int spice = int.Parse(Console.ReadLine()); int days = 0; int tot = 0;
            while (spice >= 100) {days++; tot += spice - 26; spice -= 10;}
            if (tot > 26) {tot -= 26;}
            else {tot -= tot;}
            Console.WriteLine($"{days}\n{tot}");
        }
    }
}
