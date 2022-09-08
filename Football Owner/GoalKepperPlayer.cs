using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Football_Owner
{
    class GoalKepperPlayer : Player
    {
        private int _catchBall;
        private int _jumping;

        public GoalKepperPlayer(string first_name, string last_name, char gender
            ,  Date birthday, int rating, int value, char foot,
            int salary, string football_club, int seniority, int height, int weight,Image im,Image detailsImage, int catchBall, int jumping) : base(first_name, last_name, gender
            ,  birthday, rating, value, foot,
             salary, football_club, seniority, height, weight,im, detailsImage)
        {
            this._catchBall = catchBall;
            this._jumping = jumping;
        }

        public GoalKepperPlayer(Image img, Image detailsImage) :base(img, detailsImage)
        {
            
        }



        public int getCatchBall()
        {
            return _catchBall;
        }

        public int getJumping()
        {
            return _jumping;
        }
        public void setCatchBall(int catchBall)
        {
            this._catchBall = catchBall;
        }
        public void setJumping(int jumping)
        {
            this._jumping = jumping;
        }

        public string dataGoalKepperPlayer()
        {
            return "GoalKepper : " + '\n' + dataPlayer() + "Jumping:" + _jumping
                + '\n' + "catchBall:" + _catchBall;
        }

        public override void special_ability(SoundPlayer sp)
        {
            sp = new SoundPlayer("Tov Shoer.wav");
            sp.Play();
        }
    }
}