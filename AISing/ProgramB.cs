using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var list = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();

            var result = 0;

            for (var i = 0; i < a; i += 2)
            {
                if (list[i] % 2 == 1)
                {
                    result++;
                }
            }


            Console.WriteLine(result);
        }
    }
}
