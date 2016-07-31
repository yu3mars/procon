using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            switch (s)
            {
                case "Sunday":
                    Console.WriteLine(0);
                    break;
                case "Monday":
                    Console.WriteLine(5);
                    break;
                case "Tuesday":
                    Console.WriteLine(4);
                    break;
                case "Wednesday":
                    Console.WriteLine(3);
                    break;
                case "Thursday":
                    Console.WriteLine(2);
                    break;
                case "Friday":
                    Console.WriteLine(1);
                    break;
                case "Saturday":
                    Console.WriteLine(0);
                    break;
                default:
                    break;
            }
        }
    }
}
