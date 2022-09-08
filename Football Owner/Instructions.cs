using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{
    public partial class Instructions : Form
    {
        int _current = 1;
        public Instructions()
        {
            InitializeComponent();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            Back.Visible = false;
            Play.Visible = false;
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (_current > 0)
            {
                Back.Visible = true;
                if(_current < 11)
                {
                    Next.Visible = true;
                    _current++;
                    BackgroundImage = Image.FromFile("Instractions-pic" + _current.ToString() + ".png");
                }
                else
                {
                    Next.Visible = false;
                    Play.Visible = true;
                }
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            _current--;
            if (_current > 0)
            {
                Next.Visible = true;
                Play.Visible = false;
                if (_current == 1)
                    Back.Visible = false;
                BackgroundImage = Image.FromFile("Instractions-pic" + _current.ToString() + ".png");
            }
        }

        private void Play_Click(object sender, EventArgs e)
        {
            this.Hide();
            MarketPlace mp = new MarketPlace();
            mp.Show();
        }
    }
}
