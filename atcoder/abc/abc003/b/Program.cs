using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace b
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] c = new char[7];
            string atcoder = "atcoder";

            string s = Console.ReadLine();
            string t = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]!=t[i])
                {
                    if(s[i]=='@')
                    {
                        bool flag = false;
                        for (int j = 0; j < atcoder.Length; j++)
                        {
                            if(t[i]==atcoder[j])
                            {
                                flag = true;
                                break;
                            }
                        }
                        if(flag==false)
                        {
                            Console.WriteLine("You will lose");
                            return;
                        }
                    }
                    else if (t[i] == '@')
                    {
                        bool flag = false;
                        for (int j = 0; j < atcoder.Length; j++)
                        {
                            if (s[i] == atcoder[j])
                            {
                                flag = true;
                                break;
                            }
                        }
                        if (flag == false)
                        {
                            Console.WriteLine("You will lose");
                            return;
                        }
                    }
                    else
                    {
                        Console.WriteLine("You will lose");
                        return;
                    }
                }
            }
            Console.WriteLine("You can win");
        }
    }
}
