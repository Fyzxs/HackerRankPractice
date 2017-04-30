using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankPractice.Algorithms.Warmup
{
    /*
     * Given an array of integers, calculate which fraction of its elements are positive, which fraction of its elements are negative, and which fraction of its elements are zeroes, respectively. Print the decimal value of each fraction on a new line.

Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, though answers with absolute error of up to  are acceptable.

Input Format

The first line contains an integer, , denoting the size of the array. 
The second line contains  space-separated integers describing an array of numbers .

Output Format

You must print the following  lines:

A decimal representing of the fraction of positive numbers in the array compared to its size.
A decimal representing of the fraction of negative numbers in the array compared to its size.
A decimal representing of the fraction of zeroes in the array compared to its size.
Sample Input

6
-4 3 -9 0 4 1         
Sample Output

0.500000
0.333333
0.166667
*/
    [TestClass]
    public class PlusMinus
    {
        [TestMethod]
        public void ShouldBeZeroZeroOneHundred()
        {
            int[] values = {0, 0, 0, 0, 0, 0};
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("0.000000\r\n0.000000\r\n1.000000");
        }
        [TestMethod]
        public void ShouldBeOneHundredZeroZero()
        {
            int[] values = { 1, 1, 1, 1, 1, 1 };
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("1.000000\r\n0.000000\r\n0.000000");
        }
        [TestMethod]
        public void ShouldBeZeroOneHundredZero()
        {
            int[] values = { -1, -1, -1, -1, -1, -1 };
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("0.000000\r\n1.000000\r\n0.000000");
        }
        [TestMethod]
        public void ShouldBe33()
        {
            int[] values = { -1, 0, 1 };
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("0.333333\r\n0.333333\r\n0.333333");
        }
        [TestMethod]
        public void ShouldBe66033()
        {
            int[] values = { 1, -1, 1 };
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("0.666667\r\n0.333333\r\n0.000000");
        }
        [TestMethod]
        public void SampleInput()
        {
            int[] values = { -4, 3, -9, 0, 4, 1 };
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("0.500000\r\n0.333333\r\n0.166667");
        }
    }

    public class Fractions
    {
        private double _pctPlus;
        private double _pctZero;
        private double _pctNeg;
     
        public Fractions(IReadOnlyCollection<int> values)
        {
            ProcessInput(values);
        }

        public override string ToString() => new StringBuilder()
            .AppendLine($"{_pctPlus:F6}")
            .AppendLine($"{_pctNeg:F6}")
            .Append($"{_pctZero:F6}").ToString();

        private void ProcessInput(IReadOnlyCollection<int> values)
        {
            int size = values.Count;
            foreach (int value in values)
            {
                _pctPlus += PctGiven(value > 0, size);
                _pctZero += PctGiven(value == 0, size);
                _pctNeg += PctGiven(value < 0, size);
            }
        }

        private static double PctGiven(bool condition, int size) => condition ? (double)1 / size : 0;
    }
}
