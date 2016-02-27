using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2198
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                int n = int.Parse(Console.ReadLine());
                if (n == 0)
                {
                    break;
                }
                Dictionary<string, double> dic = new Dictionary<string, double>();
                for (int i = 0; i < n; i++)
                {
                    string[] str = Console.ReadLine().Split(' ');
                    string l = str[0];
                    int p = int.Parse(str[1]);
                    int a = int.Parse(str[2]);
                    int b = int.Parse(str[3]);
                    int c = int.Parse(str[4]);
                    int d = int.Parse(str[5]);
                    int e = int.Parse(str[6]);
                    int f = int.Parse(str[7]);
                    int s = int.Parse(str[8]);
                    int m = int.Parse(str[9]);
                    int time = a + b + c + (d + e) * m;
                    int price = f * s * m - p;
                    double tp = (double)price / time;
                    dic.Add(l, tp);
                }
                List<KeyValuePair<string, double>> sorted = sortByValue(dic);
                foreach (KeyValuePair<string, double> kvp in sorted) 
                {      
                    Console.WriteLine(kvp.Key);
                }
                Console.WriteLine("#");
            }
        }
        static List<KeyValuePair<TKey, TValue>>
            sortByValue<TKey, TValue>(IDictionary<TKey, TValue> dict)
            where TValue : IComparable<TValue>
        {
            List<KeyValuePair<TKey, TValue>> list
              = new List<KeyValuePair<TKey, TValue>>(dict);

            // Valueの大きい順にソート
            list.Sort(
              delegate(KeyValuePair<TKey, TValue> kvp1, KeyValuePair<TKey, TValue> kvp2)
              {
                  if (kvp2.Value.CompareTo(kvp1.Value) != 0)
                  {
                      return kvp2.Value.CompareTo(kvp1.Value);
                  }
                  else
                  {
                      return kvp1.Key.ToString().CompareTo(kvp2.Key.ToString());
                  }
              });
            return list;
        }
    }
}
