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
            var a = Console.ReadLine().Split(" ").Select(x => int.Parse(x) + 1).ToList();

            var xList = new int[(int)1e6];
            for (var i = 0; i < n; i++)
            {
                xList[a[i]]++;
                xList[a[i] + 1]++;
                xList[a[i] - 1]++;
            }
            Console.WriteLine(xList.Max());
        }
    }
}
