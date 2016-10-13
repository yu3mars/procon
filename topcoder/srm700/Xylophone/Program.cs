using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xylophone_
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
class Xylophone
{
    public static int countKeys(int[] keys)
    {
        bool[] b = new bool[7];
        foreach (var i in keys)
        {
            b[i % 7] = true;
        }
        int ans = 0;
        for (int i = 0; i < b.Length; i++)
        {
            if (b[i]) ans++;
        }
        return ans;
    }
}