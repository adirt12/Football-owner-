using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Football_Owner
{
    public partial class Game : Form
    {
        Image _backgroundimage;
        int _numOfFormationChoose;
        SoundPlayer sp, sd;
        int _tempNumPlayer;
        bool _startTickShotting = false;
        bool _run = false, _pass = false;
        int _tempX, _tempY;
        PictureBox _temp , _tempPlayerPass;
        int _xPass, _yPass;
        bool _secondPlayer = false;
        bool _rightPass = true;
        int _tempPlayerPassX, _tempPlayerPassY;
        private int sflag = 0;


        public Game(Image backg, int fc)
        {
            InitializeComponent();
            this._backgroundimage = backg;
            this._numOfFormationChoose = fc;
        }

        private void Game_Load(object sender, EventArgs e)
        {
            comboBoxPlayer.Visible = false;
            this.BackgroundImage = _backgroundimage;
            putPlayersInFormation();
            MenegerPic.Image = Market._my_choose.getImage();

            sp = new SoundPlayer("whistle .WAV");
            sp.Play();
            Thread.Sleep(3000);
            sd = new SoundPlayer("crowd.WAV");
            sd.PlayLooping();
        }
        public void putPlayersInFormation()
        {
            if(_numOfFormationChoose == 1)
            {
                Market._my_team[0].setXY(94, 450);
                Market._my_team[1].setXY(420, 403);
                Market._my_team[2].setXY(823, 409);
                Market._my_team[3].setXY(1360, 415);
                Player1.Image = Market._my_team[0].getImage();
                Player2.Image = Market._my_team[1].getImage();
                Player3.Image = Market._my_team[2].getImage();
                Player4.Image = Market._my_team[3].getImage();

                Player1.SetBounds(Market._my_team[0].GetX(), Market._my_team[0].GetY(), 130,130);
                Player2.SetBounds(Market._my_team[1].GetX(), Market._my_team[1].GetY(), 130, 130);
                Player3.SetBounds(Market._my_team[2].GetX(), Market._my_team[2].GetY(), 130, 130);
                Player4.SetBounds(Market._my_team[3].GetX(), Market._my_team[3].GetY(), 130, 130);
            }

            if (_numOfFormationChoose == 2)
            {
                Market._my_team[0].setXY(94, 450);
                Market._my_team[1].setXY(553, 395);
                Market._my_team[2].setXY(1141, 225);
                Market._my_team[3].setXY(1576, 432);
                Player1.Image = Market._my_team[0].getImage();
                Player2.Image = Market._my_team[1].getImage();
                Player3.Image = Market._my_team[2].getImage();
                Player4.Image = Market._my_team[3].getImage();

                Player1.SetBounds(Market._my_team[0].GetX(), Market._my_team[0].GetY(), 130, 130);
                Player2.SetBounds(Market._my_team[1].GetX(), Market._my_team[1].GetY(), 130, 130);
                Player3.SetBounds(Market._my_team[2].GetX(), Market._my_team[2].GetY(), 130, 130);
                Player4.SetBounds(Market._my_team[3].GetX(), Market._my_team[3].GetY(), 130, 130);
            }

            if (_numOfFormationChoose == 3)
            {
                Market._my_team[0].setXY(94, 450);
                Market._my_team[1].setXY(421, 272);
                Market._my_team[2].setXY(728, 686);
                Market._my_team[3].setXY(1295, 393);
                Player1.Image = Market._my_team[0].getImage();
                Player2.Image = Market._my_team[1].getImage();
                Player3.Image = Market._my_team[2].getImage();
                Player4.Image = Market._my_team[3].getImage();

                Player1.SetBounds(Market._my_team[0].GetX(), Market._my_team[0].GetY(), 130, 130);
                Player2.SetBounds(Market._my_team[1].GetX(), Market._my_team[1].GetY(), 130, 130);
                Player3.SetBounds(Market._my_team[2].GetX(), Market._my_team[2].GetY(), 130, 130);
                Player4.SetBounds(Market._my_team[3].GetX(), Market._my_team[3].GetY(), 130, 130);
            }

        }

        private void Game_MouseClick(object sender, MouseEventArgs e)
        {
/*                        MessageBox.Show("(" + e.X + ", " +
            e.Y + ")");*/
        }
        private void Player1_MouseClick(object sender, MouseEventArgs e)
        {
            if (_tempNumPlayer != 1 && _pass == true)
            {
                _xPass = e.X;
                _yPass = e.Y;
                _tempX = Player1.Location.X;
                _tempY = Player1.Location.Y;
                Player1.SetBounds(350, 40, 130, 130);
                _tempPlayerPassX = _temp.Location.X;
                _tempPlayerPassY = _temp.Location.Y;
                _temp.SetBounds(1200, 40, 130, 130);
                Ball.SetBounds(Player1.Location.X - 40, Player1.Location.Y + 50, 40, 40);
                Ball.Visible = true;
                _secondPlayer = true;
                _tempPlayerPass = Player1;
                PassTimer.Start();
                _rightPass = true;
                Player2.Enabled = false;
                Player3.Enabled = false;
                Player4.Enabled = false;
                _pass = false;

            }
            else
            {
                comboBoxPlayer.ResetText();
                createComboBox(comboBoxPlayer, 1);
                _temp = Player1;
                _tempX = Player1.Location.X;
                _tempY = Player1.Location.Y;
            }
        }

        private void Player4_MouseClick(object sender, MouseEventArgs e)
        {
            if (_tempNumPlayer != 4 && _pass == true)
            {
                _xPass = e.X;
                _yPass = e.Y;
                _tempX = Player4.Location.X;
                _tempY = Player4.Location.Y;
                Player4.SetBounds(350, 40, 130, 130);
                _tempPlayerPassX = _temp.Location.X;
                _tempPlayerPassY = _temp.Location.Y;
                _temp.SetBounds(1200, 40, 130, 130);
                Ball.SetBounds(Player4.Location.X - 40, Player4.Location.Y + 50, 40, 40);
                Ball.Visible = true;
                _secondPlayer = true;
                _tempPlayerPass = Player4;
                PassTimer.Start();
                _rightPass = true;
                Player2.Enabled = false;
                Player3.Enabled = false;
                Player1.Enabled = false;
                _pass = false;

            }
            else
            {
                comboBoxPlayer.ResetText();
                createComboBox(comboBoxPlayer, 4);
                _temp = Player4;
                _tempX = Player4.Location.X;
                _tempY = Player4.Location.Y;
            }
        }

        private void Player3_MouseClick(object sender, MouseEventArgs e)
        {
            if (_tempNumPlayer != 3 && _pass == true)
            {
                _xPass = e.X;
                _yPass = e.Y;
                _tempX = Player3.Location.X;
                _tempY = Player3.Location.Y;
                Player3.SetBounds(350, 40, 130, 130);
                _tempPlayerPassX = _temp.Location.X;
                _tempPlayerPassY = _temp.Location.Y;
                _temp.SetBounds(1200, 40, 130, 130);
                Ball.SetBounds(Player3.Location.X - 40, Player3.Location.Y + 50, 40, 40);
                Ball.Visible = true;
                _secondPlayer = true;
                _tempPlayerPass = Player3;
                PassTimer.Start();
                _rightPass = true;
                Player2.Enabled = false;
                Player4.Enabled = false;
                Player1.Enabled = false;
                _pass = false;
            }
            else
            {
                comboBoxPlayer.ResetText();
                createComboBox(comboBoxPlayer, 3);
                _temp = Player3;
                _tempX = Player3.Location.X;
                _tempY = Player3.Location.Y;
            }
        }

        public void removeItemsInComboBox(ComboBox cb)
        {
           cb.Items.Clear();
        }

        public void createComboBox(ComboBox cb ,int numPlayer)
        {
            cb.Enabled = true;
            _tempNumPlayer = numPlayer;
           removeItemsInComboBox(cb);
           cb.Items.Insert(0,"Spaciel Ability (Sound) ");
           
            if(numPlayer == 1)
            {
                cb.Items.Insert(1, "Pass");
            }
            if (numPlayer == 2)
            {
                cb.Items.Insert(1, "Pass");
            }
            if (numPlayer == 3)
            {
                cb.Items.Insert(1, "Pass");
            }
            if (numPlayer == 4)
            {
                cb.Items.Insert(1, "Pass");
                cb.Items.Insert(2, "Shooting");
                cb.Items.Insert(3, "Run");
            }
            if (numPlayer == 5)
            {
                cb.SetBounds(MenegerPic.Location.X, MenegerPic.Location.Y, 182, 33);
            }
            else
            {
                cb.SetBounds(Market._my_team[numPlayer - 1].GetX(),
                Market._my_team[numPlayer - 1].GetY(), 182, 33);
            }
            cb.Visible = true;
        }

        private void MenegerPic_Click(object sender, EventArgs e)
        {
            comboBoxPlayer.ResetText();
            createComboBox(comboBoxPlayer, 5);
        }

        private void mute1_Click(object sender, EventArgs e)
        {
            if (sflag == 0)
            {
                mute1.BackgroundImage = Image.FromFile("mute.png");
                sd.Stop();
                sflag = 1;
            }
            else
            {
                mute1.BackgroundImage = Image.FromFile("unmute.png");
                sd.PlayLooping();
                sflag = 0;
            }
        }

        private void Player2_MouseClick(object sender, MouseEventArgs e)
        {
            if (_tempNumPlayer != 2 && _pass == true)
            {
                _xPass = e.X;
                _yPass = e.Y;
                _tempX = Player2.Location.X;
                _tempY = Player2.Location.Y;
                Player2.SetBounds(350, 40, 130, 130);
                _tempPlayerPassX = _temp.Location.X;
                _tempPlayerPassY = _temp.Location.Y;
                _temp.SetBounds(1200, 40, 130, 130);
                Ball.SetBounds(Player2.Location.X - 40, Player2.Location.Y + 50, 40, 40);
                Ball.Visible = true;
                _secondPlayer = true;
                _tempPlayerPass = Player2;
                PassTimer.Start();
                _rightPass = true;
                Player4.Enabled = false;
                Player3.Enabled = false;
                Player1.Enabled = false;
                _pass = false;
            }
            else
            {
                comboBoxPlayer.ResetText();
                createComboBox(comboBoxPlayer, 2);
                _temp = Player2;
                _tempX = Player2.Location.X;
                _tempY = Player2.Location.Y;
            }

        }

        private void comboBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ball.Visible = false;
            if (comboBoxPlayer.Enabled == false)
            {
                comboBoxPlayer.Enabled = true;
            }
            object b = comboBoxPlayer.SelectedItem;
            if (b.ToString().Equals("Spaciel Ability (Sound) "))
            {
                if (_tempNumPlayer == 5)
                {
                    Market._my_choose.special_ability(sp);
                }
                else
                {
                    Market._my_team[_tempNumPlayer - 1].special_ability(sp);
                }
                comboBoxPlayer.Enabled = false;
                comboBoxPlayer.ResetText();
                Thread.Sleep(5000);
                sd = new SoundPlayer("crowd.WAV");
                sd.PlayLooping();
            }
            else
            {
                if (b.ToString().Equals("Pass"))
                {
                    _pass = true;
                    comboBoxPlayer.Enabled = false;
                }
                else
                {

                    if (b.ToString().Equals("Shooting"))
                    {

                        Ball.SetBounds(Market._my_team[_tempNumPlayer - 1].GetX() + 130, Market._my_team[_tempNumPlayer - 1].GetY() + 50, 40, 40);
                        Ball.Visible = true;
                        _startTickShotting = true;
                        ShottingTimer.Enabled = true;
                        ShottingTimer.Interval = 1;
                        ShottingTimer.Start();
                        comboBoxPlayer.Enabled = false;
                        comboBoxPlayer.ResetText();
                    }
                    else
                    {
                        {
                            if (b.ToString().Equals("Run"))
                            {
                                _run = true;
                                RunTimer.Start();
                                _temp.SetBounds(0, 0, 130, 130);
                                comboBoxPlayer.Visible = false;
                                comboBoxPlayer.ResetText();
                            }
                        }
                    }
                }
            }   
        }

        private void PassTimer_Tick(object sender, EventArgs e)
        {
           
            if(_secondPlayer == true)
            {
                
                if (Ball.Location.X < _temp.Location.X - 40 && _rightPass == true)
                {
                    Ball.SetBounds(Ball.Location.X + 40, Ball.Location.Y, 40, 40);
                }
                else
                {
                    if (Ball.Location.X > _tempPlayerPass.Location.X + 180)
                    {
                        _rightPass = false;
                        Ball.SetBounds(Ball.Location.X - 40, Ball.Location.Y, 40, 40);
                    }
                    else
                    {
                        PassTimer.Stop();
                        _tempPlayerPass.SetBounds(_tempX, _tempY, 130, 130);
                        _temp.SetBounds(_tempPlayerPassX, _tempPlayerPassY, 130, 130);
                        Ball.Visible = false;
                        Player1.Enabled = true;
                        Player2.Enabled = true;
                        Player3.Enabled = true;
                        Player4.Enabled = true;
                        comboBoxPlayer.Enabled = true;
                        comboBoxPlayer.ResetText();
                    }
                }
            }
        }

        private void ShottingTimer_Tick(object sender, EventArgs e)
        {
            if (_startTickShotting == true)
            {
                Ball.SetBounds(Ball.Location.X + 20, Ball.Location.Y, 40, 40);
                if (Ball.Location.X > 1800)
                {
                    _startTickShotting = false;
                    ShottingTimer.Stop();
                    sp = new SoundPlayer("GoalSound.wav");
                    sp.Play();
                    comboBoxPlayer.ResetText();
                    Thread.Sleep(5000);
                }
                sd = new SoundPlayer("crowd.WAV");
                sd.PlayLooping();
            }
        }

        private void Game_FormClosed(object sender, FormClosedEventArgs e)
        {
            sp.Stop();
/*            var processes = Process.GetProcessesByName("Football Owner");
            foreach (var process in processes)
                process.Kill();*/
        }

        private void RunTimer_Tick(object sender, EventArgs e)
        {
            if (_run)
            {
                if (_temp.Location.Y == 0 && _temp.Location.X < 1750) 
                {
                    _temp.SetBounds(_temp.Location.X + 80, _temp.Location.Y, 130, 130);
                }
                else
                {
                    if (_temp.Location.Y < 800)
                    {
                        _temp.SetBounds(_temp.Location.X, _temp.Location.Y + 80, 130, 130);
                    }
                    else
                    {
                        _temp.SetBounds(_tempX, _tempY, 130, 130);
                        _run = false;
                        comboBoxPlayer.Visible = true;
                    }   
                }
            }
        }
    }
}
