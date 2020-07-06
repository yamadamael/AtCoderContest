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
            var h = int.Parse(inputs[0]);
            var w = int.Parse(inputs[1]);
            var matrix = new char[h, w];

            int[] dx = new int[] { 0, 1, 0, -1 };
            int[] dy = new int[] { -1, 0, 1, 0 };

            for (var i = 0; i < h; i++)
            {
                var list = Console.ReadLine().ToCharArray();
                for (var j = 0; j < w; j++)
                {
                    matrix[i, j] = list[j];
                }
            }

            for (var i = 0; i < h; i++)
            {
                for (var j = 0; j < w; j++)
                {
                    if (matrix[i, j] != '#') continue;

                    for (var k = 0; k < 4; k++)
                    {
                        var ki = i + dx[k];
                        var kj = j + dy[k];
                        if (ki < 0 || h <= ki) continue;
                        if (kj < 0 || w <= kj) continue;
                        if (matrix[ki, kj] == '#')
                            break;
                        if (k == 3)
                        {
                            Console.WriteLine("No");
                            return;
                        }

                    }
                }
            }

            Console.WriteLine("Yes");
        }
    }
}
