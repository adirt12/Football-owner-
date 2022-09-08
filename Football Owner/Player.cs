using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace Football_Owner
{
    class Player : Person
    {
        private int _rating;
        private int _value;
        private char _foot; // 'r' - right, 'l' - left , 'b' - both
        private int _salary;
        private string _football_club;
        private int _seniority;
        private int _height; // in cm
        private int _weight; // in kg
        private Image _image_player;
        private Point _location;
        private static Graphics g;
        private static Size PictureSizeOnScreen = new Size(90, 90);
        private Image _detailsImage;
        private bool _choose;

        public Player(string first_name, string last_name, char gender
            , Date birthday, int rating, int value, char foot,
            int salary, string football_club, int seniority, int height, int weight, Image im, Image detailsImage) : base(first_name, last_name, gender, birthday)
        {
            this._rating = rating;
            this._value = value;
            this._foot = foot;
            this._salary = salary;
            this._football_club = football_club;
            this._seniority = seniority;
            this._height = height;
            this._weight = weight;
            this._image_player = im;
            this._detailsImage = detailsImage;
            _choose = false;

        }

        public Player(Image img, Image detailsImage) : base()
        {
            this._image_player = img;
            this._detailsImage = detailsImage;
        }
        public int getRating() { return this._rating; }
        public int getValue() { return this._value; }
        public char getFoot() { return this._foot; }
        public int getSalary() { return this._salary; }
        public string getFootballClub() { return this._football_club; }
        public int getSeniority() { return this._seniority; }
        public int getHeight() { return this._height; }
        public int getWeight() { return this._weight; }
        public Image getImage() { return this._image_player; }
        public Image getdetailsImage() { return this._detailsImage; }
        public bool getChoose() { return this._choose; }

        public int GetX() { return _location.X; }
        public int GetY() { return _location.Y; }




        public void setRating(int rating) { this._rating = rating; }
        public void setValue(int value) { this._value = value; }
        public void setFoot(char foot) { this._foot = foot; }
        public void setSalary(int salary) { this._salary = salary; }
        public void setSeniority(int seniority) { this._seniority = seniority; }
        public void setFootballClub(string football_club) { this._football_club = football_club; }
        public void setHeight(int height) { this._height = height; }
        public void setWeight(int weight) { this._weight = weight; }
        public void setImage(Image im) { this._image_player = im; }
        public void setdetailsImage(Image detailsImage) { this._detailsImage = detailsImage; }

        public void SetX(int X) { this._location.X = X; }
        public void SetY(int Y) { this._location.Y = Y; }
        public static void SetGraphics(Graphics SetGraphics) { g = SetGraphics; }
        public void setChoose(bool choose) { this._choose = choose; }

        public override void special_ability(SoundPlayer sp)
        {
            throw new NotImplementedException();
        }

        public string dataPlayer()
        {
            return "Player Card :\n\n" +
            "First Name: " + getFirstName() + "\n" +
            "Last Name: " + getLastName() + "\n" +
            "Gender: " + getGender() + "\n" +
            "Age: " + getAge() + "\n" +
            "Rating: " + _rating + "\n" +
            "Football Club: " + _football_club + "\n" +
            "Seniority: " + _seniority + "/n" +
            "Foot: " + _foot + "\n" +
            "Salary: " + _salary + "\n" +
            "Value: " + _value + "\n" +
            "Height: " + _height + "\n" +
            "Weight: " + _weight + "\n";
        }

        public void draw()
        {
            g.DrawImage(this._image_player, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
        }

        public bool Inside(int x, int y)
        {
            if (x > _location.X && x < _location.X + PictureSizeOnScreen.Width &&
                y > _location.Y && y < _location.Y + PictureSizeOnScreen.Height)
            {
                return true;
            }
            else
                return false;
        }

        public void setXY(int x, int y)
        {
            SetX(x);
            SetY(y);
        }

        public void bold(bool b)
        {
            if (b)
            {
                Pen p = new Pen(Color.Green, 5);
                g.DrawRectangle(p, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
            }
            else
            {
                Pen p = new Pen(Color.Black, 5);
                g.DrawRectangle(p, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
            }
        }
        public void removeBold()
        {
            Pen p = new Pen(Color.Black, 5);
            g.DrawRectangle(p, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
        }

        public void delete()
        {
            SolidBrush blueBrush = new SolidBrush(Color.Black);
            g.FillRectangle(blueBrush, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
            removeBold();
        }

        public void drawFrame()
        {
            Pen p = new Pen(Color.Green, 10);
            g.DrawRectangle(p, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
        }

        public void deleteFrame()
        {
            Pen p = new Pen(Color.Black, 10);
            g.DrawRectangle(p, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
        }
    }
}
