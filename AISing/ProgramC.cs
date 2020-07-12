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
            var list = new int[n];

            var end = Math.Sqrt(n);
            // Console.WriteLine(string.Format("n: {0}, end: {1}", n, end));

            for (var i = 1; i < end; i++)
            {
                var ii = i * i;
                for (var j = 1; j < end; j++)
                {
                    var jj = j * j;
                    var ij = i * j;
                    for (var k = 1; k < end; k++)
                    {
                        var kk = k * k;
                        var r = ii + jj + kk + ij + i * k + j * k;

                        if (r <= n)
                        {
                            list[r - 1]++;
                        }
                        if (r >= n)
                        {
                            break;
                        }
                    }
                }
            }

            for (var i = 0; i < n; i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}
