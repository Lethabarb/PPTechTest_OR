using ParcellPartnersTechnicalTest.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.ParcelPartnersTechnicalTest.Utilities
{
    public class ArrayConverterTests
    {
        [Fact]
        public void ToIntArr_allInts_Succeeds()
        {
            string[] args = new string[] { "1", "2", "3" };
            int len = args.Length;

            int[] ints = args.ToIntArr();

            Assert.Equal(len, ints.Length);
        }

        [Theory]
        [InlineData("a", "b", "c")]
        [InlineData("0.0", "1.0", "2.0")]
        public void ToIntArr_InvalidInts_ReturnsEmptyArray(string s1, string s2, string s3)
        {
            string[] args = { s1, s2, s3 };
            int len = 0;

            int[] ints = args.ToIntArr();

            Assert.Equal(len, ints.Length);
        }
    }
}
