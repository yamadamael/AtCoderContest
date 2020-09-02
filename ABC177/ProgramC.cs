using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var list = new long[n];
            var inputs = Console.ReadLine().Split(" ");
            for (var i = 0; i < n; i++)
            {
                var a = long.Parse(inputs[i]);
                list[i] = a;
            }


            var result = 0L;

            for (var i = 0; i < n; i++)
            {
                var li = list[i];
                for (var j = i + 1; j < n; j++)
                {
                    var r = li * list[j];
                    if (r > (int)(1e9 + 7))
                        result += r % (int)(1e9 + 7);
                    else
                        result += r;
                    if (result > (int)(1e9 + 7))
                        result %= (int)(1e9 + 7);
                }
            }

            Console.WriteLine(result);
        }
    }
}
