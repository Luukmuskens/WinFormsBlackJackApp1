namespace WinFormsBlackJackApp1
{
    public partial class Form1 : Form
    {

        private BlackJackGame game;
        public Form1()
        {
            InitializeComponent();
            game = new BlackJackGame();
            updateUI();
        }

        private void updateUI()
        {
            // Update the UI elements with the current game state
            playerScoreLabel.Text = "Player Score: " + game.GetPlayerScore();
            dealerScoreLabel.Text = "Dealer Score: " + game.GetDealerScore();
            playerCardsLabel.Text = "Player Cards: " + string.Join(", ", game.GetPlayerCards());
            dealerCardsLabel.Text = "Dealer Cards: " + string.Join(", ", game.GetDealerCards());
        }

        private void hitButton_Click(object sender, EventArgs e)
        {
            game.PlayerHit();
            updateUI();
            if (game.IsGameOver())
            {
                MessageBox.Show("Game Over! " + game.GetGameResult());
                game.ResetGame();
                updateUI();
            }
        }

        private void standButton_Click(object sender, EventArgs e)
        {
            game.PlayerStand();
            updateUI();
            if (game.IsGameOver())
            {
                MessageBox.Show("Game Over! " + game.GetGameResult());
                game.ResetGame();
                updateUI();
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            game.ResetGame();
            updateUI();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the game when the form loads
            game = new BlackJackGame();
            updateUI();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Clean up resources if needed
            game.Dispose();
        }

        private void blackjackButton_Click(object sender, EventArgs e)
        {
            // Start a new game of Blackjack
            game.StartGame();
            updateUI();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            // Reset the game state
            game.ResetGame();
            updateUI();
        }

     

        private void CheckGameState()
        {
            // Check if the game is over and display the result
            if (game.IsGameOver())
            {
                string result = game.GetGameResult();
                MessageBox.Show(result);
                game.ResetGame();
                updateUI();
            }
        }

        private void playerButton_Click(object sender, EventArgs e)
        {
            // Player's turn
            game.PlayerTurn();
            updateUI();
            if (game.IsGameOver())
            {
                MessageBox.Show("Game Over! " + game.GetGameResult());
                game.ResetGame();
                updateUI();
            }
        }

        private void dealerButton_Click(object sender, EventArgs e)
        {
            // Dealer's turn
            game.DealerTurn();
            updateUI();
            if (game.IsGameOver())
            {
                MessageBox.Show("Game Over! " + game.GetGameResult());
                game.ResetGame();
                updateUI();
            }
        }
    }
}
