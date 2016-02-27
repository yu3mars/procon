using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nq = Console.ReadLine().Split(' ');
            int n = int.Parse(nq[0]);
            int q = int.Parse(nq[1]);
            for (int i = 0; i < q; i++)
            {
                int ans = 0;
                string[] str = Console.ReadLine().Split(' ');
                int cob = int.Parse(str[0]);
                int coe = int.Parse(str[1]);
                int gob = int.Parse(str[2]);
                int goe = int.Parse(str[3]);

                if (coe <= gob)
                {
                    ans = goe - gob;
                }
                else if (cob <= gob && gob <= coe && coe <= goe)
                {
                    ans = goe - coe;
                }
                else if (gob <= cob && coe <= goe)
                {
                    ans = cob - gob + goe - coe;
                }
                else if (cob <= gob && goe <= coe)
                {
                    ans = 0;
                }
                else if (gob <= cob && cob <= goe && goe <= coe)
                {
                    ans = cob - gob;
                }
                else if (goe < cob)
                {
                    ans = goe - gob;
                }

                Console.WriteLine(ans * 100);
            }
        }
    }
}
