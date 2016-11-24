using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "abc";
            string s2 = "abc";

            if (s1 == s2)
            {
                Console.WriteLine("You got it right!");
            }
            else
            {
                Console.WriteLine("You are wrong!");
            }
        }
    }
}
