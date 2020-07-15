using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var s = int.Parse(Console.ReadLine());

            var result = int.MaxValue;

            for (var i = 1; i <= Math.Sqrt(s); i++)
            {
                var j = s / i;
                result = Math.Min((s - (i * j)) + Math.Abs(i - j), result);
            }

            Console.WriteLine(s == 1 ? 0 : result);
        }
    }
}
