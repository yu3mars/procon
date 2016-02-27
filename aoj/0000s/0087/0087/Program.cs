using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _0087
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (; ; )
                {
                    string a, b, c;
                    string[] str = Console.ReadLine().Split(' ');
                    Stack<string> stk = new Stack<string>();
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i] == "+")
                        {
                            b = stk.Pop();
                            a = stk.Pop();
                            c = (double.Parse(a) + double.Parse(b)).ToString("F6");
                            stk.Push(c);
                        }
                        else if (str[i] == "-")
                        {
                            b = stk.Pop();
                            a = stk.Pop();
                            c = (double.Parse(a) - double.Parse(b)).ToString("F6");
                            stk.Push(c);
                        }
                        else if (str[i] == "*")
                        {
                            b = stk.Pop();
                            a = stk.Pop();
                            c = (double.Parse(a) * double.Parse(b)).ToString("F6");
                            stk.Push(c);
                        }
                        else if (str[i] == "/")
                        {
                            b = stk.Pop();
                            a = stk.Pop();
                            c = (double.Parse(a) / double.Parse(b)).ToString("F6");
                            stk.Push(c);
                        }
                        else
                        {
                            stk.Push(str[i]);
                        }
                    }
                    Console.WriteLine(stk.Pop());
                }
            }
            catch
            { 
            }
        }
    }
}
