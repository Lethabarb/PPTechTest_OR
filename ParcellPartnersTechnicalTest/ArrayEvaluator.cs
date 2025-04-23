using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcellPartnersTechnicalTest
{
    public class ArrayEvaluator
    {
        public int FindMissingNumber(int[] ints)
        {
            if (ints.Length == 0) return -1;

            List<int> list = ints.ToList();
            list.Sort();

            int first = list.First();
            int last = list.Last();

            //this needs to be checked as the following algorithm will not work unless a middle number is missing
            if (first > 0) return 0;
            if (last != list.Count) return list.Count;

            // sum the set and find the expected sum
            // since we know the first and the last number of the set we can calculate the expected sum
            // using the arithmic sequence sum formula.
            double sum = Sum(ints);
            double expected = (list.Count + 1) / 2 * last;

            // the missing number can be found by subtracting the expected from the actual sum.
            // NOTE: this will ONLY work if 1 element is missing from the set. 
            double missing = expected - sum;
            return (int) missing;

        }


        private double Sum(int[] ints)
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
