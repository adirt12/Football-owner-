using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{
    public partial class PlayerPreform : Form
    {

        public Graphics g;
        SoundPlayer sp;
        private int sflag = 0;


        public PlayerPreform()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
        }


        private void PlayerPreform_Load(object sender, EventArgs e)
        {
            sp = new SoundPlayer("UFEA.WAV");
            sp.Play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Hide();
            ATTPIC.Show();
            MIDPIC.Show();
            DEFPIC.Show();
            GKPIC.Show();
            MANPIC.Show();
            pictureBox2.Show();

            ATTPIC.BackgroundImage = Market._my_team[3].getImage();
            MIDPIC.BackgroundImage = Market._my_team[2].getImage();
            DEFPIC.BackgroundImage = Market._my_team[1].getImage();
            GKPIC.BackgroundImage = Market._my_team[0].getImage();
            MANPIC.BackgroundImage = Market._my_choose.getImage();

            


            //timer1.Start();
            sp = new SoundPlayer("openning game.WAV");
            if (sflag == 0)
            {
                sp.Play();
            }


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            timer2.Stop();
            sp.Stop();
            Formation._temp_gm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Mute_Click(object sender, EventArgs e)
        {
            if (sflag == 0)
            {
                Mute.BackgroundImage = Image.FromFile("mute.png");
                sp.Stop();
                sflag = 1;
            }
            else
            {
                Mute.BackgroundImage = Image.FromFile("unmute.png");
                sp.Play();
                sflag = 0;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PlayerPreform_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void PlayerPreform_FormClosing(object sender, FormClosingEventArgs e)
        {
            var processes = Process.GetProcessesByName("Football Owner");
            foreach (var process in processes)
                process.Kill();
        }
    }
}
