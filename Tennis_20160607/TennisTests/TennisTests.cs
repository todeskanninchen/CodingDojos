namespace TennisTests
{
    using FluentAssertions;

    using Tennis_20160607_2;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class TennisTests
    {
        private Tennis _tennis;

        [TestInitialize]
        public void Init()
        {
            _tennis = new Tennis();
        }

        [TestMethod]
        public void InitialScoreIsZeroZero()
        {
            _tennis.GetCurrentScore().Should().Be("0:0");
        }

        [TestMethod]
        public void GivenPlayerAScores_Once_Then_Score_Is_15_Zero()
        {
            PlayerAScoresXTimes(1);
            _tennis.GetCurrentScore().Should().Be("15:Luv");
        }

        [TestMethod]
        public void GivenPlayerBScores_Once_Then_Score_Is_Luv_15()
        {
            PlayerBScoresXTimes(1);
            _tennis.GetCurrentScore().Should().Be("Luv:15");
        }

        [TestMethod]
        public void GivenPlayerAScores_Three_Times_Then_Score_Is_40_Zero()
        {
            PlayerAScoresXTimes(3);
            _tennis.GetCurrentScore().Should().Be("40:Luv");
        }

        [TestMethod]
        public void GivenPlayerAScores_Four_Times_Then_He_Wins()
        {
            PlayerAScoresXTimes(4);
            _tennis.GetCurrentScore().Should().Be("Game player A");
        }

        [TestMethod]
        public void GivenPlayerAAndBScores_Two_Times_Then_Score_Is_30_30()
        {
            PlayerAScoresXTimes(2);
            PlayerBScoresXTimes(2);
            _tennis.GetCurrentScore().Should().Be("30:30");
        }

        private void PlayerBScoresXTimes(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _tennis.ScorePlayerB();
            }
        }

        private void PlayerAScoresXTimes(int count)
        {
            for (var i = 0; i < count; i++)
            {
                _tennis.ScorePlayerA();
            }
        }
    }
}
