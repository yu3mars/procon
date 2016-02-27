using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1173
{
    class Program
    {
        static void Main(string[] args)
        {
            for (; ; )
            {
                string str = Console.ReadLine();
                Stack<string> stk= new Stack<string>();
                if (str[0].ToString() == ".")
                {
                    return;
                }
                else
                {
                    for (int i = 0; i < str.Length; i++)
                    {
                        if (str[i].ToString() == ".")
                        {
                            if (stk.Count == 0)
                            {
                                Console.WriteLine("yes");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("no");
                                break;
                            }
                        }
                        else if (str[i].ToString() == "(")
                        {
                            stk.Push("(");
                        }
                        else if (str[i].ToString() == "[")
                        {
                            stk.Push("[");
                        }
                        else if (str[i].ToString() == ")")
                        {
                            if (stk.Count == 0)
                            {
                                Console.WriteLine("no");
                                break;
                            }
                            else if (stk.Pop() != "(")
                            {
                                Console.WriteLine("no");
                                break;
                            }
                        } 
                        else if (str[i].ToString() == "]")
                        {
                            if (stk.Count == 0)
                            {
                                Console.WriteLine("no");
                                break;
                            }
                            else if (stk.Pop() != "[")
                            {
                                Console.WriteLine("no");
                                break;
                            }
                        }
                    }
                }
            }
        }
    }
}
