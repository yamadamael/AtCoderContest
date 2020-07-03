using System;

namespace ABC
{
    class ProgramA
    {
        static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            Console.WriteLine(a + a * a + a * a * a);
        }
    }
}
