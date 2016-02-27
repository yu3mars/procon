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
            string[] nk = Console.ReadLine().Split(' ');
            int n = int.Parse(nk[0]);
            int k = int.Parse(nk[1]);
            int[,] t = new int[n,k];
            for (int i = 0; i < n; i++)
            {
                string[] str = Console.ReadLine().Split(' ');
                for (int j = 0; j < str.Length; j++)
                {
                    t[i,j] = int.Parse(str[j]);
                }
            }
            if (dfs(0,0,n,k,t))
            {
                Console.WriteLine("Found");
            }
            else
            {
                Console.WriteLine("Nothing");
            }            
        }

        static bool dfs(int numq, int xor, int n,int k, int[,] t)
        {
            if (numq == n)
            {
                return (xor == 0);
            }
            for (int i = 0; i < k; i++)
            {
                if(dfs(numq+1,xor^t[numq,i],n,k,t))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
