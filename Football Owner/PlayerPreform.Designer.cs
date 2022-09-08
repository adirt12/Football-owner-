
namespace Football_Owner
{
    partial class PlayerPreform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayerPreform));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ATTPIC = new System.Windows.Forms.PictureBox();
            this.MIDPIC = new System.Windows.Forms.PictureBox();
            this.DEFPIC = new System.Windows.Forms.PictureBox();
            this.GKPIC = new System.Windows.Forms.PictureBox();
            this.MANPIC = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Mute = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MIDPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEFPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GKPIC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANPIC)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 17000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1150, 765);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(-2, -6);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1150, 765);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // ATTPIC
            // 
            this.ATTPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ATTPIC.Location = new System.Drawing.Point(474, 65);
            this.ATTPIC.Margin = new System.Windows.Forms.Padding(4);
            this.ATTPIC.Name = "ATTPIC";
            this.ATTPIC.Size = new System.Drawing.Size(156, 78);
            this.ATTPIC.TabIndex = 3;
            this.ATTPIC.TabStop = false;
            this.ATTPIC.Visible = false;
            // 
            // MIDPIC
            // 
            this.MIDPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MIDPIC.Location = new System.Drawing.Point(426, 205);
            this.MIDPIC.Margin = new System.Windows.Forms.Padding(4);
            this.MIDPIC.Name = "MIDPIC";
            this.MIDPIC.Size = new System.Drawing.Size(156, 78);
            this.MIDPIC.TabIndex = 4;
            this.MIDPIC.TabStop = false;
            this.MIDPIC.Visible = false;
            // 
            // DEFPIC
            // 
            this.DEFPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DEFPIC.Location = new System.Drawing.Point(522, 364);
            this.DEFPIC.Margin = new System.Windows.Forms.Padding(4);
            this.DEFPIC.Name = "DEFPIC";
            this.DEFPIC.Size = new System.Drawing.Size(156, 78);
            this.DEFPIC.TabIndex = 5;
            this.DEFPIC.TabStop = false;
            this.DEFPIC.Visible = false;
            // 
            // GKPIC
            // 
            this.GKPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GKPIC.Location = new System.Drawing.Point(474, 544);
            this.GKPIC.Margin = new System.Windows.Forms.Padding(4);
            this.GKPIC.Name = "GKPIC";
            this.GKPIC.Size = new System.Drawing.Size(156, 78);
            this.GKPIC.TabIndex = 6;
            this.GKPIC.TabStop = false;
            this.GKPIC.Visible = false;
            // 
            // MANPIC
            // 
            this.MANPIC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MANPIC.Location = new System.Drawing.Point(949, 230);
            this.MANPIC.Margin = new System.Windows.Forms.Padding(4);
            this.MANPIC.Name = "MANPIC";
            this.MANPIC.Size = new System.Drawing.Size(156, 78);
            this.MANPIC.TabIndex = 7;
            this.MANPIC.TabStop = false;
            this.MANPIC.Visible = false;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 29000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Mute
            // 
            this.Mute.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Mute.BackgroundImage")));
            this.Mute.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Mute.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mute.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Mute.Location = new System.Drawing.Point(1029, 681);
            this.Mute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(119, 69);
            this.Mute.TabIndex = 32;
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // PlayerPreform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 750);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.GKPIC);
            this.Controls.Add(this.DEFPIC);
            this.Controls.Add(this.MIDPIC);
            this.Controls.Add(this.ATTPIC);
            this.Controls.Add(this.MANPIC);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PlayerPreform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayerPreform";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayerPreform_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayerPreform_FormClosed);
            this.Load += new System.EventHandler(this.PlayerPreform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATTPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MIDPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DEFPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GKPIC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MANPIC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ATTPIC;
        private System.Windows.Forms.PictureBox MIDPIC;
        private System.Windows.Forms.PictureBox DEFPIC;
        private System.Windows.Forms.PictureBox GKPIC;
        private System.Windows.Forms.PictureBox MANPIC;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button Mute;
    }
}