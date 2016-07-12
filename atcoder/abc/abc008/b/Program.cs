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
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int max = 0;
            string smax = "";
            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                if(dic.ContainsKey(s))
                {
                    dic[s]++;
                }
                else
                {
                    dic.Add(s, 1);
                }
                if(max<dic[s])
                {
                    max = dic[s];
                    smax = s;
                }
            }
            Console.WriteLine(smax);
        }
    }
}
