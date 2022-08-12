using System;

namespace x08.ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data = Console.ReadLine();
            int lastIdx = data.LastIndexOf("\\");
            int xtenIdx = data.IndexOf('.');
            int lgthFile = xtenIdx - lastIdx - 1;
            string nameFile = data.Substring(lastIdx + 1, lgthFile);
            string xtenIdxName = data.Substring(xtenIdx + 1);
            Console.WriteLine($"File name: {nameFile}\nFile extension: {xtenIdxName}");
        }
    }
}
