using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 328;
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
           
            var numberOne = new List<int>();
            int value = 0;

            foreach (var num in binaryNumber)
            {
                if(num.Equals('0'))
                {
                    value += 1;
                }
                else
                {
                    numberOne.Add(value);
                    value = 0;
                }
            }

     
            return numberOne.Max();
        }
    }
}
