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
            tennis.GetCurrentScore().Should().Be("0:0");
        }

        [TestMethod]
        public void GivenPlayerAScores_Then_Score_is_15_Zero()
        {
            var tennis = new Tennis();
            tennis.ScorePlayerA();
            tennis.GetCurrentScore().Should().Be("15:Luv");
        }
    }
}
