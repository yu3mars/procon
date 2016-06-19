using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int cnt = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if(s.Substring(i,7)== "WBWBWBW")
                {
                    cnt = i;
                    break;
                }
            }
            switch (cnt)
            {
                case 5:
                    Console.WriteLine("Do");
                    break;
                case 3:
                    Console.WriteLine("Re");
                    break;
                case 1:
                    Console.WriteLine("Mi");
                    break;
                case 0:
                    Console.WriteLine("Fa");
                    break;
                case 10:
                    Console.WriteLine("So");
                    break;
                case 8:
                    Console.WriteLine("La");
                    break;
                case 6:
                    Console.WriteLine("Si");
                    break;
                default:
                    break;
            }
        }
    }
}
