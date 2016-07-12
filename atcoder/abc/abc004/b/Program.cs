using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] map = new string[4];
            for (int i = 0; i < 4; i++)
            {
                map[i] = Console.ReadLine();
            }
            for (int i = 4 - 1; i >= 0; i--)
            {
                for (int j = map[i].Length - 1; j >= 0; j--)
                {
                    Console.Write(map[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
