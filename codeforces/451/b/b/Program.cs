using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] str = Console.ReadLine().Split(' ');
            int[] ar = new int[n];
            int start = 1234567890;
            int end = 1234567890;
            int indstart = -1;
            int indend = -1;
            int revcount = 0;
            bool reversing=false;
            for (int i = 0; i < n; i++)
            {
                ar[i] = int.Parse(str[i]);
            }
            int beforestart = -1;
            for (int i = 1; i < n; i++)
            {
                if (reversing == false)
                {
                    if (ar[i] < ar[i - 1])
                    {
                        if (revcount > 0)
                        {
                            Console.WriteLine("no");
                            return;
                        }
                        else
                        {
                            revcount += 1;
                            reversing = true;
                            start = ar[i - 1];
                            indstart = i;
                            if (i > 1)
                            {
                                beforestart = ar[i - 2];
                            }
                        }
                    }
                }
                else
                {
                    if (ar[i] > ar[i - 1])
                    {
                        reversing = false;
                        end = ar[i - 1];
                        indend = i;
                        if (ar[i] < start || end < beforestart)
                        {
                            Console.WriteLine("no");
                            return;
                        }
                    }

                }
            }
            if (start == 1234567890)
            {
                start = ar[0];
                end = ar[0];
                indstart = 1;
                indend = 1;
            }
            else if (end == 1234567890)
            {
                end = ar[n - 1];
                indend = n;
            }
            Console.WriteLine("yes");
            Console.WriteLine("{0} {1}", indstart, indend);
        }
    }
}
