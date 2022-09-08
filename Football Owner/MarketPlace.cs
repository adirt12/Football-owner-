using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Football_Owner
{

    public partial class MarketPlace : Form
    {
        Market m;
        public Graphics g;
        bool enable_click_on_market = false;
        bool _finish_click = false;
        bool _touch = false;
        Formation gm;
        bool _bold = false;
        public static string _path = " ";
        int _tempGK = -1, _tempDEF = -1, _tempMID = -1, _tempATT = -1, _tempMEN = -1;
        OpenFileDialog ofd;
        bool _createPanel = false, _settingPanel = false;


        public MarketPlace()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            Player.SetGraphics(g);
            Manager.SetGraphics(g);
            m = new Market();
            GoalKeepers.SetBounds(this.Size.Width / 13, this.Size.Height / 8, 200, 60);
            Defender.SetBounds(GoalKeepers.Location.X + 300, GoalKeepers.Location.Y, 200, 60);
            Midfielder.SetBounds(Defender.Location.X + 300, GoalKeepers.Location.Y, 200, 60);
            Attack.SetBounds(Midfielder.Location.X + 300, GoalKeepers.Location.Y, 200, 60);
            Managers.SetBounds(Attack.Location.X + 300, GoalKeepers.Location.Y, 200, 60);
            YourTeam.SetBounds(Managers.Location.X + 300, GoalKeepers.Location.Y, 200, 60);
            MyTeamGK.SetBounds(YourTeam.Location.X + 40, YourTeam.Location.Y + 70, 90, 90);
            MyTeamDEF.SetBounds(MyTeamGK.Location.X, MyTeamGK.Location.Y + 100, 90, 90);
            MyTeamMID.SetBounds(MyTeamGK.Location.X, MyTeamDEF.Location.Y + 100, 90, 90);
            MyTeamATT.SetBounds(MyTeamGK.Location.X, MyTeamMID.Location.Y + 100, 90, 90);
            MyTeamMEN.SetBounds(MyTeamGK.Location.X, MyTeamATT.Location.Y + 100, 90, 90);
        }
        private void MarketPlace_Load(object sender, EventArgs e)
        {
            if (_touch == false)
            {
                m.insertGoalKeepers(GoalKeepers.Location.X + 40, GoalKeepers.Location.Y + 70);
                m.insertDefenders(Defender.Location.X + 40, Defender.Location.Y + 70);
                m.insertMidfilders(Midfielder.Location.X + 40, Midfielder.Location.Y + 70);
                m.insertAttackers(Attack.Location.X + 40, Attack.Location.Y + 70);
                m.insertManagers(Managers.Location.X + 40, Managers.Location.Y + 70);
                _touch = true;
                enable_click_on_market = true;
                //this.Controls.Add(Finish);
            }

        }

        private void MarketPlace_MouseClick(object sender, MouseEventArgs e)
        {
            /*            MessageBox.Show("(" + e.X + ", " +
            e.Y + ")");*/
            if (enable_click_on_market == true)
            {
                if (_finish_click == false)
                {
                    if (MouseButtons.Left == e.Button)
                    {
                        //m.isClickMyteam(e.X, e.Y);
                        if (m.isClickOnGK(e.X, e.Y))
                        {
                            if (_tempGK != -1)
                            {
                                m.getGoalKeppersArr()[_tempGK].deleteFrame();
                            }
                            if (m.findIndexGK() != -1)
                            {
                                MyTeamGK.Visible = true;
                                MyTeamGK.Image = m.getGoalKeppersArr()[m.findIndexGK()].getImage();
                                m.getGoalKeppersArr()[m.findIndexGK()].drawFrame();
                                _tempGK = m.findIndexGK();
                                m.getMyTeam()[0].setChoose(false);
                            }
                        }
                        if (m.isClickOnDEF(e.X, e.Y))
                        {
                            if (_tempDEF != -1)
                            {
                                m.getDefendersArr()[_tempDEF].deleteFrame();
                            }
                            if (m.findIndexDEF() != -1)
                            {
                                MyTeamDEF.Visible = true;
                                MyTeamDEF.Image = m.getDefendersArr()[m.findIndexDEF()].getImage();
                                m.getDefendersArr()[m.findIndexDEF()].drawFrame();
                                _tempDEF = m.findIndexDEF();
                                m.getMyTeam()[1].setChoose(false);
                            }

                        }
                        if (m.isClickOnMID(e.X, e.Y))
                        {
                            if (_tempMID != -1)
                            {
                                m.getMidfildersArr()[_tempMID].deleteFrame();
                            }
                            if (m.findIndexMID() != -1)
                            {
                                MyTeamMID.Visible = true;
                                MyTeamMID.Image = m.getMidfildersArr()[m.findIndexMID()].getImage();
                                m.getMidfildersArr()[m.findIndexMID()].drawFrame();
                                _tempMID = m.findIndexMID();
                                m.getMyTeam()[2].setChoose(false);
                            }

                        }
                        if (m.isClickOnATT(e.X, e.Y))
                        {
                            if (_tempATT != -1)
                            {
                                m.getAttacksArr()[_tempATT].deleteFrame();
                            }
                            if (m.findIndexATT() != -1)
                            {
                                MyTeamATT.Visible = true;
                                MyTeamATT.Image = m.getAttacksArr()[m.findIndexATT()].getImage();
                                m.getAttacksArr()[m.findIndexATT()].drawFrame();
                                _tempATT = m.findIndexATT();
                                m.getMyTeam()[3].setChoose(false);
                            }
                        }

                        if (m.isClickOnMEN(e.X, e.Y))
                        {
                            if (_tempMEN != -1)
                            {
                                m.getManagerArr()[_tempMEN].deleteFrame();
                            }
                            if (m.findIndexMEN() != -1)
                            {
                                if (m.findIndexMEN() == m.sizeOfManaagerArr() - 1)
                                {
                                    _tempMEN = m.findIndexMEN();
                                    if (_settingPanel == true)
                                    {
                                        panel2.Visible = false;
                                        _settingPanel = false;
                                        panel1.Visible = true;
                                        _createPanel = true;
                                        full();
                                    }
                                    else
                                    {
                                        panel1.Visible = true;
                                        _createPanel = true;
                                        full();
                                    }
                                }
                                else
                                {
                                    MyTeamMEN.Visible = true;
                                    MyTeamMEN.Image = m.getManagerArr()[m.findIndexMEN()].getImage();
                                    m.getManagerArr()[m.findIndexMEN()].drawFrame();
                                    _tempMEN = m.findIndexMEN();
                                    m.getManagerArr()[_tempMEN].setChoose(false);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (MouseButtons.Right == e.Button)
                        {
                            int r = m.isClickComplateMyTeam(e.X, e.Y);
                            if (r == 0)
                            {
                                MyTeamGK.Visible = false;
                                MyTeamGK.Image = blackCell.Image;
                                m.getGoalKeppersArr()[_tempGK].deleteFrame();
                                _tempGK = -1;
                            }
                            if (r == 1)
                            {
                                MyTeamDEF.Visible = false;
                                MyTeamDEF.Image = blackCell.Image;
                                m.getDefendersArr()[_tempDEF].deleteFrame();
                                _tempDEF = -1;
                            }
                            if (r == 2)
                            {
                                MyTeamMID.Visible = false;
                                MyTeamMID.Image = blackCell.Image;
                                m.getMidfildersArr()[_tempMID].deleteFrame();
                                _tempMID = -1;
                            }
                            if (r == 3)
                            {
                                MyTeamATT.Visible = false;
                                MyTeamATT.Image = blackCell.Image;
                                m.getAttacksArr()[_tempATT].deleteFrame();
                                _tempATT = -1;

                            }
                            if (r == 4)
                            {
                                MyTeamMEN.Visible = false;
                                MyTeamMEN.Image = blackCell.Image;
                                m.getManagerArr()[_tempMEN].deleteFrame();

                            }
                        }
                        else
                        {
                            if (MouseButtons.Middle == e.Button)
                            {
                               // panel3.Visible = false;
                                if (m.isClickOnGK(e.X, e.Y))
                                {
                                    panel3.Visible = false;
                                    if (m.findIndexGK() != -1)
                                    {
                                        //panel3.Visible = false;
                                        panel3.Visible = true;
                                        //MessageBox.Show(m.findIndexGK().ToString());
                                        panel3.BackgroundImage = m.getGoalKeppersArr()[m.findIndexGK()].getdetailsImage();
                                        
                                    }
                                }
                                if (m.isClickOnDEF(e.X, e.Y))
                                {
                                    if (m.findIndexDEF() != -1)
                                    {
                                        panel3.Visible = true;
                                        panel3.BackgroundImage = m.getDefendersArr()[m.findIndexDEF()].getdetailsImage();
                                    }
                                }
                                if (m.isClickOnMID(e.X, e.Y))
                                {
                                    if (m.findIndexMID() != -1)
                                    {
                                        panel3.Visible = true;
                                        panel3.BackgroundImage = m.getMidfildersArr()[m.findIndexMID()].getdetailsImage();
                                    }
                                }
                                if (m.isClickOnATT(e.X, e.Y))
                                {
                                    if (m.findIndexATT() != -1)
                                    {
                                        panel3.Visible = true;
                                        panel3.BackgroundImage = m.getAttacksArr()[m.findIndexATT()].getdetailsImage();
                                    }
                                }
                            }
                        }
                    }

                }
            }
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            string message = "Are you sure this is your selected team? ";
            string title = "Continue";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (!m.isMyTeamSelected())
                MessageBox.Show("Your team is not ready!\nplease finish your selection");
            else
            {
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    _finish_click = true;
                    
                    gm = new Formation();
                    gm.Show();
                    this.Hide();
                }
            }
        }


        private void marketMovePlayers(object sender, MouseEventArgs e, Player[] arr,
            bool isBold)
        {
            int j;
            for (j = 0; j < arr.Length; j++)
            {
                if (arr[j].Inside(e.X, e.Y))
                {
                    if (!isBold)
                    {
                        arr[j].bold(true);
                        isBold = true;
                    }
                    else
                    {
                        m.removeBold(arr);
                        arr[j].bold(true);
                    }
                }
                else
                    arr[j].removeBold();
            }
        }

        private void marketMoveManager(object sender, MouseEventArgs e, Manager[] arr,
    bool isBold)
        {
            int j;
            for (j = 0; j < arr.Length; j++)
            {
                if (arr[j].Inside(e.X, e.Y))
                {
                    if (!isBold)
                    {
                        arr[j].bold(true);
                        isBold = true;
                    }
                    else
                    {
                        m.removeBoldManager(arr);
                        arr[j].bold(true);
                    }
                }
                else
                    arr[j].removeBold();
            }
        }

        private void MarketPlace_MouseMove(object sender, MouseEventArgs e)
        {
            marketMovePlayers(sender, e, m.getGoalKeppersArr(), _bold);
            marketMovePlayers(sender, e, m.getDefendersArr(), _bold);
            marketMovePlayers(sender, e, m.getMidfildersArr(), _bold);
            marketMovePlayers(sender, e, m.getAttacksArr(), _bold);
            marketMoveManager(sender, e, m.getManagerArr(), _bold);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ofd = new OpenFileDialog();
            ofd.Filter = "jpg files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                _path = ofd.FileName;
                UploadLabel.Text = "Upload successfully";
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            if (!_path.Equals(" "))
            {
                MyTeamMEN.Visible = true;
                MyTeamMEN.Image = Image.FromFile(_path);
                Market._my_choose.setImage(MyTeamMEN.Image);
                m.getManagerArr()[_tempMEN].drawFrame();
                m.getManagerArr()[_tempMEN].setChoose(false);
                panel1.Visible = false;
                full();
                UploadLabel.Text = "";
            }
            else
            {
                MessageBox.Show("Choose Image");
            }

        }

        private void Back_Click(object sender, EventArgs e)
        {
            _path = " ";
            panel1.Visible = false;
            full();
        }

        private void ContinueEdit_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            full();
        }

        private void InstuctionMarketPlace_Click(object sender, EventArgs e)
        {
            this.Hide();
            Instructions i = new Instructions();
            i.Show();
        }

        private void EXIT_GAME_Click(object sender, EventArgs e)
        {
            this.Hide();
            Play_Form pf = new Play_Form();
            pf.Show();
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            if (_createPanel == true)
            {
                _createPanel = false;
                panel1.Visible = false;
                panel2.SetBounds(0, 0, 0, this.Size.Height);
                panel2.Visible = true;
                full();
            }
            else
            {
                panel2.SetBounds(0, 0, 0, this.Size.Height);
                panel2.Visible = true;
                full();
            }
            _settingPanel = true;
        }

        private void MarketPlace_FormClosed(object sender, FormClosedEventArgs e)
        {


        }

        private void MarketPlace_Activated(object sender, EventArgs e)
        {
            full();
        }

        private void Finish_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void Setting_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void ContinueEdit_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void InstuctionMarketPlace_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            full();
        }

        private void FirstNameBox_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void textBox2_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void textBox3_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void MarketPlace_FormClosing(object sender, FormClosingEventArgs e)
        {
            var processes = Process.GetProcessesByName("Football Owner");
            foreach (var process in processes)
                process.Kill();
        }

        private void EXIT_GAME_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void Done_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void Back_KeyUp(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode.ToString() == "Tab"))
            {
                full();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            panel2.Visible = false;
        }

        private void full()
        {
            if (_tempGK != -1)
            {
                m.insertGoalKeepers(GoalKeepers.Location.X + 40, GoalKeepers.Location.Y + 70);
                m.getGoalKeppersArr()[_tempGK].drawFrame();
            }
            else
            {
                m.insertGoalKeepers(GoalKeepers.Location.X + 40, GoalKeepers.Location.Y + 70);
            }
            if (_tempDEF != -1)
            {
                m.insertDefenders(Defender.Location.X + 40, Defender.Location.Y + 70);
                m.getDefendersArr()[_tempDEF].drawFrame();
            }
            else
            {
                m.insertDefenders(Defender.Location.X + 40, Defender.Location.Y + 70);
            }
            if (_tempMID != -1)
            {
                m.insertMidfilders(Midfielder.Location.X + 40, Midfielder.Location.Y + 70);
                m.getMidfildersArr()[_tempMID].drawFrame();
            }
            else
            {
                m.insertMidfilders(Midfielder.Location.X + 40, Midfielder.Location.Y + 70);
            }
            if (_tempATT != -1)
            {
                m.insertAttackers(Attack.Location.X + 40, Attack.Location.Y + 70);
                m.getAttacksArr()[_tempATT].drawFrame();
            }
            else
            {
                m.insertAttackers(Attack.Location.X + 40, Attack.Location.Y + 70);
            }
            if (_tempMEN != -1)
            {
                m.insertManagers(Managers.Location.X + 40, Managers.Location.Y + 70);
                m.getManagerArr()[_tempMEN].drawFrame();
            }
            else
            {
                m.insertManagers(Managers.Location.X + 40, Managers.Location.Y + 70);
            }
        }
    }
}
                