using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);
            var list = new int[m];


            for (var i = 0; i < n; i++)
            {
                var l = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
                for (var j = 0; j < l[0]; j++)
                {
                    // Console.WriteLine(string.Join(",", i, j));
                    list[--l[j + 1]]++;
                }

            }

            var result = list.Count(x => x == n);
            Console.WriteLine(result);
        }
    }
}
