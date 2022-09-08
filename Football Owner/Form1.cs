using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Football_Owner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
            
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play_Form f = new Play_Form();
            f.Show();
            
        }

        private void Instructions_Click(object sender, EventArgs e)
        {
            Instructions i = new Instructions();
            i.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
/*            var processes = Process.GetProcessesByName("Football Owner");
            foreach (var process in processes)
                process.Kill();*/
        }
    }
}
