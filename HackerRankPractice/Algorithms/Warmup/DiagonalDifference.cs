using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankPractice.Algorithms.Warmup
{
    [TestClass]
    public class DiagonalDifference
    {
        [TestMethod]
        public void DifferenceIs15ForExample()
        {
            const string input = "11 2 4\r\n4 5 6\r\n10 8 -12";
            int diff = CalculateDifference(3, BuildMatrix(input));
            diff.Should().Be(15);
        }

        [TestMethod]
        public void DifferenceIs16ForExample()
        {
            const string input = "10 2 4\r\n5 4 6\r\n10 8 -12";
            int diff = CalculateDifference(3, BuildMatrix(input));
            diff.Should().Be(16);
        }

        [TestMethod]
        public void CalculateInOnePass()
        {
            const int size = 4;
            const string input = "20 2 4 1\r\n5 4 6 1\r\n10 8 -12 1\r\n1 1 1 1";
            int primary = 0;
            int secondary = 0;

            int rowIndex = 0;
            foreach (string line in input.Split(new[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries))
            {
                int ctr = 0;
                foreach (string entry in line.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries))
                {
                    int val = int.Parse(entry);

                    primary += ctr == PrimaryCol(size, rowIndex) ? val : 0;
                    secondary += ctr == SecondaryCol(size, rowIndex) ? val : 0;

                    ctr++;
                }
                rowIndex++;
            }

            Math.Abs(primary - secondary).Should().Be(3);

        }
        private delegate int DiagIndex(int x, int y);

        private static readonly DiagIndex PrimaryCol = (size, rowIndex) => rowIndex;
        private static readonly DiagIndex SecondaryCol = (size, rowIndex) => size - 1 - rowIndex;

        private int CalculateDifference(int size, int[,] matrix)
        {
            int primary = 0;
            int secondary = 0;
            for (int rowIndex = 0; rowIndex < size; rowIndex++)
            {
                primary += matrix[rowIndex, rowIndex];
                secondary += matrix[rowIndex, size - (rowIndex+1)];
            }

            return Math.Abs(primary - secondary);
        }

        private static int[,] BuildMatrix(string input)
        {
            int[,] matrix = new int[3, 3];

            int i = 0;
            foreach (string line in input.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries))
            {
                int j = 0;
                foreach (string entry in line.Split(new[] {" "}, StringSplitOptions.RemoveEmptyEntries))
                {
                    matrix[i, j++] = int.Parse(entry);
                }
                i++;
            }
            return matrix;
        }
    }
}
