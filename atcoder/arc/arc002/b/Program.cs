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
            DateTime dt = DateTime.Parse(Console.ReadLine());
            for(;;)
            {
                if(dt.Year%(dt.Month*dt.Day)==0)
                {
                    Console.WriteLine(dt.ToString("yyyy/MM/dd"));
                    return;
                }
                else
                {
                    dt = dt.AddDays(1);
                }
            }
        }
    }
}
