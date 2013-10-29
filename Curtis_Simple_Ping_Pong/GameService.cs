using System;
using System.IO;

namespace Curtis_Simple_Ping_Pong
{
    public class GameService
    {
        private readonly string _saveFilePath;
        private const string FileName = "GameData.xml";
        private const int MercyThreshold = 7;
        private const int MinWinScore = 11;
        private readonly GameRepo _repository;

        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }
        public int P1Score { get; internal set; }
        public int P2Score { get; internal set; }
        public bool Player1Service { get; private set; }

        public GameService()
        {
            _saveFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PingPong");
            if (!Directory.Exists(_saveFilePath))
            {
                Directory.CreateDirectory(_saveFilePath);
            }
            _saveFilePath = Path.Combine(_saveFilePath, FileName);
            ResetData();
            _repository = GameDataUtility.LoadRepo(_saveFilePath);
        }
        internal GameService(GameRepo repository)
        {
            ResetData();
            _repository = repository;
        }

        public void ResetData()
        {
            Player1 = null;
            Player2 = null;
            ResetScore();
        }
        public void PrepareRematch()
        {
            ResetScore();
        }
        public void SetPlayers(string p1Name, string p2Name)
        {
            Player1 = new Player { PlayerName = p1Name };
            Player2 = new Player { PlayerName = p2Name };
        }

        public bool UpdateScore(Player scoringPlayer)
        {
            IncrementScore(scoringPlayer);
            if (EvaluateWinner())
            {
                SaveMatch(scoringPlayer);
                return true;
            }
            SetService();            
            return false;
        }

        private void SaveMatch(Player winningPlayer)
        {
            Player losingPlayer = winningPlayer == Player1 ? Player2 : Player1;
            _repository.GameHistory.Add(new Game { Winner = winningPlayer, Loser = losingPlayer });
            GameDataUtility.SaveRepo(_repository,_saveFilePath);
        }

        private bool EvaluateWinner()
        {
            if (CheckMercyRule() || CheckForNormalWin())
                return true;
            return false;
        }
        internal bool CheckMercyRule()
        {
            if (P1Score == 0 || P2Score == 0)
            {
                if (P1Score == MercyThreshold || P2Score == MercyThreshold)
                    return true;
            }
            return false;
        }
        internal bool CheckForNormalWin()
        {
            if (P1Score >= MinWinScore || P2Score >= MinWinScore)
            {
                if (Math.Abs(P1Score - P2Score) >= 2)
                    return true;
            }
            return false;
        }

        internal void IncrementScore(Player scoringPlayer)
        {
            if (Player1 == scoringPlayer)
                P1Score++;
            if (Player2 == scoringPlayer)
                P2Score++;
        }
        internal void SetService()
        {
            if ((P1Score + P2Score) % 2 == 0)
            {
                Player1Service = !Player1Service;
            }
        }
        private void ResetScore()
        {
            P1Score = 0;
            P2Score = 0;
            Player1Service = true;
        }

    }
}
