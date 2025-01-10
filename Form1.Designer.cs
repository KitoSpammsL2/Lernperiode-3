namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            BntCookie = new Button();
            lblCookieCount = new Label();
            btnAutoClicker = new Button();
            lblAutoClickerCount = new Label();
            lblAutoClickerCost = new Label();
            AutoClickerTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // BntCookie
            // 
            BntCookie.AccessibleRole = AccessibleRole.None;
            BntCookie.BackColor = SystemColors.ButtonHighlight;
            BntCookie.Image = Properties.Resources.purepng_com_cookiescookiessnacksbaked_snacksflour_cookieschocolate_cookies_1411527249039ulhcg;
            BntCookie.Location = new Point(246, 168);
            BntCookie.Name = "BntCookie";
            BntCookie.Size = new Size(286, 111);
            BntCookie.TabIndex = 0;
            BntCookie.Text = "Cookie";
            BntCookie.UseVisualStyleBackColor = false;
            BntCookie.Click += BntCookie_Click;
            // 
            // lblCookieCount
            // 
            lblCookieCount.AutoSize = true;
            lblCookieCount.Location = new Point(538, 185);
            lblCookieCount.Name = "lblCookieCount";
            lblCookieCount.Size = new Size(76, 20);
            lblCookieCount.TabIndex = 1;
            lblCookieCount.Text = "Cookies: 0";
            lblCookieCount.Click += lblCookieCount_Click;
            // 
            // btnAutoClicker
            // 
            btnAutoClicker.Location = new Point(255, 59);
            btnAutoClicker.Name = "btnAutoClicker";
            btnAutoClicker.Size = new Size(277, 77);
            btnAutoClicker.TabIndex = 2;
            btnAutoClicker.Text = "Auto-Clicker kaufen";
            btnAutoClicker.UseVisualStyleBackColor = true;
            btnAutoClicker.Click += btnAutoClicker_Click;
            // 
            // lblAutoClickerCount
            // 
            lblAutoClickerCount.AutoSize = true;
            lblAutoClickerCount.Location = new Point(557, 71);
            lblAutoClickerCount.Name = "lblAutoClickerCount";
            lblAutoClickerCount.Size = new Size(106, 20);
            lblAutoClickerCount.TabIndex = 3;
            lblAutoClickerCount.Text = "Auto-Clicker: 0";
            // 
            // lblAutoClickerCost
            // 
            lblAutoClickerCost.AutoSize = true;
            lblAutoClickerCost.Location = new Point(557, 102);
            lblAutoClickerCost.Name = "lblAutoClickerCost";
            lblAutoClickerCost.Size = new Size(133, 20);
            lblAutoClickerCost.TabIndex = 4;
            lblAutoClickerCost.Text = "Kosten: 50 Cookies";
            lblAutoClickerCost.Click += lblAutoClickerCost_Click;
            // 
            // AutoClickerTimer
            // 
            AutoClickerTimer.Interval = 1000;
            AutoClickerTimer.Tick += AutoClickerTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAutoClickerCost);
            Controls.Add(lblAutoClickerCount);
            Controls.Add(btnAutoClicker);
            Controls.Add(lblCookieCount);
            Controls.Add(BntCookie);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button BntCookie;
        private Label lblCookieCount;
        private Button btnAutoClicker;
        private Label lblAutoClickerCount;
        private Label lblAutoClickerCost;
        private System.Windows.Forms.Timer AutoClickerTimer;
    }
}
