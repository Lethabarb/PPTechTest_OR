using ParcellPartnersTechnicalTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ParcelPartnersTechnicalTest.Services
{
    public class ArrayEvaluatorTests
    {
        [Theory]
        [MemberData(nameof(SequentialData))]
        public void FindMissingNumber_OneMissingNumberSetSequentialDifference_ReturnsMissingNumber(int missingNum, int arrSize)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i <= arrSize; i++)
            {
                intList.Add(i);
            }
            intList.Remove(missingNum);
            int[] ints = intList.ToArray();


            int evaluatedMissing = ArrayEvaluator.FindMissingNumber(ints);

            Assert.Equal(missingNum, evaluatedMissing);

        }


        [Theory]
        [MemberData(nameof(VariedSequentialData))]
        public void FindMissingNumber_OneMissingVariedSequentialDifference_ReturnsMissingNumber(int missingNum, int arrSize, int difference)
        {
            List<int> intList = new List<int>();
            for (int i = 0; i <= arrSize; i++)
            {
                intList.Add(i*difference);
            }
            missingNum *= difference;
            intList.Remove(missingNum);
            int[] ints = intList.ToArray();


            int evaluatedMissing = ArrayEvaluator.FindMissingNumber(ints);

            Assert.Equal(missingNum, evaluatedMissing);
        }
        [Fact]
        public void FindMissingNumber_TwoMissing_ThrowsException()
        {
            int[] ints = new int[] { 0, 3, 4 };
            string exceptionMessage = "More than 1 number missing from list";

            Action action = () => ArrayEvaluator.FindMissingNumber(ints);

            Exception e = Assert.Throws<Exception>(action);
            Assert.Equal(exceptionMessage, e.Message);
        }


        public static IEnumerable<object[]> SequentialData()
        {
            List<object[]> list = new List<object[]>();
            for (int i = 1; i <= 100; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    list.Add(new object[] {j, i});
                }
            }
            return list;
        }
        public static IEnumerable<object[]> VariedSequentialData()
        {
            List<object[]> list = new List<object[]>();

            for (int d = 2; d < 10;  d++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        list.Add(new object[]{j, i, d});
                    }
                }
            }
            return list;
        }
    }
}
