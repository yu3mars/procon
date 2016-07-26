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
            int n = int.Parse(Console.ReadLine());
            bool[] holiday = new bool[366];
            for (int i = 0; i < holiday.Length; i += 7)
            {
                holiday[i] = true;
            }
            for (int i = 6; i < holiday.Length; i += 7)
            {
                holiday[i] = true;
            }
            DateTime ny = DateTime.Parse("2012/01/01");
            for (int i = 0; i < n; i++)
            {
                DateTime dt = DateTime.Parse("2012/" + Console.ReadLine());
                TimeSpan ts = dt - ny;
                // Difference in days.
                int differenceInDays = ts.Days;
                while (differenceInDays < holiday.Length && holiday[differenceInDays] == true)
                {
                    differenceInDays++;
                }
                if (differenceInDays < holiday.Length)
                {
                    holiday[differenceInDays] = true;
                }
            }
            int ans = 0;
            int tmp = 0;
            for (int i = 0; i < holiday.Length; i++)
            {
                if(holiday[i])
                {
                    tmp++;
                }
                else
                {
                    ans = Math.Max(ans, tmp);
                    tmp = 0;
                }
            }
            ans = Math.Max(ans, tmp);
            Console.WriteLine(ans);
        }
    }
}
