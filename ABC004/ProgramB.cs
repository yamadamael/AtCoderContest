using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramB
    {
        static void Main(string[] args)
        {
            var n = 4;
            var list = new string[n];
            for (var i = 0; i < n; i++)
            {
                list[i] = Console.ReadLine().Replace(" ", "");
            }

            for (var i = n - 1; i >= 0; i--)
            {
                var s = "";
                for (var j = n - 1; j >= 0; j--)
                {
                    s += list[i][j] + " ";
                }
                Console.WriteLine(s);
            }
        }
    }
}
