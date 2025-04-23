using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcellPartnersTechnicalTest
{
    public static class ArrayConverter
    {
        public static int[] ToIntArr(this string[] array)
        {
            int[] set = new int[array.Length];
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    string input = array[i];
                    int number = int.Parse(input);
                    set[i] = number;
                }
                return set;
            }
            catch {
                Console.WriteLine("An input argument cannot be converted to an int.");
                return new int[0];
            }
        }
    }
}
