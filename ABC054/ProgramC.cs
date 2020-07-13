using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        struct Info
        {
            public int to;
            public string path;
            // public string ind;
        }
        static Queue<Info> _q = new Queue<Info>();
        static List<int>[] _graph;
        static int _count;
        static int _n;

        static void Main(string[] args)
        {
            var inputs = Console.ReadLine().Split(" ");
            _n = int.Parse(inputs[0]);
            var m = int.Parse(inputs[1]);

            _graph = new List<int>[_n];
            for (var i = 0; i < _n; i++)
            {
                _graph[i] = new List<int>();
            }

            for (var i = 0; i < m; i++)
            {
                var inputs1 = Console.ReadLine().Split(" ");
                var a = int.Parse(inputs1[0]) - 1;
                var b = int.Parse(inputs1[1]) - 1;
                _graph[a].Add(b);
                _graph[b].Add(a);
            }

            _q.Enqueue(new Info() { to = 0, path = "0" });
            while (_q.Count > 0)
            {
                var info = _q.Dequeue();
                var v = info.to;
                var path = info.path;
                // var ind = info.ind;
                // Console.WriteLine(ind + "v: " + v + ", path: " + path);

                foreach (var t in _graph[v])
                {
                    if (path.Contains(t.ToString())) continue;
                    _q.Enqueue(new Info()
                    {
                        to = t,
                        path = path + t.ToString(),
                        // ind = ind + "  "
                    });
                    // Console.WriteLine(ind + "  t: " + t);
                }

                if (path.Count() == _n)
                    _count++;
            }

            Console.WriteLine(_count);
        }
    }
}
