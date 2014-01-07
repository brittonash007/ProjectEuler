using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectEuler.Solutions
{
    //Solution class to Multiples of 3 and 5
    //Link: http://projecteuler.net/problem=1
    public class Problem1
    {
        public int Solution { get; private set; }
        private const int MAX_INTEGER = 999;

        public void SolveProblem()
        {
            Solution = AddMultiples(FindMultiples(MAX_INTEGER));
        }
        private List<int> FindMultiples(int number)
        {
            var multiples = new List<int>();

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    multiples.Add(i);
                }
            }

            return multiples;
        }
        private int AddMultiples(List<int> multiples)
        {
            var sum = 0;

            foreach (int multiple in multiples)
            {
                sum += multiple;
            }

            return sum;
        }
    }
}
