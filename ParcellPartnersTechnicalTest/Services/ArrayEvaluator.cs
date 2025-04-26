using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcellPartnersTechnicalTest.Services
{
    public class ArrayEvaluator
    {
        public static int FindMissingNumber(int[] ints)
        {
            if (ints.Length == 0) return -1;

            List<int> list = ints.ToList();
            list.Sort();

            double first = list.First();
            double last = list.Last();
            int totalElements = list.Count + 1;

            //this needs to be checked as the following algorithm will not work unless a middle number is missing
            if (first > 0) return 0;
            if (last != list.Count) return list.Count; //This causes this algoritm to ONLY work for a sequential difference of ONE

            // sum the set and find the expected sum
            // since we know the first and the last number of the set we can calculate the expected sum
            // using the arithmic sequence sum formula.
            double sum = Sum(ints);
            double expected = ((double)totalElements) * ((first + last) / 2.00);

            // the missing number can be found by subtracting the expected from the actual sum.
            // NOTE: this will ONLY work if 1 element is missing from the set. 
            double missing = expected - sum;
            if (list.Contains((int) missing)) throw new Exception("More than 1 number missing from list");
            return (int) missing;

        }


        private static double Sum(int[] ints)
        {
            double sum = 0;
            for (int i = 0; i < ints.Length; i++)
            {
                sum += ints[i];
            }
            return sum;
        }


    }
}
