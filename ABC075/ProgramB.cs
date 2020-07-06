using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        // 解説用
        static readonly int[] dx = new int[] { -1, 0, 1, -1, 1, -1, 0, 1 };
        static readonly int[] dy = new int[] { -1, -1, -1, 0, 0, 1, 1, 1 };


        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            var h = int.Parse(inputs[0]);
            var w = int.Parse(inputs[1]);
            var matrix = new char[h, w];
            var count = new int[h, w];

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

                    // if (i - 1 >= 0 && j - 1 >= 0) count[i - 1, j - 1]++;
                    // if (i - 1 >= 0) count[i - 1, j]++;
                    // if (i - 1 >= 0 && j + 1 < w) count[i - 1, j + 1]++;

                    // if (j - 1 >= 0) count[i, j - 1]++;
                    // if (j + 1 < w) count[i, j + 1]++;

                    // if (i + 1 < h && j - 1 >= 0) count[i + 1, j - 1]++;
                    // if (i + 1 < h) count[i + 1, j]++;
                    // if (i + 1 < h && j + 1 < w) count[i + 1, j + 1]++;

                    // 解説版
                    for (var k = 0; k < 8; k++)
                    {
                        var ki = i + dy[k];
                        var kj = j + dx[k];
                        if (ki < 0 || h <= ki) continue;
                        if (kj < 0 || w <= kj) continue;
                        count[ki, kj]++;
                    }
                }
            }

            for (var i = 0; i < h; i++)
            {
                var t = "";
                for (var j = 0; j < w; j++)
                {
                    t += matrix[i, j] == '#' ? "#" : count[i, j].ToString();
                }
                Console.WriteLine(t);
            }
        }
    }
}