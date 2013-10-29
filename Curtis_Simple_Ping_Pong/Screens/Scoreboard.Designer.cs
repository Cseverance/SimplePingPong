namespace Curtis_Simple_Ping_Pong
{
    partial class Scoreboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.P1Score = new System.Windows.Forms.Label();
            this.P2Score = new System.Windows.Forms.Label();
            this.P1ServiceIcon = new System.Windows.Forms.PictureBox();
            this.P2ServiceIcon = new System.Windows.Forms.PictureBox();
            this.P2Name = new System.Windows.Forms.Label();
            this.P1Name = new System.Windows.Forms.Label();
            this.BtnP1Score = new System.Windows.Forms.Button();
            this.BtnP2Score = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.BtnRematch = new System.Windows.Forms.Button();
            this.BtnMain = new System.Windows.Forms.Button();
            this.GameOverPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.P1ServiceIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2ServiceIcon)).BeginInit();
            this.GameOverPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // P1Score
            // 
            this.P1Score.AutoSize = true;
            this.P1Score.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Score.Location = new System.Drawing.Point(127, 170);
            this.P1Score.Name = "P1Score";
            this.P1Score.Size = new System.Drawing.Size(47, 57);
            this.P1Score.TabIndex = 0;
            this.P1Score.Text = "0";
            // 
            // P2Score
            // 
            this.P2Score.AutoSize = true;
            this.P2Score.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Score.Location = new System.Drawing.Point(467, 170);
            this.P2Score.Name = "P2Score";
            this.P2Score.Size = new System.Drawing.Size(47, 57);
            this.P2Score.TabIndex = 1;
            this.P2Score.Text = "0";
            // 
            // P1ServiceIcon
            // 
            this.P1ServiceIcon.Image = global::Curtis_Simple_Ping_Pong.Properties.Resources.ServiceIcon;
            this.P1ServiceIcon.InitialImage = global::Curtis_Simple_Ping_Pong.Properties.Resources.ServiceIcon;
            this.P1ServiceIcon.Location = new System.Drawing.Point(180, 196);
            this.P1ServiceIcon.Name = "P1ServiceIcon";
            this.P1ServiceIcon.Size = new System.Drawing.Size(31, 31);
            this.P1ServiceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P1ServiceIcon.TabIndex = 2;
            this.P1ServiceIcon.TabStop = false;
            // 
            // P2ServiceIcon
            // 
            this.P2ServiceIcon.Image = global::Curtis_Simple_Ping_Pong.Properties.Resources.ServiceIcon;
            this.P2ServiceIcon.InitialImage = global::Curtis_Simple_Ping_Pong.Properties.Resources.ServiceIcon;
            this.P2ServiceIcon.Location = new System.Drawing.Point(520, 196);
            this.P2ServiceIcon.Name = "P2ServiceIcon";
            this.P2ServiceIcon.Size = new System.Drawing.Size(31, 31);
            this.P2ServiceIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P2ServiceIcon.TabIndex = 3;
            this.P2ServiceIcon.TabStop = false;
            // 
            // P2Name
            // 
            this.P2Name.AutoSize = true;
            this.P2Name.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P2Name.Location = new System.Drawing.Point(467, 249);
            this.P2Name.Name = "P2Name";
            this.P2Name.Size = new System.Drawing.Size(191, 57);
            this.P2Name.TabIndex = 4;
            this.P2Name.Text = "Player Two";
            // 
            // P1Name
            // 
            this.P1Name.AutoSize = true;
            this.P1Name.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.P1Name.Location = new System.Drawing.Point(127, 249);
            this.P1Name.Name = "P1Name";
            this.P1Name.Size = new System.Drawing.Size(196, 57);
            this.P1Name.TabIndex = 5;
            this.P1Name.Text = "Player One";
            // 
            // BtnP1Score
            // 
            this.BtnP1Score.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP1Score.Location = new System.Drawing.Point(137, 330);
            this.BtnP1Score.Name = "BtnP1Score";
            this.BtnP1Score.Size = new System.Drawing.Size(186, 71);
            this.BtnP1Score.TabIndex = 6;
            this.BtnP1Score.Text = "Point!";
            this.BtnP1Score.UseVisualStyleBackColor = true;
            this.BtnP1Score.Click += new System.EventHandler(this.BtnP1Score_Click);
            // 
            // BtnP2Score
            // 
            this.BtnP2Score.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnP2Score.Location = new System.Drawing.Point(477, 330);
            this.BtnP2Score.Name = "BtnP2Score";
            this.BtnP2Score.Size = new System.Drawing.Size(186, 71);
            this.BtnP2Score.TabIndex = 7;
            this.BtnP2Score.Text = "Point!";
            this.BtnP2Score.UseVisualStyleBackColor = true;
            this.BtnP2Score.Click += new System.EventHandler(this.BtnP2Score_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Showcard Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(204, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(398, 60);
            this.Title.TabIndex = 8;
            this.Title.Text = "Current Score";
            // 
            // BtnRematch
            // 
            this.BtnRematch.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRematch.Location = new System.Drawing.Point(19, 29);
            this.BtnRematch.Name = "BtnRematch";
            this.BtnRematch.Size = new System.Drawing.Size(126, 48);
            this.BtnRematch.TabIndex = 9;
            this.BtnRematch.Text = "Rematch";
            this.BtnRematch.UseVisualStyleBackColor = true;
            this.BtnRematch.Click += new System.EventHandler(this.BtnRematch_Click);
            // 
            // BtnMain
            // 
            this.BtnMain.Font = new System.Drawing.Font("Miramonte", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMain.Location = new System.Drawing.Point(360, 29);
            this.BtnMain.Name = "BtnMain";
            this.BtnMain.Size = new System.Drawing.Size(126, 48);
            this.BtnMain.TabIndex = 10;
            this.BtnMain.Text = "Main Menu";
            this.BtnMain.UseVisualStyleBackColor = true;
            this.BtnMain.Click += new System.EventHandler(this.BtnMain_Click);
            // 
            // GameOverPanel
            // 
            this.GameOverPanel.Controls.Add(this.BtnRematch);
            this.GameOverPanel.Controls.Add(this.BtnMain);
            this.GameOverPanel.Location = new System.Drawing.Point(148, 450);
            this.GameOverPanel.Name = "GameOverPanel";
            this.GameOverPanel.Size = new System.Drawing.Size(501, 100);
            this.GameOverPanel.TabIndex = 11;
            // 
            // Scoreboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.ControlBox = false;
            this.Controls.Add(this.GameOverPanel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.BtnP2Score);
            this.Controls.Add(this.BtnP1Score);
            this.Controls.Add(this.P1Name);
            this.Controls.Add(this.P2Name);
            this.Controls.Add(this.P2ServiceIcon);
            this.Controls.Add(this.P1ServiceIcon);
            this.Controls.Add(this.P2Score);
            this.Controls.Add(this.P1Score);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Scoreboard";
            this.ShowIcon = false;
            this.Text = "Scoreboard";
            ((System.ComponentModel.ISupportInitialize)(this.P1ServiceIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.P2ServiceIcon)).EndInit();
            this.GameOverPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label P1Score;
        private System.Windows.Forms.Label P2Score;
        private System.Windows.Forms.PictureBox P1ServiceIcon;
        private System.Windows.Forms.PictureBox P2ServiceIcon;
        private System.Windows.Forms.Label P2Name;
        private System.Windows.Forms.Label P1Name;
        private System.Windows.Forms.Button BtnP1Score;
        private System.Windows.Forms.Button BtnP2Score;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button BtnRematch;
        private System.Windows.Forms.Button BtnMain;
        private System.Windows.Forms.Panel GameOverPanel;
    }
}