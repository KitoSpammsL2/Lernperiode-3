namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int cookieCount = 0;
        private int autoClickerCount = 0;
        private int autoClickerCost = 50;

        public Form1()
        {
            InitializeComponent();
            AutoClickerTimer.Start();
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
    }
}

