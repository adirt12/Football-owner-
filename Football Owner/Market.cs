using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Football_Owner
{
    class Market
    {
        AttackPlayer[] _attacks_arr;
        DefenderPlayer[] _defenders_arr;
        MidfilderPlayer[] _midfilders_arr;
        GoalKepperPlayer[] _goalKeppers_arr;
        Manager[] _managers_arr;
        public static Player[] _my_team;
        int[] _temp_my_team;
        int[] _tempX;
        int[] _tempY;
        static int SIZE_MANAGER = 5;
        static int SIZE = 7;
        public static int SIZE_TEAM = 4;
        public static int[] arrPlayer = new int[5];
        Player[] tempPlayers;
        int[] tempi;
        public static Manager _my_choose;
        int _tempMyChooseX;
        int _tempMyChooseY;
        int _tempIndex;


        public Market()
        {
            int i;
            _goalKeppers_arr = new GoalKepperPlayer[SIZE];
            _defenders_arr = new DefenderPlayer[SIZE];
            _midfilders_arr = new MidfilderPlayer[SIZE];
            _attacks_arr = new AttackPlayer[SIZE];
            _managers_arr = new Manager[SIZE_MANAGER];
            _my_team = new Player[SIZE_TEAM];
            _temp_my_team = new int[SIZE];
            for (i = 0; i < SIZE_TEAM; i++)
                _my_team[i] = null;
            _my_choose = null;
            _tempX = new int[SIZE];
            _tempY = new int[SIZE];
            tempPlayers = new Player[SIZE_TEAM];
            tempi = new int[SIZE];

        }

        public void insertGoalKeepers(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                _goalKeppers_arr[i] = new GoalKepperPlayer(Image.FromFile("GK-Player" + ((i + 1).ToString()) + ".png"),
                   Image.FromFile("GK-Player" + ((i + 1).ToString()) + "-Details.png"));
                _goalKeppers_arr[i].SetX(x);
                _goalKeppers_arr[i].SetY(y);
                _goalKeppers_arr[i].draw();
                y += 100;
            }
        }
        public void insertDefenders(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                _defenders_arr[i] = new DefenderPlayer(Image.FromFile("DEF-Player" + ((i + 1).ToString()) + ".png")
                    , Image.FromFile("DEF-Player" + ((i + 1).ToString()) + "-Details.png"));
                _defenders_arr[i].SetX(x);
                _defenders_arr[i].SetY(y);
                _defenders_arr[i].draw();
                y += 100;
            }
        }
        public void insertMidfilders(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                _midfilders_arr[i] = new MidfilderPlayer(Image.FromFile("MID-Player" + ((i + 1).ToString()) + ".png"),
                    Image.FromFile("MID-Player" + ((i + 1).ToString()) + "-Details.png"));
                _midfilders_arr[i].SetX(x);
                _midfilders_arr[i].SetY(y);
                _midfilders_arr[i].draw();
                y += 100;
            }
        }
        public void insertAttackers(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                _attacks_arr[i] = new AttackPlayer(Image.FromFile("ATT-Player" + ((i + 1).ToString()) + ".png"),
                    Image.FromFile("ATT-Player" + ((i + 1).ToString()) + "-Details.png"));
                _attacks_arr[i].SetX(x);
                _attacks_arr[i].SetY(y);
                _attacks_arr[i].draw();
                y += 100;
            }
        }
        public void insertManagers(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE_MANAGER; i++)
            {
                _managers_arr[i] = new Manager(Image.FromFile("MEN-" + ((i + 1).ToString()) + ".png"));
                _managers_arr[i].SetX(x);
                _managers_arr[i].SetY(y);
                _managers_arr[i].draw();
                y += 100;
            }
        }

        public static void drawMyTeam(int x, int y, int offsetX, int offsetY)
        {
            int i;
            for (i = 0; i < SIZE_TEAM; i++)
            {
                _my_team[i].SetX(x);
                _my_team[i].SetY(y);
                _my_team[i].draw();
                y += offsetY;
                x += offsetX;
            }
        }

        public GoalKepperPlayer[] getGoalKeppersArr() { return this._goalKeppers_arr; }
        public DefenderPlayer[] getDefendersArr() { return this._defenders_arr; }
        public MidfilderPlayer[] getMidfildersArr() { return this._midfilders_arr; }
        public AttackPlayer[] getAttacksArr() { return this._attacks_arr; }
        public Manager[] getManagerArr() { return this._managers_arr; }

        public Player[] getMyTeam() { return _my_team; }

        public Player[] gettempPlayers() { return tempPlayers; }
        public int[] gettempi() { return tempi; }


        public void setMyteam(Player[] mt)
        {
            _my_team = mt;
        }

        public void swapPlayers(Player p, Player[] arr, int index, int x, int y, int i)
        {
            if (_my_team[index] == null)
            {
                _tempX[index] = p.GetX();
                _tempY[index] = p.GetY();
                _my_team[index] = p;
                //_my_team[index].SetX(x);
                //_my_team[index].SetY(y);
                //_my_team[index].draw();
                _temp_my_team[index] = i;
            }
            else
            {
                arr[_temp_my_team[index]].SetX(_tempX[index]);
                arr[_temp_my_team[index]].SetY(_tempY[index]);
                arr[_temp_my_team[index]].draw();
                _tempX[index] = arr[i].GetX();
                _tempY[index] = arr[i].GetY();
                _my_team[index] = arr[i];
                // _my_team[index].SetX(x);
                //_my_team[index].SetY(y);
                // _my_team[index].draw();
                _temp_my_team[index] = i;
            }
        }

        public void swapManagers(Manager p, Manager[] arr, int i)
        {
            if (_my_choose == null)
            {
                _tempMyChooseX = p.GetX();
                _tempMyChooseY = p.GetY();
                _my_choose = p;
                //_my_team[index].SetX(x);
                //_my_team[index].SetY(y);
                //_my_team[index].draw();
                _tempIndex = i;
            }
            else
            {
                arr[_tempIndex].SetX(_tempMyChooseX);
                arr[_tempIndex].SetY(_tempMyChooseY);
                arr[_tempIndex].draw();
                _tempMyChooseX = arr[i].GetX();
                _tempMyChooseY = arr[i].GetY();
                _my_choose = arr[i];
                // _my_team[index].SetX(x);
                //_my_team[index].SetY(y);
                // _my_team[index].draw();
                _tempIndex = i;
            }
        }
        public bool isClickOnGK(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_goalKeppers_arr[i].Inside(x, y) == true)
                {
                    swapPlayers(_goalKeppers_arr[i], _goalKeppers_arr, 0, 1530, 210, i);
                    arrPlayer[0] = i + 1;
                    _goalKeppers_arr[i].setChoose(true);
                    return true;
                }
            }
            return false;
        }
        public bool isClickOnDEF(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
                if (_defenders_arr[i].Inside(x, y) == true)
                {
                    swapPlayers(_defenders_arr[i], _defenders_arr, 1, 1530, 310, i);
                    arrPlayer[1] = i + 1;
                    _defenders_arr[i].setChoose(true);
                    return true;
                }
            return false;
        }
        public bool isClickOnMID(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
                if (_midfilders_arr[i].Inside(x, y) == true)
                {
                    swapPlayers(_midfilders_arr[i], _midfilders_arr, 2, 1530, 410, i);
                    arrPlayer[2] = i + 1;
                    _midfilders_arr[i].setChoose(true);
                    return true;
                }
            return false;
        }
        public bool isClickOnATT(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE; i++)
                if (_attacks_arr[i].Inside(x, y) == true)
                {
                    swapPlayers(_attacks_arr[i], _attacks_arr, 3, 1530, 510, i);
                    arrPlayer[3] = i + 1;
                    _attacks_arr[i].setChoose(true);
                    return true;
                }
            return false;
        }

        public bool isClickOnMEN(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE_MANAGER; i++)
                if (_managers_arr[i].Inside(x, y) == true)
                {
                    swapManagers(_managers_arr[i], _managers_arr, i);
                    //arrPlayer[3] = i + 1;
                    _managers_arr[i].setChoose(true);

                    arrPlayer[4] = i + 1;
                    return true;
                }
            return false;
        }



        public bool isMyTeamSelected()
        {
            int i;
            for (i = 0; i < SIZE_TEAM; i++)
                if (_my_team[i] == null)
                    return false;
            if (_my_choose == null)
                return false;
            return true;
        }

        public void isClickMyteam(int x, int y)
        {
            isClickOnGK(x, y);
            isClickOnDEF(x, y);
            isClickOnMID(x, y);
            isClickOnATT(x, y);
        }

        public int isClickComplateMyTeam(int x, int y)
        {
            int i;
            for (i = 0; i < SIZE_TEAM; i++)
            {
                if (_my_team[i] != null)
                {
                    if (_my_team[i].Inside(x, y))
                    {
                        _my_team[i] = null;
                        return i;
                    }
                }
            }
            for (i = 0; i < SIZE_MANAGER; i++)
            {
                if (_my_choose != null)
                {
                    if (_managers_arr[i].Inside(x, y))
                    {
                        _my_choose = null;
                        return 4;
                    }
                }
            }
            return -1;
        }

        public void removeBold(Player[] arrPla)
        {
            int k;
            for (k = 0; k < arrPla.Length; k++)
            {
                arrPla[k].removeBold();
            }
        }

        public void removeBoldManager(Manager[] arrMan)
        {
            int k;
            for (k = 0; k < arrMan.Length; k++)
            {
                arrMan[k].removeBold();
            }
        }

        public void removeBoldTeam()
        {
            int k;
            for (k = 0; k < SIZE_TEAM; k++)
            {
                _my_team[k].removeBold();
            }
        }

        public void deletePlayer(int index)
        {
            _my_team[index].delete();
            _my_team[index] = null;

        }

        public int findIndexGK()
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_goalKeppers_arr[i].getChoose())
                    return i;
            }
            return -1;
        }

        public int findIndexATT()
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_attacks_arr[i].getChoose())
                    return i;
            }
            return -1;
        }

        public int findIndexDEF()
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_defenders_arr[i].getChoose())
                    return i;
            }
            return -1;
        }

        public int findIndexMID()
        {
            int i;
            for (i = 0; i < SIZE; i++)
            {
                if (_midfilders_arr[i].getChoose())
                    return i;
            }
            return -1;
        }

        public int findIndexMEN()
        {
            int i;
            for (i = 0; i < SIZE_MANAGER; i++)
            {
                if (_managers_arr[i].getChoose())
                    return i;
            }
            return -1;
        }

        public int sizeOfManaagerArr()
        {
            return SIZE_MANAGER;
        }
    }
}

