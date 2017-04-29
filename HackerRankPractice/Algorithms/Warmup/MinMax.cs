using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DeleteMeForHackerRank
{
    [TestClass]
    public class MinMax
    {
        /*
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Input Format

A single line of five space-separated integers.

Constraints

Each integer is in the inclusive range .
Output Format

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than 32 bit integer.)

Sample Input

1 2 3 4 5
Sample Output

10 14
         */

        [TestMethod]
        public void SampleInput()
        {
            string digits = "1 2 3 4 5";

            string minMax = MinMaxFinder(digits);

            minMax.Should().Be("10 14");
        }

        [TestMethod]
        public void ForceTransform()
        {
            string digits = "2 3 4 5 6";

            string minMax = MinMaxFinder(digits);

            minMax.Should().Be("14 18");
        }

        [TestMethod]
        public void ForceSort()
        {
            string digits = "3 4 5 6 2";

            string minMax = MinMaxFinder(digits);

            minMax.Should().Be("14 18");
        }
        private static string MinMaxFinder(string numbersString)
        {
            IReadOnlyList<BigInteger> bigInts = numbersString.Split(' ').Select(digit => new BigInteger(long.Parse(digit))).ToList();

            return $"{Calcuate(bigInts, 0)} {Calcuate(bigInts, bigInts.Count - 4)}";
        }

        private static BigInteger Calcuate(IReadOnlyList<BigInteger> bigInts, int startingIndex)
        {
            BigInteger value = 0;
            for (int x = 0; x < 4; x++)
            {
                value += bigInts[startingIndex + x];
            }
            return value;
        }
    }
}
