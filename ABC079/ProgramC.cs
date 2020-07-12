using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramC
    {
        static void Main(string[] args)
        {

            var inputs = Console.ReadLine().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
            var a = inputs[0];
            var b = inputs[1];
            var c = inputs[2];
            var d = inputs[3];

            for (var i = 0; i < 2; i++)
            {
                for (var j = 0; j < 2; j++)
                {
                    for (var k = 0; k < 2; k++)
                    {
                        var r1 = i == 0 ? a + b : a - b;
                        var r2 = j == 0 ? r1 + c : r1 - c;
                        var r3 = k == 0 ? r2 + d : r2 - d;
                        if (r3 == 7)
                        {
                            Console.WriteLine(string.Format("{0}{1}{2}{3}{4}{5}{6}=7", a, getString(i), b, getString(j), c, getString(k), d));
                            return;
                        }
                    }
                }
            }
        }

        static string getString(int n)
        {
            return n == 0 ? "+" : "-";
        }
    }
}
