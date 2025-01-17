using System.Drawing.Drawing2D;
using System.IO;
using System.Text.Json;

namespace Cookie
{
    public partial class Form1 : Form
    {
        private int cookieCount = 0;
        private int autoClickerCount = 0;
        private int autoClickerCost = 50;

        public Form1()
        {
            InitializeComponent();
            LoadGame();
            AutoClickerTimer.Start();
            this.FormClosing += Form1_FormClosing;
        }

        private void btnAutoClicker_Click(object sender, EventArgs e)
        {
            if (cookieCount >= autoClickerCost)
            {
                cookieCount -= autoClickerCost;
                autoClickerCount++;
                autoClickerCost += 20;
                UpdateCookieCountLabel();

                lblAutoClickerCount.Text = $"Auto-Clicker: {autoClickerCount}";
                lblAutoClickerCost.Text = $"Kosten: {autoClickerCost} Cookies";
            }
            else
            {
                MessageBox.Show("Nicht genug Cookies!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BntCookie_Click(object sender, EventArgs e)
        {
            cookieCount++;
            UpdateCookieCountLabel();
        }

        private void UpdateCookieCountLabel()
        {
            lblCookieCount.Text = $"Cookies: {cookieCount}";
        }

        private void AutoClickerTimer_Tick(object sender, EventArgs e)
        {
            cookieCount += autoClickerCount;
            UpdateCookieCountLabel();
        }

        private void lblCookieCount_Click(object sender, EventArgs e)
        {
        }

        private void lblAutoClickerCost_Click(object sender, EventArgs e)
        {
        }

        private void lblCookieCount_Click_1(object sender, EventArgs e)
        {
        }

       
        private void SaveGame()
        {
            GameState gameState = new GameState
            {
                CookieCount = cookieCount,
                AutoClickerCount = autoClickerCount,
                AutoClickerCost = autoClickerCost
            };

            string json = JsonSerializer.Serialize(gameState);
            File.WriteAllText("savegame.json", json);
        }

      
        private void LoadGame()
        {
            if (File.Exists("savegame.json"))
            {
                string json = File.ReadAllText("savegame.json");
                GameState gameState = JsonSerializer.Deserialize<GameState>(json);

                cookieCount = gameState.CookieCount;
                autoClickerCount = gameState.AutoClickerCount;
                autoClickerCost = gameState.AutoClickerCost;

                UpdateCookieCountLabel();
                lblAutoClickerCount.Text = $"Auto-Clicker: {autoClickerCount}";
                lblAutoClickerCost.Text = $"Kosten: {autoClickerCost} Cookies";
            }
        }

       
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveGame();
        }

        private class GameState
        {
            public int CookieCount { get; set; }
            public int AutoClickerCount { get; set; }
            public int AutoClickerCost { get; set; }
        }
    }
}
