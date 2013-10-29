using System;
using System.Windows.Forms;
using Curtis_Simple_Ping_Pong.Properties;

namespace Curtis_Simple_Ping_Pong
{
    public partial class Scoreboard : Form
    {
        private readonly GameService _gameService;
        private readonly Form _homeScreen;

        public Scoreboard(GameService gameService, Form homeScreen)
        {
            InitializeComponent();
            _gameService = gameService;
            _homeScreen = homeScreen;
            Redraw();
            GameOverPanel.Visible = false;
        }

        private void BtnP1Score_Click(object sender, EventArgs e)
        {
            var player1 = _gameService.Player1;
            NotifyGameOver(_gameService.UpdateScore(player1), player1);
            Redraw();
        }
        private void BtnP2Score_Click(object sender, EventArgs e)
        {
            var player2 = _gameService.Player2;
            NotifyGameOver(_gameService.UpdateScore(player2), player2);
            Redraw();
        }
        private void BtnRematch_Click(object sender, EventArgs e)
        {
            GameOverPanel.Visible = false;
            _gameService.PrepareRematch();
            Redraw();
        }
        private void BtnMain_Click(object sender, EventArgs e)
        {
            _gameService.ResetData();
            _homeScreen.Visible = true;
            Close();
        }
        private void NotifyGameOver(bool isOver, Player winningPlayer)
        {
            if (isOver)
            {
                Redraw();
                MessageBox.Show(string.Format(Resources.Msg_Winner, winningPlayer.PlayerName));
                ToggleScoreButtons(false);
                GameOverPanel.Visible = true;
            }
        }

        private void Redraw()
        {
            P1Name.Text = _gameService.Player1.PlayerName;
            P2Name.Text = _gameService.Player2.PlayerName;
            P1Score.Text = _gameService.P1Score.ToString();
            P2Score.Text = _gameService.P2Score.ToString();
            SetServiceIndicator(_gameService.Player1Service);
            ToggleScoreButtons(true);
        }
        private void SetServiceIndicator(bool isPlayer1Service)
        {
            if (isPlayer1Service)
            {
                P1ServiceIcon.Visible = true;
                P2ServiceIcon.Visible = false;
            }
            else
            {
                P1ServiceIcon.Visible = false;
                P2ServiceIcon.Visible = true;
            }
        }
        private void ToggleScoreButtons(bool enable)
        {
            if (enable)
            {
                BtnP1Score.Enabled = true;
                BtnP2Score.Enabled = true;
            }
            else
            {
                BtnP1Score.Enabled = false;
                BtnP2Score.Enabled = false;
            }
        }

    }
}
