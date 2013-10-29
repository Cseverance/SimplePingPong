using NUnit.Framework;

namespace Curtis_Simple_Ping_Pong.Unit_Tests
{
    [TestFixture]
    class GameServiceTests
    {
        private GameService _gameService;
        private GameRepo _testRepo;

        [SetUp]
        public void Setup()
        {
            _testRepo = new GameRepo();
            _gameService = new GameService(_testRepo);
        }
        private void PrepareGameService(int initialP1Score, int initialP2Score)
        {
            string p1Name = "Bob";
            string p2Name = "Joe";
            _gameService.SetPlayers(p1Name, p2Name);
            _gameService.P1Score = initialP1Score;
            _gameService.P2Score = initialP2Score;
        }

        [Test]
        public void SetPlayersInitializesPlayers()
        {
            string p1Name = "Bob";
            string p2Name = "Joe";
            _gameService.SetPlayers(p1Name,p2Name);
            Assert.AreEqual(p1Name,_gameService.Player1.PlayerName);
            Assert.AreEqual(p2Name, _gameService.Player2.PlayerName);
        }
        [Test]
        public void ResetDataMakesPlayersNull()
        {
            PrepareGameService(2,2);
            _gameService.ResetData();
            Assert.IsNull(_gameService.Player1);
            Assert.IsNull(_gameService.Player2);
        }
        [Test]
        public void ResetDataResetsScore()
        {
            PrepareGameService(2, 2);
            _gameService.ResetData();
            Assert.AreEqual(0, _gameService.P1Score);
            Assert.AreEqual(0, _gameService.P2Score);
        }

        [Test]
        public void SetServiceChangesServiceIndicatorOnEvenScoreTotal()
        {
            PrepareGameService(0,2);
            Assert.IsTrue(_gameService.Player1Service);
            _gameService.SetService();
            Assert.IsFalse(_gameService.Player1Service);
        }
        [Test]
        public void SetServiceDoesNotChangeServiceIndicatorOnOddScoreTotal()
        {
            PrepareGameService(1, 0);
            Assert.IsTrue(_gameService.Player1Service);
            _gameService.SetService();
            Assert.IsTrue(_gameService.Player1Service);
        }

        [Test]
        public void CheckMercyRuleReturnsTrueWhenPlayer1Wins7To0()
        {
            PrepareGameService(7,0);
            Assert.True(_gameService.CheckMercyRule());
        }
        [Test]
        public void CheckMercyRuleReturnsTrueWhenPlayer2Wins7To0()
        {
            PrepareGameService(0, 7);
            Assert.True(_gameService.CheckMercyRule());
        }
        [Test]
        public void CheckMercyRuleReturnsFalseWhenScoreIsNot7To0()
        {
            PrepareGameService(6, 3);
            Assert.False(_gameService.CheckMercyRule());
        }

        [Test]
        public void CheckNormalWinReturnsTrueWhenPlayerOneIsAtThreshold()
        {
            PrepareGameService(11, 3);
            Assert.True(_gameService.CheckForNormalWin());
        }
        [Test]
        public void CheckNormalWinReturnsTrueWhenPlayerTwoIsAtThreshold()
        {
            PrepareGameService(5, 11);
            Assert.True(_gameService.CheckForNormalWin());
        }
        [Test]
        public void CheckNormalWinReturnsTrueWhenPlayerTwoIsAboveThreshold()
        {
            PrepareGameService(12, 14);
            Assert.True(_gameService.CheckForNormalWin());
        }
        [Test]
        public void CheckNormalWinReturnsTrueWhenPlayerOneIsAboveThreshold()
        {
            PrepareGameService(16, 14);
            Assert.True(_gameService.CheckForNormalWin());
        }
        [Test]
        public void CheckNormalWinReturnsFalseWhenScoreIsAbove11ButDifferenceIsNotGreaterThan2()
        {
            PrepareGameService(12, 13);
            Assert.False(_gameService.CheckForNormalWin());
        }
        [Test]
        public void CheckNormalWinReturnsFalseWhenScoreIsNotAWinningScore()
        {
            PrepareGameService(6, 3);
            Assert.False(_gameService.CheckForNormalWin());
        }

        [Test]
        public void IncrementScoreIncrementsCorrectScoreForPlayer1()
        {
            PrepareGameService(3,5);
            _gameService.IncrementScore(_gameService.Player1);
            Assert.AreEqual(4,_gameService.P1Score);
            Assert.AreEqual(5,_gameService.P2Score);
        }
        [Test]
        public void IncrementScoreIncrementsCorrectScoreForPlayer2()
        {
            PrepareGameService(3, 5);
            _gameService.IncrementScore(_gameService.Player2);
            Assert.AreEqual(3, _gameService.P1Score);
            Assert.AreEqual(6, _gameService.P2Score);
        }
    }
}
