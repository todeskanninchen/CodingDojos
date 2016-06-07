namespace Tennis_20160607
{
    public class Tennis
    {
        private int _scorePlayerA;

        private int _scorePlayerB;


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
            var strScorePlayerA = (score == 0)
                                      ? "Luv"
                                      : score.ToString();
            return strScorePlayerA;
        }

        public void ScorePlayerA()
        {
            _scorePlayerA += 15;
        }
    }
}