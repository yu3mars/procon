using System;
class P
{
    static void Main()
    {
        int i, n = int.Parse(Console.ReadLine()), s = int.Parse(Console.ReadLine()), t = s;
        for (i = 1; i < n; i++)
        {
            t += int.Parse(Console.ReadLine());
        }
        Console.WriteLine((s * n * 2 > t) ? "Pass" : "Fail");
    }
}