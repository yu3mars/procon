using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter w = new StreamWriter(@"output-large.txt"))
            {
                using (StreamReader r = new StreamReader(@"B-large.in"))
                {
                    int t = int.Parse(r.ReadLine());
                    for (int i = 0; i < t; i++)
                    {
                        string ans = "";
                        int n = int.Parse(r.ReadLine());
                        int[][] dat = new int[2 * n - 1][];
                        SortedDictionary<int, int> dic = new SortedDictionary<int, int>();
                        for (int j = 0; j < 2*n-1; j++)
                        {
                            dat[j]= r.ReadLine().Split().Select(int.Parse).ToArray();                         
                        }
                        for (int j = 0; j < 2*n-1; j++)
                        {
                            for (int k = 0; k < n; k++)
                            {
                                if (dic.ContainsKey(dat[j][k]))
                                {
                                    dic[dat[j][k]]++;
                                }
                                else
                                {
                                    dic.Add(dat[j][k], 1);
                                }
                            }
                        }
                        List<int> ls = new List<int>();
                        foreach (var val in dic)
                        {
                            if(val.Value%2==1)
                            {
                                ls.Add(val.Key);
                            }
                        }
                        ls.Sort();
                        ans = string.Join(" ", ls);
                        w.WriteLine("Case #{0}: {1}", i + 1, ans);
                    }
                }
            }
        }
    }
}
