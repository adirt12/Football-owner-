using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace Football_Owner
{
    public partial class Play_Form : Form
    {
        Market m;
        public Graphics g;

        public static string[] lines;
        public Play_Form()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
            m = new Market();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void New_Game_Click(object sender, EventArgs e)
        {
            //LoadingGame mp = new LoadingGame();
            
            MarketPlace mp = new MarketPlace();
           mp.Show();
            this.Hide();


        }

        private void Load_Game_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Filter = "xml files (*.xml)|*.xml|All Files(*.*)|*.*";

            if (ofd.ShowDialog() == DialogResult.OK)
            {

                string a = ofd.FileName;// save xml file path
                Formation form = new Formation();
               // Play_Form form1 = new Play_Form();


                XmlTextReader xtr = new XmlTextReader(a);

                lines = File.ReadAllLines(a);

                Market._my_team[0] = new GoalKepperPlayer(Image.FromFile(lines[0]), Image.FromFile(lines[0]));
                Market._my_team[1] = new DefenderPlayer(Image.FromFile(lines[1]), Image.FromFile(lines[0]));
                Market._my_team[2] = new MidfilderPlayer(Image.FromFile(lines[2]), Image.FromFile(lines[0]));
                Market._my_team[3] = new AttackPlayer(Image.FromFile(lines[3]), Image.FromFile(lines[0]));
                Market._my_choose = new Manager(Image.FromFile(lines[4]));
                Formation._img_choose = Image.FromFile(lines[5]);
               if(Int32.Parse(lines[6]) > 0)
                    Formation.fpic = Int32.Parse(lines[6]);
                form.ShowDialog();

                Hide();
            }
        }

 
        private void Play_Form_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void Play_Form_Resize(object sender, EventArgs e)
        {

        }
    }
}
