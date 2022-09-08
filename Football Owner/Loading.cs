using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;

namespace Football_Owner
{
    public partial class Loading : Form
    {
        SoundPlayer sp;
        public Loading()
        {
            InitializeComponent();
            //loading_lable.Parent = pictureBox1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            Hide();

            Form1 form = new Form1();
            form.ShowDialog();
            sp.Stop();
            
            //this.Hide();

        }

        private void Loading_Load(object sender, EventArgs e)
        {
        
                 sp = new SoundPlayer("EA Sports.WAV");
                sp.Play();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Loading_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp.Stop();
            var processes = Process.GetProcessesByName("Football Owner");
            foreach (var process in processes)
                process.Kill();
        }
    }
}
