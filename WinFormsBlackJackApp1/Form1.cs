using WinFormsBlackJackApp1.classes;

namespace WinFormsBlackJackApp1
{
    public partial class Form1 : Form
    {
        private BlackJack game;
        public Form1()
        {
            InitializeComponent();
            game = new BlackJack();
            UpdateUI();
        }

        private void UpdateUI()
        {
            // Update the UI elements with the current game state
            playerCardsLabel.Text = string.Join(", ", game.GetPlayerCards());
            dealerCardsLabel.Text = string.Join(", ", game.GetDealerCards());
            playerScoreLabel.Text = "Player Score: " + game.GetPlayerScore();
            dealerScoreLabel.Text = "Dealer Score: " + game.GetDealerScore();
            resultLabel.Text = game.GetResult();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            game.Start();
            listBoxGameLog.Items.Add("Nieuwe ronde gestart!");
            listBoxGameLog.Items.Add("Kaarten gedeeld.");
            UpdateUI();
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            game.PlayerHits();
            listBoxGameLog.Items.Add("Speler kiest: Hit");
            CheckGameState();
        }

    

        private void CheckGameState()
        {
            if (game.IsRoundOver())
            {
                listBoxGameLog.Items.Add("Ronde afgelopen!");
                listBoxGameLog.Items.Add(game.GetRoundResult());
                UpdateUI();
            }
        }

        private void UpdateUI()
        {
            lblScore.Text = game.GetScore();
        }

        private void btnResetScore_Click(object sender, EventArgs e)
        {
            game.ResetScore();
            listBoxGameLog.Items.Add("Score is gereset.");
            UpdateUI();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.PlayerStands();
            listBoxGameLog.Items.Add("Speler kiest: Stand");
            CheckGameState();
        }
    }
}
