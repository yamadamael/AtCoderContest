using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static int[] _array;

        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var p = Console.ReadLine().Split(" ").Select(x => long.Parse(x)).ToList();
            // var list = new List<long>();
            var min = 0;
            _array = new int[200000 + 10];

            for (var i = 0; i < n; i++)
            {
                // list.Add(p[i]);
                _array[p[i]] = 1;

                if (p[i] == min)
                {
                    // 再構築
                    var key = -1;
                    for (var j = min; j < _array.Length; j++)
                    {
                        if (_array[j] == 0)
                        {
                            key = j;
                            break;
                        }
                    }
                    if (key == -1)
                    {
                        min = _array.Length;
                    }
                    else
                    {
                        min = key;
                    }
                }

                Console.WriteLine(min);
            }
        }
    }
}
