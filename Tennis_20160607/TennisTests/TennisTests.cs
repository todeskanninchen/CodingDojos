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
        public void PlayerAScoresOnce()
        {
            var tennis = new Tennis();
            tennis.CalculateScore().Should().Be("0:0");
        }
    }
}
