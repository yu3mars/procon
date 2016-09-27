using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1237
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                string[] s = Console.ReadLine().Split(' ');
                int t = int.Parse(s[0]);
                if (t == 0) return;
                string numstr = s[1];
                /*
                if(int.Parse(numstr) <=t)
                {
                    Console.WriteLine("{0} {1}", t,t);
                    continue;
                }
                */
                
                HashMap<int, int> dic = new HashMap<int, int>();
                int ans = -1;
                string ansstr = "";

                for (int bitdp = 0; bitdp < (1 << (numstr.Length - 1)); bitdp++)
                {
                    List<int> lstmp = new List<int>();
                    string str = numstr;
                    for (int bit = 0; bit < numstr.Length - 1; bit++)
                    {
                        if((bitdp >> bit) %2 == 1)  //bunkatsu
                        {
                            string after = str.Substring(numstr.Length - bit - 1);
                            str = str.Substring(0, numstr.Length - bit - 1);
                            lstmp.Add(int.Parse(after));
                        }
                    }
                    lstmp.Add(int.Parse(str));
                    int sum = lstmp.Sum();
                    if(ans<= sum && sum<=t)
                    {
                        ans = sum;
                        dic[sum]++;
                        lstmp.Reverse();
                        //ansstr = String.Join(" ", lstmp); //AOJ error
                        StringBuilder sb = new StringBuilder();
                        for (int i = 0; i < lstmp.Count; i++)
                        {
                            if (i > 0) sb.Append(" ");
                            sb.Append(lstmp[i]);
                        }
                        ansstr = sb.ToString();
                    }
                }
                if(ans == -1)
                {
                    Console.WriteLine("error");
                }
                else if(dic[ans] ==1)
                {
                    Console.WriteLine("{0} {1}", ans, ansstr);
                }
                else
                {
                    Console.WriteLine("rejected");
                }
            }
        }
    }
    class HashMap<K, V> : Dictionary<K, V>
    {
        new public V this[K i]
        {
            get
            {
                V v;
                return TryGetValue(i, out v) ? v : base[i] = default(V);
            }
            set { base[i] = value; }
        }
    }
}
