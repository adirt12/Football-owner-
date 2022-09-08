
namespace Football_Owner
{
    partial class Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Player1 = new System.Windows.Forms.PictureBox();
            this.Player4 = new System.Windows.Forms.PictureBox();
            this.Player3 = new System.Windows.Forms.PictureBox();
            this.Player2 = new System.Windows.Forms.PictureBox();
            this.comboBoxPlayer = new System.Windows.Forms.ComboBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.ShottingTimer = new System.Windows.Forms.Timer(this.components);
            this.MenegerPic = new System.Windows.Forms.PictureBox();
            this.RunTimer = new System.Windows.Forms.Timer(this.components);
            this.PassTimer = new System.Windows.Forms.Timer(this.components);
            this.mute1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenegerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Player1
            // 
            this.Player1.BackColor = System.Drawing.Color.Transparent;
            this.Player1.Location = new System.Drawing.Point(331, 316);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(150, 75);
            this.Player1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player1.TabIndex = 0;
            this.Player1.TabStop = false;
            this.Player1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player1_MouseClick);
            // 
            // Player4
            // 
            this.Player4.BackColor = System.Drawing.Color.Transparent;
            this.Player4.Location = new System.Drawing.Point(933, 316);
            this.Player4.Name = "Player4";
            this.Player4.Size = new System.Drawing.Size(150, 75);
            this.Player4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player4.TabIndex = 1;
            this.Player4.TabStop = false;
            this.Player4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player4_MouseClick);
            // 
            // Player3
            // 
            this.Player3.BackColor = System.Drawing.Color.Transparent;
            this.Player3.Location = new System.Drawing.Point(722, 316);
            this.Player3.Name = "Player3";
            this.Player3.Size = new System.Drawing.Size(150, 75);
            this.Player3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player3.TabIndex = 2;
            this.Player3.TabStop = false;
            this.Player3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player3_MouseClick);
            // 
            // Player2
            // 
            this.Player2.BackColor = System.Drawing.Color.Transparent;
            this.Player2.Location = new System.Drawing.Point(534, 316);
            this.Player2.Name = "Player2";
            this.Player2.Size = new System.Drawing.Size(150, 75);
            this.Player2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player2.TabIndex = 3;
            this.Player2.TabStop = false;
            this.Player2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Player2_MouseClick);
            // 
            // comboBoxPlayer
            // 
            this.comboBoxPlayer.FormattingEnabled = true;
            this.comboBoxPlayer.Location = new System.Drawing.Point(92, 134);
            this.comboBoxPlayer.Name = "comboBoxPlayer";
            this.comboBoxPlayer.Size = new System.Drawing.Size(182, 33);
            this.comboBoxPlayer.TabIndex = 4;
            this.comboBoxPlayer.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlayer_SelectedIndexChanged);
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Green;
            this.Ball.Image = ((System.Drawing.Image)(resources.GetObject("Ball.Image")));
            this.Ball.Location = new System.Drawing.Point(664, 177);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(41, 41);
            this.Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ball.TabIndex = 5;
            this.Ball.TabStop = false;
            this.Ball.Visible = false;
            // 
            // ShottingTimer
            // 
            this.ShottingTimer.Enabled = true;
            this.ShottingTimer.Interval = 1;
            this.ShottingTimer.Tick += new System.EventHandler(this.ShottingTimer_Tick);
            // 
            // MenegerPic
            // 
            this.MenegerPic.BackColor = System.Drawing.Color.Transparent;
            this.MenegerPic.Location = new System.Drawing.Point(-3, 825);
            this.MenegerPic.Name = "MenegerPic";
            this.MenegerPic.Size = new System.Drawing.Size(150, 128);
            this.MenegerPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MenegerPic.TabIndex = 6;
            this.MenegerPic.TabStop = false;
            this.MenegerPic.Click += new System.EventHandler(this.MenegerPic_Click);
            // 
            // RunTimer
            // 
            this.RunTimer.Enabled = true;
            this.RunTimer.Interval = 1;
            this.RunTimer.Tick += new System.EventHandler(this.RunTimer_Tick);
            // 
            // PassTimer
            // 
            this.PassTimer.Enabled = true;
            this.PassTimer.Interval = 1;
            this.PassTimer.Tick += new System.EventHandler(this.PassTimer_Tick);
            // 
            // mute1
            // 
            this.mute1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.mute1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mute1.BackgroundImage")));
            this.mute1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mute1.Location = new System.Drawing.Point(-3, 0);
            this.mute1.Name = "mute1";
            this.mute1.Size = new System.Drawing.Size(112, 51);
            this.mute1.TabIndex = 7;
            this.mute1.UseVisualStyleBackColor = false;
            this.mute1.Click += new System.EventHandler(this.mute1_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1515, 956);
            this.Controls.Add(this.mute1);
            this.Controls.Add(this.comboBoxPlayer);
            this.Controls.Add(this.Player4);
            this.Controls.Add(this.Player3);
            this.Controls.Add(this.Player2);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.MenegerPic);
            this.Controls.Add(this.Ball);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Game";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Game_FormClosed);
            this.Load += new System.EventHandler(this.Game_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Game_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.Player1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MenegerPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Player1;
        private System.Windows.Forms.PictureBox Player4;
        private System.Windows.Forms.PictureBox Player3;
        private System.Windows.Forms.PictureBox Player2;
        private System.Windows.Forms.ComboBox comboBoxPlayer;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer ShottingTimer;
        private System.Windows.Forms.PictureBox MenegerPic;
        private System.Windows.Forms.Timer RunTimer;
        private System.Windows.Forms.Timer PassTimer;
        private System.Windows.Forms.Button mute1;
    }
}