using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ProjectEuler.Solutions;

namespace ProjectEuler
{
    class EulerMain
    {
        static void Main(string[] args)
        {
            Euler1();
        }

        private static void Euler1()
        {
            var problem1 = new Problem1();
            problem1.SolveProblem();
            Console.WriteLine(problem1.Solution);
            Console.ReadLine();
        }
    }
}
