using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

/* Challenge
 A binary gap within a positive integer N is any maximal sequence of consecutive zeros that is surrounded by ones at both ends in the binary representation of N.

For example, number 9 has binary representation 1001 and contains a binary gap of length 2. The number 529 has binary representation 1000010001 and contains two binary gaps: one of length 4 and one of length 3. The number 20 has binary representation 10100 and contains one binary gap of length 1. The number 15 has binary representation 1111 and has no binary gaps. The number 32 has binary representation 100000 and has no binary gaps.

Write a function:

class Solution { public int solution(int N); }

that, given a positive integer N, returns the length of its longest binary gap. The function should return 0 if N doesn't contain a binary gap.

For example, given N = 1041 the function should return 5, because N has binary representation 10000010001 and so its longest binary gap is of length 5. Given N = 32 the function should return 0, because N has binary representation '100000' and thus no binary gaps.

Write an efficient algorithm for the following assumptions:

N is an integer within the range [1..2,147,483,647].
 
 
 
 */
namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 1610612737;
            AnotherSolution sol = new AnotherSolution();
            Console.WriteLine(sol.Solution(number));
            MySolution sol2 = new MySolution();
            Console.WriteLine(sol2.solution(number));

        }
    }

    class MySolution
    {

        public int solution(int N)
        {
            // Implement your solution here
            try
            {
                checkPositiveInteger(N);
                var gapNumber = binaryGap(N);

                return gapNumber;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        public void checkPositiveInteger(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException("The value cannot be negative");
            }
        }


        public int binaryGap(int number)
        {
            string binaryNumber = Convert.ToString(number, 2);

            var spNumber = new ArrayList();
            var test = new List<int>();
            string[] splitNumber = binaryNumber.Split('1');
            int value = 0;

            foreach (var num in splitNumber)
            {
                if (num != "")
                    spNumber.Add(num);
            }


            //Checking if the length is bigger than 1 and if is not null
            if (spNumber == null || spNumber.Count < 1)
            {
                return 0;
            }
            else
            {
                foreach (var num in spNumber)
                {
                    value = num.ToString().Length;
                    test.Add(value);
                }
                return test.Max();
            }


        }
    }
}
