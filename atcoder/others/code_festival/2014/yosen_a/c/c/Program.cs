using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = Console.ReadLine().Split(' ');
            int start = int.Parse(str[0]);
            int end = int.Parse(str[1]);

            int count = 0;
            if (end - start <= 1000)
            {
                for (int i = start; i <= end; i++)
                    if (i % 4 == 0)
                    {
                        if (i % 100 != 0)
                        {
                            count += 1;
                        }
                        else if (i % 400 == 0)
                        {
                            count += 1;
                        }
                    }
                Console.WriteLine(count);
                return;
            }
            else
            {
                int start3keta = start % 400;
                int end3keta = end % 400 + 400;
                int numof400 = (end/400 - start/400) -1;

                for (int i = start3keta; i <= end3keta; i++)
                {
                    if (i % 4 == 0)
                    {
                        if (i % 100 != 0)
                        {
                            count += 1;
                        }
                        else if (i % 400 == 0)
                        {
                            count += 1;
                        }
                    }
                }
                count += numof400 * 97;
                Console.WriteLine(count);
            }
        }
    }
}
