using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankPractice.Algorithms.Warmup
{
    [TestClass]
    public class TimeConversion
    {
        [TestMethod]
        public void Should12amBe00()
        {
            //arrange
            string input = "12:13:14AM";

            //act
            string actualTime = Militarize(input);

            //assert
            actualTime.Should().Be("00:13:14");
        }
        [TestMethod]
        public void Should12pmBe12()
        {
            //arrange
            string input = "12:13:14PM";

            //act
            string actualTime = Militarize(input);

            //assert
            actualTime.Should().Be("12:13:14");
        }

        [TestMethod]
        public void Sample()
        {
            // Arrange
            string input = "07:05:45PM";

            // Act
            string actual = Militarize(input);


            // Assert
            actual.Should().Be("19:05:45");

        }

        private string Militarize(string input)
        {
            return DateTime.Parse(input).ToString("HH:mm:ss");
        }
    }
}
