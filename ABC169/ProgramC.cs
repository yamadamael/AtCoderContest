using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var a = long.Parse(inputs[0]);
            var bs = inputs[1];
            var b = int.Parse(bs[0].ToString()) * 100 +
                    int.Parse(bs[2].ToString()) * 10 +
                    int.Parse(bs[3].ToString());

            var result = a * b;
            // Console.WriteLine(string.Join(",", a, b));
            // Console.WriteLine(a * b);
            // Console.WriteLine(result);
            Console.WriteLine(result / 100);
        }
    }
}
