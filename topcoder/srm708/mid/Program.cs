using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mid
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 50000; i <= 50000; i++)
            {
                BuildingStrings.findAny(i);
                Console.WriteLine("CASE: {0}",i);
            }
        }
    }
}
class BuildingStrings
{
    public static List<string> ls;
    public static int k;
    public static string[] findAny(int n)
    {
        ls = new List<string>();
        k = n;
        while(k > 0)
        {
            string s = findstr();
            //Console.WriteLine(s);
            ls.Add(s);
        }

        return ls.ToArray();
    }

    private static string findstr()
    {
        string s = "";
        int len = 0;
        StringBuilder sb = new StringBuilder();

        if (k >= 26 * 50)
        {
            s = "aabbccddeeffgghhiijjkkllmmnnooppqqrrssttuuvvwwxxyz";
            k -= 26 * 50;
            return s;

        }
        else
        {
            for (int i = 26; i > 0; i--)
            {
                if (k >= i * i)
                {
                    len = k / i;
                    sb = new StringBuilder();
                    for (int j = 0; j < len; j++)
                    {
                        if (j < i)
                        {
                            sb.Append((char)('a' + j));
                        }
                        else
                        {
                            sb.Append('a');
                        }
                    }
                    k -= i * len;
                    return sb.ToString();
                }
            }
        }

        return s;
    }
}