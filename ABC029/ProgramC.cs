using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static int _a;
        static void Main(string[] args)
        {
            _a = int.Parse(Console.ReadLine());
            func("", 0);
        }

        static void func(string s, int count)
        {
            if (count == _a)
            {
                Console.WriteLine(s);
                return;
            }

            func(s + "a", count + 1);
            func(s + "b", count + 1);
            func(s + "c", count + 1);
        }
    }
}
