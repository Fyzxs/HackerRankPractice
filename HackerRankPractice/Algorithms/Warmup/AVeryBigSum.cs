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
    public class AVeryBigSum
    {
        [TestMethod]
        public void ShouldBeZeroGivenNoValues()
        {
            BigInteger result = AVeryBigSumming(new long[] { });
            result.Should().Be(0);
        }
        
        [TestMethod]
        public void ShouldSumNumbers()
        {
            BigInteger result = AVeryBigSumming(new long[] { 1000000001, 1000000002, 1000000003, 1000000004, long.MaxValue });
            result.Should().Be(9223372040854775817);
        }

        private static BigInteger AVeryBigSumming(long[] values)
        {
            return values.Aggregate<long, BigInteger>(0, (current, value) => current + value);
        }
    }
}
