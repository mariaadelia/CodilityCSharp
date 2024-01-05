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
