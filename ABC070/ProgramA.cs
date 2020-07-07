using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var a = long.Parse(Console.ReadLine());
            var list = a.ToString().ToCharArray().Reverse();
            var rs = "";
            foreach (var c in list)
            {
                rs += c.ToString();
            }
            var ra = int.Parse(rs);

            Console.WriteLine(a == ra ? "Yes" : "No");
        }
    }
}
