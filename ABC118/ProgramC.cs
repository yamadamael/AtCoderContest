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
            var isExistOdd = false;
            var isExistEven = false;

            var list = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToList();
            list = list.Distinct().ToList();
            var count = list.Count;
            for (var i = 0; i < count; i++)
            {
                if (list[i] % 2 == 0)
                {
                    isExistEven = true;
                }
                else
                {
                    isExistOdd = true;
                }
            }

            if (list.Count == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (isExistEven && isExistOdd)
            {
                Console.WriteLine(1);
                return;
            }

            var dev = list.Min();
            var min = dev;

            while (true)
            {
                for (var i = 0; i < count; i++)
                {
                    var c = list[i] % dev;
                    if (c != 0 && c < min)
                    {
                        min = c;
                    }
                }

                if (min == dev)
                {
                    break;
                }
                dev = min;
            }

            Console.WriteLine(dev);
        }
    }
}
