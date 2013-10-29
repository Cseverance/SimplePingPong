namespace Curtis_Simple_Ping_Pong
{
    partial class HomeScreen
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
            this.HomeDescription = new System.Windows.Forms.Label();
            this.BtnNewGame = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HomeDescription
            // 
            this.HomeDescription.AutoSize = true;
            this.HomeDescription.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeDescription.Location = new System.Drawing.Point(172, 201);
            this.HomeDescription.Name = "HomeDescription";
            this.HomeDescription.Size = new System.Drawing.Size(437, 37);
            this.HomeDescription.TabIndex = 0;
            this.HomeDescription.Text = "Let\'s play some ping pong!";
            // 
            // BtnNewGame
            // 
            this.BtnNewGame.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNewGame.Location = new System.Drawing.Point(272, 293);
            this.BtnNewGame.Name = "BtnNewGame";
            this.BtnNewGame.Size = new System.Drawing.Size(215, 54);
            this.BtnNewGame.TabIndex = 1;
            this.BtnNewGame.Text = "New Game";
            this.BtnNewGame.UseVisualStyleBackColor = true;
            this.BtnNewGame.Click += new System.EventHandler(this.BtnNewGame_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Font = new System.Drawing.Font("Miramonte", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHistory.Location = new System.Drawing.Point(272, 385);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(215, 54);
            this.BtnHistory.TabIndex = 2;
            this.BtnHistory.Text = "Game History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnHistory_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnNewGame);
            this.Controls.Add(this.HomeDescription);
            this.Name = "HomeScreen";
            this.Text = "Ping Pong Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HomeDescription;
        private System.Windows.Forms.Button BtnNewGame;
        private System.Windows.Forms.Button BtnHistory;
    }
}

