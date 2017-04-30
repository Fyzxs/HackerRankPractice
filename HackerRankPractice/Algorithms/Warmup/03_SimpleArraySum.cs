using System.Linq;
using System.Numerics;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankPractice.Algorithms.Warmup
{
    /*
     Given an array of  integers, can you find the sum of its elements?

    Input Format

    The first line contains an integer, , denoting the size of the array. 
    The second line contains  space-separated integers representing the array's elements.

    Output Format

    Print the sum of the array's elements as a single integer.

     */
    [TestClass]
    public class SimpleArraySum
    {
        [TestMethod]
        public void ShouldBeZeroGivenNoValues()
        {
            BigInteger result = SimpleArraySumming(new long[] { });
            result.Should().Be(0);
        }
        
        [TestMethod]
        public void ShouldSumNumbers()
        {
            BigInteger result = SimpleArraySumming(new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10});
            result.Should().Be(55);
        }

        [TestMethod]
        public void ShouldNotOverflowInt()
        {
            BigInteger result = SimpleArraySumming(new long[] {int.MaxValue, 1});
            result.Should().Be(new BigInteger(int.MaxValue) + new BigInteger(1));
        }

        [TestMethod]
        public void ShouldNotOverflowLong()
        {
            BigInteger result = SimpleArraySumming(new long[] { long.MaxValue, long.MaxValue });
            result.Should().Be(new BigInteger(long.MaxValue) + new BigInteger(long.MaxValue));
        }

        private static BigInteger SimpleArraySumming(long[] values)
        {
            return values.Aggregate<long, BigInteger>(0, (current, value) => current + value);
        }
    }
}
