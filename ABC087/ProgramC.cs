using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        // 行数固定
        // static void Main(string[] args)
        // {
        //     var n = int.Parse(Console.ReadLine());
        //     var list1 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
        //     var list2 = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();

        //     var result = 0;

        //     for (var i = 0; i < n; i++)
        //     {
        //         var r1 = list1.Take(i + 1).Sum();
        //         var r2 = list2.Skip(i).Sum();
        //         // Console.WriteLine(string.Format("i: {0}, r1: {1}, r2: {2}", i, r1, r2));
        //         result = Math.Max(result, r1 + r2);
        //     }
        //     Console.WriteLine(result);
        // }

        // 行数可変のdfs
        static void Main(string[] args)
        {
            _h = 2;
            _w = int.Parse(Console.ReadLine());
            _graph = new int[_h][];
            _graph[0] = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
            _graph[1] = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

            dfs(0, 0, 0);

            Console.WriteLine(_max);
        }

        static int[][] _graph;
        static int _h;
        static int _w;

        static int _max;
        static int[] _dx = new int[] { 0, 1 };
        static int[] _dy = new int[] { 1, 0 };

        static void dfs(int h, int w, int count)
        {
            count += _graph[h][w];
            if (h == _h - 1 && w == _w - 1)
            {
                _max = Math.Max(_max, count);
                return;
            }

            for (var i = 0; i < 2; i++)
            {
                var nh = h + _dy[i];
                var nw = w + _dx[i];

                if (nh < 0 || _h <= nh) continue;
                if (nw < 0 || _w <= nw) continue;

                dfs(nh, nw, count);
            }
        }
    }
}
