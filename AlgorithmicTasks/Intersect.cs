using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicTasks
{
    public partial class Program
    {
        /// <summary>
        /// Intersect of two arrays. Complexity O(first.Length + second.Length)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int[] Intersect(int[] first, int[] second)
        {
            if (first == null || second == null)
                throw new Exception("one array is null");

            var result = new HashSet<int>();
            int i = 0, j = 0;
            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                    i++;
                else if (first[i] > second[j])
                    j++;
                else
                {
                    result.Add(second[j++]);
                    i++;
                }
            }
            return result.ToArray();
        }
    }
}
