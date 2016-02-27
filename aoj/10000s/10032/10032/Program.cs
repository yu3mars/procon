using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10032
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Stack<string> stk = 
                new System.Collections.Generic.Stack<string>();
            while (true)
            {
                string[] str = Console.ReadLine().Split(' ');
                if (str[0] == "push")
                {
                    stk.Push(str[1]);
                }
                else if (str[0] == "pop")
                {
                    Console.WriteLine(stk.Pop());
                }
                else if (str[0] == "quit")
                {
                    return;
                }
            }
        }
    }
}
