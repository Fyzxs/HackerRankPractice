using System;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankPractice.Algorithms.Warmup
{
    /*
     * Colleen is turning  years old! She has  candles of various heights on her cake, and candle  has height . Because the taller candles tower over the shorter ones, Colleen can only blow out the tallest candles.

Given the  for each individual candle, find and print the number of candles she can successfully blow out.

Input Format

The first line contains a single integer, , denoting the number of candles on the cake. 
The second line contains  space-separated integers, where each integer  describes the height of candle .

Constraints

Output Format

Print the number of candles Colleen blows out on a new line.

Sample Input 0

4
3 2 1 3
Sample Output 0

2
Explanation 0

We have one candle of height , one candle of height , and two candles of height . Colleen only blows out the tallest candles, meaning the candles where . Because there are  such candles, we print  on a new line.
*/



    [TestClass]
    public class BirthdayCakeCandles
    {
        [TestMethod]
        public void FourAllSameHeight()
        {
            //arrange
            int[] candles = {1, 1, 1, 1};
            //act
            int result = BlowOut(candles);
            //assert
            result.Should().Be(4);
        }

        [TestMethod]
        public void FiveAllSameHeight()
        {
            //arrange
            int[] candles = { 1, 1, 1, 1, 1 };
            //act
            int result = BlowOut(candles);
            //assert
            result.Should().Be(5);
        }

        [TestMethod]
        public void FiveWith3Heighest()
        {
            //arrange
            int[] candles = { 1, 2, 1, 2, 2 };
            //act
            int result = BlowOut(candles);
            //assert
            result.Should().Be(3);
        }


        private static int BlowOut(int[] candles)
        {
            int heighest = candles.Max();
            return candles.Count(x => x == heighest);
        }
    }
}
