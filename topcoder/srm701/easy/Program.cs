using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareFreeString_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(
            SquareFreeString.isSquareFree("bobo")
            );
        }
    }
}
class SquareFreeString
{
    public static string isSquareFree(string s)
    {
        bool sqFree = true;
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 2; i + j <= s.Length; j += 2)
            {
                string sub = s.Substring(i, j);
                bool issq = true;
                for (int k = 0; k < sub.Length / 2; k++)
                {
                    if (sub[k] != sub[k + sub.Length / 2])
                    {
                        issq = false;
                        break;
                    }
                }
                if (issq) sqFree = false;
            }
        }

        if (sqFree) return "square-free";
        else return "not square-free";
    }
}