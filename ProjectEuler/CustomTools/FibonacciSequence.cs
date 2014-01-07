using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.CustomTools
{
    public static class FibonacciSequence
    {
        public static List<int> GenerateSequence(int maxInt)
        {
            var sequence = new List<int>();

            var first = 1;
            var second = 2;

            sequence.Add(first);
            sequence.Add(second);

            var number = first + second;
            while (number <= maxInt)
            {
                sequence.Add(number);
                first = second;
                second = number;
                number = first + second;
            }

            return sequence;
        }
    }
}
