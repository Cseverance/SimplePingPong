using System;
using System.Windows.Forms;
using Curtis_Simple_Ping_Pong.Properties;

namespace Curtis_Simple_Ping_Pong
{
    public partial class HomeScreen : Form
    {
        private readonly GameService _gameService;
        public HomeScreen()
        {
            InitializeComponent();
            _gameService = new GameService();
        }

        private void BtnNewGame_Click(object sender, EventArgs e)
        {
            new PlayerEntry(_gameService,this).Show();
            Hide();
        }

        private void BtnHistory_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Resources.Error_Not_Implemented);
        }
    }
}
