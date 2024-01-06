using System;
using System.Collections.Generic;

namespace CyclicRotation
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                int[] array = {2,3,4,5,5,656,565,656,565,6,56453,53,534,5345,465,45,345,34,5345,3, 8, 9, 7, 6 };                
                int inverseNumber = 365;

                Solution sol = new Solution();
                AnotherSolution another = new AnotherSolution();
                //sol.constraintsArray(array);
                //sol.constraintsNumber(inverseNumber);
                sol.solution(array, inverseNumber);
                another.solution(array, inverseNumber);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    class Solution
    {
        public int[] solution(int[] A, int K)
        {
            
            int finalNumber = 0;
            var final = new List<int>();
            int[] finalList = new int[A.Length];


            foreach (var i in A)
            {
                final.Add(i);
            }
          
            if (final.Count != 0 )
            {
                for (int i = 0; i < K; i++)
                {
                    finalNumber = final[(final.Count - 1)];
                    final.RemoveAt(final.Count - 1);
                    final.Insert(0, finalNumber);
                }

                finalList = final.ToArray();

                foreach (var i in finalList)
                {
                    Console.WriteLine(i);
                }
            }
            return finalList;
        }

        public void constraintsArray(int[] A)
        {
            foreach(var n in A)
            {
                if(n < -1000 || n > 1000)
                {
                    throw new ArgumentException($"The number {n} is out of range");
                }
            }

        }

        public void constraintsNumber(int K)
        {
            if(K < 0 || K > 100)
            {
                throw new ArgumentException($"The number {K} is out of range");
            }
        }
    }
}
