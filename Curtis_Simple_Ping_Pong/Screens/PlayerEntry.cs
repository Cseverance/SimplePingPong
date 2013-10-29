using System;
using System.Windows.Forms;
using Curtis_Simple_Ping_Pong.Properties;

namespace Curtis_Simple_Ping_Pong
{
    public partial class PlayerEntry : Form
    {
        private readonly GameService _gameService;
        private readonly Form _homescreen;

        public PlayerEntry(GameService gameService, Form homescreen)
        {
            InitializeComponent();
            _gameService = gameService;
            _homescreen = homescreen;
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            if (ValidatePlayers())
            {
                _gameService.SetPlayers(TxtPlayer1.Text, TxtPlayer2.Text);
                (new Scoreboard(_gameService, _homescreen)).Show();
                Close();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _homescreen.Show();
            Close();
        }

        private bool ValidatePlayers()
        {
            if (string.IsNullOrEmpty(TxtPlayer1.Text))
            {
                MessageBox.Show(Resources.Error_Player1_Must_Be_Entered);
                return false;
            }
            if (string.IsNullOrEmpty(TxtPlayer2.Text))
            {
                MessageBox.Show(Resources.Error_Player2_Must_Be_Entered);
                return false;
            }
            return true;
        }

    }
}
