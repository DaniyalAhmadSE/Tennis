namespace Tennis
{
    partial class PlayArea
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayArea));
            this.Timer_MovementUpdater = new System.Windows.Forms.Timer(this.components);
            this.Pnl_LeftWall = new System.Windows.Forms.Panel();
            this.Pnl_TopWall = new System.Windows.Forms.Panel();
            this.Lbl_Player2_Wins = new System.Windows.Forms.Label();
            this.Lbl_Player1_Wins = new System.Windows.Forms.Label();
            this.Lbl_CollisionText = new System.Windows.Forms.Label();
            this.Lbl_Collisions = new System.Windows.Forms.Label();
            this.Pnl_BottomWall = new System.Windows.Forms.Panel();
            this.Rdb_Hard = new System.Windows.Forms.RadioButton();
            this.Rdb_Easy = new System.Windows.Forms.RadioButton();
            this.Btn_Start_Reset = new System.Windows.Forms.Button();
            this.Lbl_Difficulty = new System.Windows.Forms.Label();
            this.Pnl_RightWall = new System.Windows.Forms.Panel();
            this.Paddle_Player2 = new Tennis.Models.Paddle();
            this.Paddle_Player1 = new Tennis.Models.Paddle();
            this.Ball_Tennis = new Tennis.Models.Ball();
            this.Pnl_TopWall.SuspendLayout();
            this.Pnl_BottomWall.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle_Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle_Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_Tennis)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer_MovementUpdater
            // 
            this.Timer_MovementUpdater.Interval = 10;
            this.Timer_MovementUpdater.Tick += new System.EventHandler(this.Timer_MovementUpdater_Tick);
            // 
            // Pnl_LeftWall
            // 
            this.Pnl_LeftWall.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Pnl_LeftWall.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_LeftWall.Location = new System.Drawing.Point(0, 26);
            this.Pnl_LeftWall.Margin = new System.Windows.Forms.Padding(1);
            this.Pnl_LeftWall.Name = "Pnl_LeftWall";
            this.Pnl_LeftWall.Size = new System.Drawing.Size(10, 429);
            this.Pnl_LeftWall.TabIndex = 1;
            // 
            // Pnl_TopWall
            // 
            this.Pnl_TopWall.BackColor = System.Drawing.Color.Black;
            this.Pnl_TopWall.Controls.Add(this.Lbl_Player2_Wins);
            this.Pnl_TopWall.Controls.Add(this.Lbl_Player1_Wins);
            this.Pnl_TopWall.Controls.Add(this.Lbl_CollisionText);
            this.Pnl_TopWall.Controls.Add(this.Lbl_Collisions);
            this.Pnl_TopWall.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pnl_TopWall.Location = new System.Drawing.Point(0, 0);
            this.Pnl_TopWall.Margin = new System.Windows.Forms.Padding(1);
            this.Pnl_TopWall.Name = "Pnl_TopWall";
            this.Pnl_TopWall.Size = new System.Drawing.Size(854, 45);
            this.Pnl_TopWall.TabIndex = 5;
            // 
            // Lbl_Player2_Wins
            // 
            this.Lbl_Player2_Wins.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Player2_Wins.ForeColor = System.Drawing.Color.White;
            this.Lbl_Player2_Wins.Location = new System.Drawing.Point(582, 9);
            this.Lbl_Player2_Wins.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Player2_Wins.Name = "Lbl_Player2_Wins";
            this.Lbl_Player2_Wins.Size = new System.Drawing.Size(207, 25);
            this.Lbl_Player2_Wins.TabIndex = 8;
            this.Lbl_Player2_Wins.Text = "Player 2 Wins";
            this.Lbl_Player2_Wins.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.Lbl_Player2_Wins.Visible = false;
            // 
            // Lbl_Player1_Wins
            // 
            this.Lbl_Player1_Wins.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Player1_Wins.ForeColor = System.Drawing.Color.White;
            this.Lbl_Player1_Wins.Location = new System.Drawing.Point(68, 9);
            this.Lbl_Player1_Wins.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Player1_Wins.Name = "Lbl_Player1_Wins";
            this.Lbl_Player1_Wins.Size = new System.Drawing.Size(207, 25);
            this.Lbl_Player1_Wins.TabIndex = 7;
            this.Lbl_Player1_Wins.Text = "Player 1 Wins";
            this.Lbl_Player1_Wins.Visible = false;
            // 
            // Lbl_CollisionText
            // 
            this.Lbl_CollisionText.AutoSize = true;
            this.Lbl_CollisionText.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_CollisionText.ForeColor = System.Drawing.Color.White;
            this.Lbl_CollisionText.Location = new System.Drawing.Point(341, 9);
            this.Lbl_CollisionText.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_CollisionText.Name = "Lbl_CollisionText";
            this.Lbl_CollisionText.Size = new System.Drawing.Size(141, 20);
            this.Lbl_CollisionText.TabIndex = 6;
            this.Lbl_CollisionText.Text = "Collisions —";
            // 
            // Lbl_Collisions
            // 
            this.Lbl_Collisions.AutoSize = true;
            this.Lbl_Collisions.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Collisions.ForeColor = System.Drawing.Color.White;
            this.Lbl_Collisions.Location = new System.Drawing.Point(484, 9);
            this.Lbl_Collisions.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Collisions.Name = "Lbl_Collisions";
            this.Lbl_Collisions.Size = new System.Drawing.Size(20, 20);
            this.Lbl_Collisions.TabIndex = 4;
            this.Lbl_Collisions.Text = "0";
            // 
            // Pnl_BottomWall
            // 
            this.Pnl_BottomWall.BackColor = System.Drawing.Color.Black;
            this.Pnl_BottomWall.Controls.Add(this.Rdb_Hard);
            this.Pnl_BottomWall.Controls.Add(this.Rdb_Easy);
            this.Pnl_BottomWall.Controls.Add(this.Btn_Start_Reset);
            this.Pnl_BottomWall.Controls.Add(this.Lbl_Difficulty);
            this.Pnl_BottomWall.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Pnl_BottomWall.Location = new System.Drawing.Point(0, 436);
            this.Pnl_BottomWall.Margin = new System.Windows.Forms.Padding(1);
            this.Pnl_BottomWall.Name = "Pnl_BottomWall";
            this.Pnl_BottomWall.Size = new System.Drawing.Size(854, 45);
            this.Pnl_BottomWall.TabIndex = 3;
            // 
            // Rdb_Hard
            // 
            this.Rdb_Hard.AutoSize = true;
            this.Rdb_Hard.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Hard.ForeColor = System.Drawing.Color.White;
            this.Rdb_Hard.Location = new System.Drawing.Point(245, 10);
            this.Rdb_Hard.Name = "Rdb_Hard";
            this.Rdb_Hard.Size = new System.Drawing.Size(71, 24);
            this.Rdb_Hard.TabIndex = 2;
            this.Rdb_Hard.TabStop = true;
            this.Rdb_Hard.Text = "Hard";
            this.Rdb_Hard.UseVisualStyleBackColor = false;
            // 
            // Rdb_Easy
            // 
            this.Rdb_Easy.AutoSize = true;
            this.Rdb_Easy.Checked = true;
            this.Rdb_Easy.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Easy.ForeColor = System.Drawing.Color.White;
            this.Rdb_Easy.Location = new System.Drawing.Point(168, 10);
            this.Rdb_Easy.Name = "Rdb_Easy";
            this.Rdb_Easy.Size = new System.Drawing.Size(71, 24);
            this.Rdb_Easy.TabIndex = 1;
            this.Rdb_Easy.TabStop = true;
            this.Rdb_Easy.Text = "Easy";
            this.Rdb_Easy.UseVisualStyleBackColor = false;
            // 
            // Btn_Start_Reset
            // 
            this.Btn_Start_Reset.AutoSize = true;
            this.Btn_Start_Reset.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start_Reset.ForeColor = System.Drawing.Color.White;
            this.Btn_Start_Reset.Location = new System.Drawing.Point(746, 3);
            this.Btn_Start_Reset.Name = "Btn_Start_Reset";
            this.Btn_Start_Reset.Size = new System.Drawing.Size(96, 39);
            this.Btn_Start_Reset.TabIndex = 0;
            this.Btn_Start_Reset.Text = "Start";
            this.Btn_Start_Reset.UseVisualStyleBackColor = false;
            this.Btn_Start_Reset.Click += new System.EventHandler(this.Btn_Start_Reset_Click);
            // 
            // Lbl_Difficulty
            // 
            this.Lbl_Difficulty.AutoSize = true;
            this.Lbl_Difficulty.Font = new System.Drawing.Font("OCR A Extended", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Difficulty.ForeColor = System.Drawing.Color.White;
            this.Lbl_Difficulty.Location = new System.Drawing.Point(12, 12);
            this.Lbl_Difficulty.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Lbl_Difficulty.Name = "Lbl_Difficulty";
            this.Lbl_Difficulty.Size = new System.Drawing.Size(152, 20);
            this.Lbl_Difficulty.TabIndex = 7;
            this.Lbl_Difficulty.Text = "Difficulty — ";
            // 
            // Pnl_RightWall
            // 
            this.Pnl_RightWall.BackColor = System.Drawing.Color.Transparent;
            this.Pnl_RightWall.Location = new System.Drawing.Point(844, 26);
            this.Pnl_RightWall.Margin = new System.Windows.Forms.Padding(1);
            this.Pnl_RightWall.Name = "Pnl_RightWall";
            this.Pnl_RightWall.Size = new System.Drawing.Size(10, 429);
            this.Pnl_RightWall.TabIndex = 0;
            // 
            // Paddle_Player2
            // 
            this.Paddle_Player2.BackColor = System.Drawing.Color.Transparent;
            this.Paddle_Player2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paddle_Player2.BackgroundImage")));
            this.Paddle_Player2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paddle_Player2.Location = new System.Drawing.Point(825, 191);
            this.Paddle_Player2.Name = "Paddle_Player2";
            this.Paddle_Player2.PlayerName = "Black";
            this.Paddle_Player2.Size = new System.Drawing.Size(15, 100);
            this.Paddle_Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paddle_Player2.Speed = 10;
            this.Paddle_Player2.TabIndex = 7;
            this.Paddle_Player2.TabStop = false;
            // 
            // Paddle_Player1
            // 
            this.Paddle_Player1.BackColor = System.Drawing.Color.Transparent;
            this.Paddle_Player1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Paddle_Player1.BackgroundImage")));
            this.Paddle_Player1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Paddle_Player1.Location = new System.Drawing.Point(14, 191);
            this.Paddle_Player1.Name = "Paddle_Player1";
            this.Paddle_Player1.PlayerName = "Red";
            this.Paddle_Player1.Size = new System.Drawing.Size(15, 100);
            this.Paddle_Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Paddle_Player1.Speed = 10;
            this.Paddle_Player1.TabIndex = 6;
            this.Paddle_Player1.TabStop = false;
            // 
            // Ball_Tennis
            // 
            this.Ball_Tennis.BackColor = System.Drawing.Color.Transparent;
            this.Ball_Tennis.Image = ((System.Drawing.Image)(resources.GetObject("Ball_Tennis.Image")));
            this.Ball_Tennis.Location = new System.Drawing.Point(412, 226);
            this.Ball_Tennis.Name = "Ball_Tennis";
            this.Ball_Tennis.Size = new System.Drawing.Size(30, 30);
            this.Ball_Tennis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Ball_Tennis.Speed = 5;
            this.Ball_Tennis.TabIndex = 5;
            this.Ball_Tennis.TabStop = false;
            // 
            // PlayArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(854, 481);
            this.Controls.Add(this.Paddle_Player2);
            this.Controls.Add(this.Paddle_Player1);
            this.Controls.Add(this.Pnl_BottomWall);
            this.Controls.Add(this.Ball_Tennis);
            this.Controls.Add(this.Pnl_TopWall);
            this.Controls.Add(this.Pnl_LeftWall);
            this.Controls.Add(this.Pnl_RightWall);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "PlayArea";
            this.Text = "Playground";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PlayArea_KeyDown);
            this.Pnl_TopWall.ResumeLayout(false);
            this.Pnl_TopWall.PerformLayout();
            this.Pnl_BottomWall.ResumeLayout(false);
            this.Pnl_BottomWall.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle_Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Paddle_Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball_Tennis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer Timer_MovementUpdater;
        private System.Windows.Forms.Panel Pnl_LeftWall;
        private System.Windows.Forms.Panel Pnl_TopWall;
        private System.Windows.Forms.Panel Pnl_BottomWall;
        private System.Windows.Forms.Label Lbl_Collisions;
        private Models.Ball Ball_Tennis;
        private Models.Paddle Paddle_Player1;
        private Models.Paddle Paddle_Player2;
        private System.Windows.Forms.Panel Pnl_RightWall;
        private System.Windows.Forms.Label Lbl_CollisionText;
        private System.Windows.Forms.Label Lbl_Difficulty;
        private System.Windows.Forms.Button Btn_Start_Reset;
        private System.Windows.Forms.RadioButton Rdb_Easy;
        private System.Windows.Forms.RadioButton Rdb_Hard;
        private System.Windows.Forms.Label Lbl_Player1_Wins;
        private System.Windows.Forms.Label Lbl_Player2_Wins;
    }
}

