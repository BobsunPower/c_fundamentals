using System;
using System.Linq;

namespace x10.LadyBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] idxBug = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] field = new int[size];
            for (int i = 0; i < field.Length; i++) {
                if (idxBug.Contains(i)) {field[i] = 1;}}
            string cmd;
            while ((cmd = Console.ReadLine()) != "end") {
                string[] data = cmd.Split(' ').ToArray();
                int idxS = (int.Parse(data[0]));
                string dir = data[1];
                int fly = int.Parse(data[2]);
                if (idxS < 0 || idxS >= field.Length) {continue;}
                if (field[idxS] == 0) {continue;}
                field[idxS] = 0; int idxNext = idxS;
                while (true)
                {if (dir == "right") {idxNext += fly;}
                    else if (dir == "left") {idxNext -= fly;}
                    if (idxNext < 0 || idxNext >= field.Length) {break;}
                    if (field[idxNext] == 0) {break;}}
                if (idxNext >= 0 && idxNext < field.Length) {field[idxNext] = 1;}}
            Console.WriteLine(String.Join(' ', field));
        }
    }
}
