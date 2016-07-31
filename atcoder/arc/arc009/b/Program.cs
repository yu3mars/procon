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
            int[] b = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = int.Parse(Console.ReadLine());
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < 10; i++)
            {
                dic.Add(b[i] , i);
            }
            int[] a = new int[n];
            Dictionary<int, int> ds = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                string st = Console.ReadLine();
                int tmp = 0;
                for (int j = 0; j < st.Length; j++)
                {
                    tmp *= 10;
                    tmp += dic[st[j] - '0'];
                }
                a[i] = tmp;

                if (ds.ContainsKey(a[i]) == false)
                {
                    ds.Add(a[i], int.Parse(st));
                }
            }
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(ds[a[i]]);
            }
        }
    }
}
