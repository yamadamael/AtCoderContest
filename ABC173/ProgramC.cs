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
            var k = int.Parse(inputs[2]);

            var matrix = new char[h, w];

            var result = 0;

            for (var i = 0; i < h; i++)
            {
                var list = Console.ReadLine().ToCharArray();
                for (var j = 0; j < w; j++)
                {
                    matrix[i, j] = list[j];
                }
            }

            // 行と列の選択状態をbitで表現する
            // 1 << h は2^hとなり、全bit立った状態+1になる
            for (var i = 0; i < (1 << h); i++)
            {
                for (var j = 0; j < (1 << w); j++)
                {
                    var cnt = 0;
                    // bitシフトループ
                    for (var si = 0; si < h; si++)
                    {
                        for (var sj = 0; sj < w; sj++)
                        {
                            if (((i >> si) & 1) == 1) continue;
                            if (((j >> sj) & 1) == 1) continue;
                            if (matrix[si, sj] == '#')
                                cnt++;
                            if (k < cnt) break;
                        }
                    }

                    if (k == cnt)
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
