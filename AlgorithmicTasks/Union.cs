using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmicTasks
{
    public partial class Program
    {
        /// <summary>
        /// Union of two arrays. Complexity O(first.Length + second.Length)
        /// </summary>
        /// <param name="first"></param>
        /// <param name="second"></param>
        /// <returns></returns>
        public static int[] Union(int[] first, int[] second)
        {
            //check
            if (first == null || second == null)
                throw new Exception("one array is null");

            var result = new HashSet<int>();

            int i = 0, j = 0;
            while (i < first.Length && j < second.Length)
            {
                if (first[i] < second[j])
                    result.Add(first[i++]);
                else if (first[i] > second[j])
                    result.Add(second[j++]);
                else
                {
                    result.Add(second[j++]);
                    i++;
                }
            }

            //add other elements
            while (i < first.Length)
            {
                result.Add(first[i++]);
            }
            while (j < second.Length)
            {
                result.Add(second[j++]);
            }

            return result.ToArray();
        }
    }
}
