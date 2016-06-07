using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TennisTests
{
    using FluentAssertions;

    using Tennis_20160607;

    [TestClass]
    public class TennisTests
    {
        [TestMethod]
        public void InitialScoreIsZeroZero()
        {
            var tennis = new Tennis();
            tennis.CalculateScore().Should().Be("0:0");
        }
    }
}
