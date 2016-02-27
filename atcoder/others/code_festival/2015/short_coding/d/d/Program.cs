using System;
namespace d
{
    class P
    {
        static void Main()
        {
            string a = Console.ReadLine(), b = Console.ReadLine();
            int i = 0,l=b.Length;
            while (a.Length>l)
            {
                if (i >= l || a[i] != b[i])
                {
                    i = Math.Min(i, l - 1);
                    a = a.Substring(0, i) + ((a[i] + a[i + 1] - '0' * 2) % 10).ToString() + a.Substring(i + 2);
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(a == b ? "YES" : "NO");
        }
    }
}