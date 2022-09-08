using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace Football_Owner
{
    public partial class Formation : Form
    {
        public Graphics g;
        int posX, posY;
        public static Image _img_choose = Image.FromFile("choose.png");
        Image  _img_V;
        bool _choose1 = false, _choose2 = false, _choose3 = false;
        bool _chooseAtLeastOneTime = false;
        int pic1X, pic1Y, pic2X, pic2Y, pic3X, pic3Y,picXC,picYC;
        Game gm;
        public static Game _temp_gm;
        public static int fpic = 0;  
        
        public Formation()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            
            ChoosenPic.Image = _img_choose;
            if (fpic == 1)
            {
                _choose1 = true;
                FormationPic1.Image = Image.FromFile("Vchoose.png");
                //_img_choose = Image.FromFile("choose.png");
            }
            else
            {
                if (fpic == 2)
                {
                    _choose2 = true;
                    FormationPic2.Image = Image.FromFile("Vchoose.png");
                    //_img_choose = Image.FromFile("choose.png");
                }
                else
                {
                    if (fpic == 3)
                    {
                        _choose3 = true;
                        FormationPic3.Image = Image.FromFile("Vchoose.png");
                        //  _img_choose = Image.FromFile("choose.png");

                    }
                  

                }
            }

            _img_V = Image.FromFile("Vchoose.png");
            Player1InFormation.Image = Market._my_team[0].getImage();
            Player2InFormation.Image = Market._my_team[1].getImage();
            Player3InFormation.Image = Market._my_team[2].getImage();
            Player4InFormation.Image = Market._my_team[3].getImage();
            MENInFormation.Image = Market._my_choose.getImage();
           

            pic1X = FormationPic1.Location.X;
            pic1Y = FormationPic1.Location.Y;
            pic2X = FormationPic2.Location.X;
            pic2Y = FormationPic2.Location.Y;
            pic3X = FormationPic3.Location.X;
            pic3Y = FormationPic3.Location.Y;
            picXC = ChoosenPic.Location.X;
            picYC = ChoosenPic.Location.Y;


        }

        private void ChoosenPic_MouseMove(object sender, MouseEventArgs e)
        {
            if (_choose1 || _choose2 || _choose3)
                formationMove(ChoosenPic, e);
        }

        private bool mouseUpChoosen(PictureBox f, object sender, MouseEventArgs e, bool choosing, int x, int y)
        {
            if (choosing)
            {
                if ((ChoosenPic.Left > picXC - 302 && ChoosenPic.Left < picXC + 318) && (ChoosenPic.Top < picYC + 358))
                {
                    ChoosenPic.SetBounds(picXC, picYC, ChoosenPic.Size.Width, ChoosenPic.Size.Height);
                }
                else
                {
                    f.Image = ChoosenPic.Image;
                    f.SetBounds(x, y, ChoosenPic.Size.Width, ChoosenPic.Size.Height);
                    ChoosenPic.Image = _img_choose;
                    ChoosenPic.SetBounds(picXC, picYC, ChoosenPic.Size.Width, ChoosenPic.Size.Height);
                    choosing = false;
                }
            }
            return choosing;
        }

        private void ChoosenPic_MouseUp(object sender, MouseEventArgs e)
        {
            if (_choose1 || _choose2 || _choose3)
            {
                _choose1 = mouseUpChoosen(FormationPic1, sender, e, _choose1, pic1X, pic1Y);
                _choose2 = mouseUpChoosen(FormationPic2, sender, e, _choose2, pic2X, pic2Y);
                _choose3 = mouseUpChoosen(FormationPic3, sender, e, _choose3, pic3X, pic3Y);
            }
            if (FormationPic2.Image != Image.FromFile("Vchoose.png") && FormationPic3.Image != Image.FromFile("Vchoose.png") && FormationPic1.Image != Image.FromFile("Vchoose.png"))
            {
                _img_choose = Image.FromFile("choose.png");
            }
        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
/*            MessageBox.Show("(" + e.X + ", " +
            e.Y + ")");*/
        }

        private void formationMove(PictureBox f, MouseEventArgs e)
        {

            if (f.Image != null)
            {
                if ((e.Button == 0))
                {
                    posX = e.X;
                    posY = e.Y;
                }
                else
                {
                    f.Left = (f.Left + (e.X - posX));
                    f.Top = (f.Top + (e.Y - posY));
                }
            }
        }

        private bool formationUp(PictureBox f, MouseEventArgs e, bool choosing, int x, int y)
        {
            if (!choosing)
            {
                if ((f.Left > picXC - 302 && f.Left < picXC + 318) && (f.Top < picYC + 358))
                {
                    ChoosenPic.Image = f.Image;
                    f.Image = _img_V;
                    f.SetBounds(x, y, f.Size.Width, f.Size.Height);
                    choosing = true;
                    _chooseAtLeastOneTime = true;
                }
                else
                {
                    if (_chooseAtLeastOneTime)
                        f.SetBounds(x, y, f.Size.Width, f.Size.Height);
                    else
                    {
                        f.SetBounds(x, y, f.Size.Width, f.Size.Height);
                        ChoosenPic.Image = _img_choose;
                    }
                }
            }

            return choosing;
        }

        private void Formation_FormClosing(object sender, FormClosingEventArgs e)
        {
/*            var processes = Process.GetProcessesByName("Football Owner");
            foreach (var process in processes)
                process.Kill();*/
        }

        private void Formation_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void MENInFormation_Click(object sender, EventArgs e)
        {

        }

        private void FormationPic3_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_choose3)
                formationMove(FormationPic3, e);
        }

        private void FormationPic3_MouseUp(object sender, MouseEventArgs e)
        {
            if ((_choose1 && FormationPic3.Left > picXC - 302 && FormationPic3.Left < picXC + 318) && (FormationPic3.Top < picYC + 358))
            {
                FormationPic1.Image = ChoosenPic.Image;
                _choose1 = false;
                if (!_choose3)
                    _choose3 = formationUp(FormationPic3, e, _choose3, pic3X,pic3Y);
            }
            else
            {
                if ((_choose2 && FormationPic3.Left > picXC - 302 && FormationPic3.Left < picXC + 318) && (FormationPic3.Top < picYC + 358))
                {
                    FormationPic2.Image = ChoosenPic.Image;
                    _choose2 = false;
                    if (!_choose3)
                        _choose3 = formationUp(FormationPic3, e, _choose3, pic3X, pic3Y);
                }
                else
                {
                    if (!_choose3)
                        _choose3 = formationUp(FormationPic3, e, _choose3, pic3X, pic3Y);
                    
                }
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xml File|*.xml";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter tw = new StreamWriter(fs);
                //string x = Market._my_team[0].ToString();
                //AttackPlayer p1 = new AttackPlayer(Image.FromFile("ATT-Player" + ((1).ToString()) + ".png"));

                tw.Write("GK-Player" + Market.arrPlayer[0] + ".png" + '\n');
                tw.Write("DEF-Player" + Market.arrPlayer[1] + ".png" + '\n');
                tw.Write("MID-Player" + Market.arrPlayer[2] + ".png" + '\n');
                tw.Write("ATT-Player" + Market.arrPlayer[3] + ".png" + '\n');
                if(Market.arrPlayer[4] == 5)
                {
                    tw.Write(MarketPlace._path + '\n');
                }
                else 
                {
                    tw.Write("MEN-" + Market.arrPlayer[4] + ".png" + '\n');
                }
                
                if (_choose1)
                {
                    tw.Write("Formaition1.jpg" + '\n');
                    tw.Write("1");
                }
                else
                {
                    if (_choose2)
                    {
                        tw.Write("Formaition2.jpg" + '\n');
                        tw.Write("2");
                    }

                    else
                    {
                        if (_choose3)
                        {
                            tw.Write("Formaition3.jpg" + '\n');
                            tw.Write("3");
                        }
                        else
                        {
                            tw.Write("choose.png" + '\n');
                            tw.Write("0");
                        }
                    }
                }


                label3.Text = "File Save Successfully";
                Random r = new Random();
                label3.ForeColor = Color.FromArgb(r.Next(0, 256), r.Next(0, 256), 0);
                tw.Close();
            }
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (!_choose1 && !_choose2 && !_choose3)
            {
                MessageBox.Show("You dont choose formation !\nplease finish your selection");
            }
            else
            {
                string message = "Are you sure this is your selected formation? ";
                string title = "Continue";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {

                    //this.Controls.Clear();
                    if (_choose1)
                        gm = new Game(Image.FromFile("Formaition1.jpg"),1);
                    if (_choose2)
                        gm = new Game(Image.FromFile("Formaition2.jpg"), 2);
                    if (_choose3)
                        gm = new Game(Image.FromFile("Formaition3.jpg"), 3);
                    //gm.Show();
                    _temp_gm = gm;
                    PlayerPreform pp = new PlayerPreform();
                    pp.Show();
                    this.Hide();
                }
            }
            
        }



        private void FormationPic2_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_choose2)
                formationMove(FormationPic2, e);
        }

        private void FormationPic2_MouseUp(object sender, MouseEventArgs e)
        {
            if((_choose1 && FormationPic2.Left > picXC - 302 && FormationPic2.Left < picXC + 318) && (FormationPic2.Top < picYC + 358))
            {
                FormationPic1.Image = ChoosenPic.Image;
                _choose1 = false;
                if (!_choose2)
                    _choose2 = formationUp(FormationPic2, e, _choose2, pic2X, pic2Y);
            }
            else
            {
                if ((_choose3 && FormationPic2.Left > picXC - 302 && FormationPic2.Left < picXC + 318) && (FormationPic2.Top < picYC + 358))
                {
                    FormationPic3.Image = ChoosenPic.Image;
                    _choose3 = false;
                    if (!_choose2)
                        _choose2 = formationUp(FormationPic2, e, _choose2, pic2X, pic2Y);
                }
                else
                {
                    if (!_choose2)
                        _choose2 = formationUp(FormationPic2, e, _choose2, pic2X, pic2Y);
                }
            }
        }

        private void FormationPic1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_choose1)
                formationMove(FormationPic1, e);
        }

        private void FormationPic1_MouseUp(object sender, MouseEventArgs e)
        {
            
            if ((_choose2 && FormationPic1.Left > picXC - 302 && FormationPic1.Left < picXC + 318) && (FormationPic1.Top < picYC + 358))
            {
                FormationPic2.Image = ChoosenPic.Image;
                _choose2 = false;
                if (!_choose1)
                    _choose1 = formationUp(FormationPic1, e, _choose1, pic1X, pic1Y);
            }
            else
            {
                if ((_choose3 && FormationPic1.Left > picXC - 302 && FormationPic1.Left < picXC + 318) && (FormationPic1.Top < picYC + 358))
                {
                    FormationPic3.Image = ChoosenPic.Image;
                    _choose3 = false;
                    if (!_choose1)
                        _choose1 = formationUp(FormationPic1, e, _choose1, pic1X, pic1Y);
                }
                else
                {
                    if (!_choose1)
                    {
                        //MessageBox.Show(FormationPic1.Size.Width.ToString() + ", " + FormationPic1.Size.Height.ToString());
                        _choose1 = formationUp(FormationPic1, e, _choose1, pic1X, pic1Y);
                        
                    }
                    
                }
            }
        }

     
    }
}
