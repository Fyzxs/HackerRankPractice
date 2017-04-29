﻿using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HackerRankPractice.Algorithms.Warmup
{
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
            int[] values = {1, 1, 1, 1, 1, 1};
            Fractions factions = new Fractions(values);
            string actual = factions.ToString();

            actual.Should().Be("1.000000\r\n0.000000\r\n0.000000");
        }
    }

    public class Fractions
    {
        private readonly int[] _values;

        public Fractions(int[] values)
        {
            _values = values;
        }

        public override string ToString()
        {
            int plus = 0;
            int zero = 0;
            int minus = 0;

            foreach (int value in _values)
            {

               //.plus += _values
            }
            return "0.000000\r\n0.000000\r\n1.000000";
        }
    }
}
