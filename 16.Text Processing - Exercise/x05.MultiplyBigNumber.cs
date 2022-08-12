using System;

namespace x05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int mltplr = int.Parse(Console.ReadLine());
            string res = "";
            if (mltplr == 0)
            {Console.WriteLine(0);}
            int rmndr = 0;
            for (int i = data.Length - 1; i >= 0; i--)
            {int n = data[i] - '0';
                int mltpld = mltplr * n;
                if (rmndr != 0)
                {mltpld += rmndr; rmndr = 0;}
                int cnt = mltpld;
                if (mltpld > 9)
                {cnt = mltpld % 10; rmndr = mltpld / 10;}
                res += cnt.ToString();}
            if (rmndr != 0)
            {res += rmndr;}
            char[] rev = res.ToCharArray();
            Array.Reverse(rev);
            if (mltplr != 0)
            {Console.WriteLine(rev);}
        }
    }
}
