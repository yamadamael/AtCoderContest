using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = long.Parse(inputs[0]);
            var k = long.Parse(inputs[1]);

            var s = Console.ReadLine();

            var result = "";

            for (var i = 0; i < n; i++)
            {
                result += i == k - 1 ? s[i].ToString().ToLower() : s[i].ToString();
            }

            Console.WriteLine(result);
        }
    }
}
