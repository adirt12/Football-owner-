using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Football_Owner
{
    class AttackPlayer: Player
    {
        private int _shooting;
        private int _dribble;
        private int _speed;

        public AttackPlayer(string first_name, string last_name, char gender
            ,  Date birthday, int rating, int value, char foot,
            int salary, string football_club, int seniority, int height, int weight,Image im,Image detailsImage, int shooting, int dribble, int speed) : base(first_name,last_name, gender
            ,    birthday,  rating, value, foot,
             salary,  football_club,  seniority,  height,  weight,im, detailsImage)
        {
            this._shooting = shooting;
            this._dribble = dribble;
            this._speed = speed;
        }

        public AttackPlayer(Image img, Image detailsImage) : base(img, detailsImage)
        {

        }
        public int getShooting() { return this._shooting; }
        public int getDribble() { return this._dribble; }
        public int getSpeed() { return this._speed; }

        public void setShooting(int shooting) { this._shooting = shooting; }
        public void setDribble(int dribble) { this._dribble = dribble; }
        public void setSpeed(int speed) { this._speed = speed; }


        public override void special_ability(SoundPlayer sp)
        {
            sp = new SoundPlayer("Goal!.wav");
            sp.Play();
        }
        public string dataAttackPlayer()
        {
            return "Attack Player : " + dataPlayer() +
                 "Shooting: " + _shooting + "\n" +
                 "Dribble: " + _dribble + "\n" +
                 "Speed: " + _speed + "\n";
        }

    }
}
