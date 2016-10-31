using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace middle
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
class SortingSubsets
{
    public static int getMinimalSize(int[] a)
    {
        int[] b = new int[a.Length];
        for (int i = 0; i < a.Length; i++)
        {
            b[i] = a[i];
        }
        Array.Sort(b);
        int ret = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] != b[i]) ret++;
        }
        return ret;
    }
}