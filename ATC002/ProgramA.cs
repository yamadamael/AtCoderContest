using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        struct Info
        {
            public int x;
            public int y;
        }

        static string[] _graph;
        static int _r, _c;
        static int _sx, _sy;
        static int _gx, _gy;
        static int[,] _dist;
        static Queue<Info> _queue;
        static int[] _dx = { 0, 1, 0, -1 };
        static int[] _dy = { 1, 0, -1, 0 };

        static void Main(string[] args)
        {
            var inputs1 = Console.ReadLine().Split(" ");
            _r = int.Parse(inputs1[0]);
            _c = int.Parse(inputs1[1]);

            var inputs2 = Console.ReadLine().Split(" ");
            _sy = int.Parse(inputs2[0]) - 1;
            _sx = int.Parse(inputs2[1]) - 1;

            var inputs3 = Console.ReadLine().Split(" ");
            _gy = int.Parse(inputs3[0]) - 1;
            _gx = int.Parse(inputs3[1]) - 1;

            // グラフ初期化
            _graph = new string[_r];
            for (var i = 0; i < _r; i++)
            {
                _graph[i] = Console.ReadLine();
            }

            // 距離表初期化
            _dist = new int[_r, _c];
            for (var i = 0; i < _r; i++)
            {
                for (var j = 0; j < _c; j++)
                {
                    _dist[i, j] = -1;
                }
            }
            _dist[_sy, _sx] = 0;

            // bfs
            _queue = new Queue<Info>();
            _queue.Enqueue(new Info() { x = _sx, y = _sy });
            while (_queue.Count != 0)
            {
                var q = _queue.Dequeue();

                for (var i = 0; i < 4; i++)
                {
                    var nx = q.x + _dx[i];
                    var ny = q.y + _dy[i];

                    if (nx < 0 || _c <= nx) continue;
                    if (ny < 0 || _r <= ny) continue;
                    if (_graph[ny][nx] == '#') continue;
                    if (_dist[ny, nx] != -1) continue;

                    _queue.Enqueue(new Info() { x = nx, y = ny });
                    _dist[ny, nx] = _dist[q.y, q.x] + 1;
                }
            }

            Console.WriteLine(_dist[_gy, _gx]);
            // Console.WriteLine("_dist debug print");
            // for (var i = 0; i < _r; i++)
            // {
            //     var s = "";
            //     for (var j = 0; j < _c; j++)
            //     {
            //         s += (_dist[i, j] == -1 ? "--" : string.Format("{0:D2}", _dist[i, j])) + " ";
            //     }
            //     Console.WriteLine(s);
            // }
        }
    }
}
