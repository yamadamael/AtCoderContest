using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var list = new int[3];
            var inputs = Console.ReadLine().Split(" ");
            list[0] = int.Parse(inputs[0]);
            list[1] = int.Parse(inputs[1]);
            list[2] = int.Parse(inputs[2]);
            var result = 0;

            list = list.OrderBy(x => x).ToArray();

            result += list[1] - list[0];
            result += list[2] - list[1];

            Console.WriteLine(result);
        }
    }
}
