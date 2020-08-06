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
            var l = long.Parse(inputs[0]);
            var r = long.Parse(inputs[1]);
            // var list = new List<long>();

            // for (var i = l; i <= r; i++)
            // {
            //     var m = i % 2019;
            //     if (list.Contains(m))
            //     {
            //         break;
            //     }
            //     Console.WriteLine(string.Join(",", i, m));
            //     list.Add(m);
            // }

            // list.Sort();
            // Console.WriteLine(string.Join(",", list[0], list[1]));
            // var result = (list[0] * list[1]) % 2019;
            // Console.WriteLine(result);

            if (r - l > 3000)
            {
                Console.WriteLine(0);
                return;
            }

            var min = 2020L;
            for (var i = l; i < r; i++)
            {
                for (var j = i + 1; j <= r; j++)
                {
                    var m = (i * j) % 2019;
                    min = Math.Min(min, m);
                    if (min == 0)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine(min);
        }
    }
}
