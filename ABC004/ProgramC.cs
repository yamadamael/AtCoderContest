using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            n %= 30;
            var list = new List<int>() { 1, 2, 3, 4, 5, 6 };
            var a = 5;

            while (n >= a)
            {
                var f = list[0];
                list.RemoveAt(0);
                list.Add(f);
                n -= a;
            }

            var first = list[0];
            list.RemoveAt(0);
            list.Insert(n, first);

            Console.WriteLine(string.Join("", list));
        }
    }
}
