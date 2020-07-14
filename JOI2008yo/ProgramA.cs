using System;
using System.Linq;
using System.Collections.Generic;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var result = 0;

            a = 1000 - a;

            result += a / 500;
            a = a % 500;

            result += a / 100;
            a = a % 100;

            result += a / 50;
            a = a % 50;

            result += a / 10;
            a = a % 10;

            result += a / 5;
            a = a % 5;

            result += a;

            Console.WriteLine(result);
        }
    }
}
