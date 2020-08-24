using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = long.Parse(Console.ReadLine());

            var list = new List<int>();
            var result = 0;
            for (var i = 0; i < n; i++)
            {
                var a = int.Parse(Console.ReadLine());

                if (list.Contains(a))
                {
                    result++;
                }
                else
                {
                    list.Add(a);
                }
            }
            Console.WriteLine(result);
        }
    }
}
