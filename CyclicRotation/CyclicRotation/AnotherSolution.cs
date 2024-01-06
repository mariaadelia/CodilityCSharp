using System;
namespace CyclicRotation
{
    public class AnotherSolution
    {
            public int[] solution(int[] A, int K)
            {
                var result = new int[A.Length];
                int max = A.Length - 1;

                for (int i = 0; i < A.Length; i++)
                {
                    result[this.MapPosition(i, K, max)] = A[i];
                }

                foreach (var i in result)
                {
                    Console.WriteLine(i);
                }
            return result;
            }

            private int MapPosition(int pos, int rotate, int max)
            {
                for (int i = 0; i < rotate; i++)
                {
                    if (pos < max) pos++;
                    else pos = 0;
                }
                return pos;
            }

        
    }
}
