namespace Tennis_20160607_2
{
    using System.Collections.Generic;

    public class Tennis
    {
        private Dictionary<int, string> _scoreMap;
        private int _scorePlayerA;

        private int _scorePlayerB;

        public Tennis()
        {
            InitializeScoreMap();
        }

        private void InitializeScoreMap()
        {
            _scoreMap = new Dictionary<int, string>
                            {
                                {
                                    0, "Luv"
                                },
                                {
                                    1, "15"
                                },
                                {
                                    3, "40"
                                }
                            };
        }

        public string GetCurrentScore()
        {
            if (_scorePlayerA == 0 && _scorePlayerB == 0)
            {
                return "0:0";
            }

            return string.Format("{0}:{1}", FormatScore(_scorePlayerA), FormatScore(_scorePlayerB));
        }

        private string FormatScore(int score)
        {
            return _scoreMap[score];
        }

        public void ScorePlayerA()
        {
            _scorePlayerA += 1;
        }
    }
}