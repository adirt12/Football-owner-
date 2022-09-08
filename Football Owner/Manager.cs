using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Media;


namespace Football_Owner
{
    class Manager : Person
    {
        private int _seniority;
        private int _financial_capital;
        private int _salary;
        private string _football_club;
        private Image _img;
        private Point _location;
        private static Graphics g;
        private static Size PictureSizeOnScreen = new Size(90, 90);
        private bool _choose;

        public Manager(string first_name, string last_name, char gender
            , int age, Date birthday, int seniority, int financial_capital, int salary, 
            string football_club) : base(first_name, last_name, gender, birthday)
        {
            this._seniority = seniority;
            this._financial_capital = financial_capital;
            this._salary = salary;
            this._football_club = football_club;
        }

        public Manager(Image img)
        {
            this._img = img;
        }
        public int getSeniority() { return this._seniority; }
        public int getFinancialCapital() { return this._financial_capital; }
        public int getSalary() { return this._salary; }
        public string getFootballClub() { return this._football_club; }
        public int GetX() { return _location.X; }
        public int GetY() { return _location.Y; }
        public Image getImage() { return this._img; }
        public bool getChoose() { return this._choose; }


        public void setSeniority(int seniority) { this._seniority = seniority; }
        public void setFinancialCapital(int financial_capital) { this._financial_capital = financial_capital; }
        public void setSalary(int salary) { this._salary = salary; }
        public void setFootballClub(string football_club) { this._football_club = football_club; }
        public void setImage(Image im) { this._img = im; }
        public void SetX(int X) { this._location.X = X; }
        public void SetY(int Y) { this._location.Y = Y; }
        public void setChoose(bool choose) { this._choose = choose; }

        public static void SetGraphics(Graphics SetGraphics) { g = SetGraphics; }

        public void draw()
        {
            g.DrawImage(this._img, _location.X, _location.Y, PictureSizeOnScreen.Width, PictureSizeOnScreen.Height);
        }
        public string dataManager()
        {
            return "Manager Card :\n\n" +
                "First Name: " + getFirstName() + "\n" +
                "Last Name: " + getLastName() + "\n" +
                "Gender: " + getGender() + "\n" +
                "Age: " + getAge() + "\n" +
                "Football Club: " + _football_club + "\n" +
                "Seniority: " + _seniority + "/n" +
                "Financial Capital: " + _financial_capital + "\n";
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
        public override void special_ability(SoundPlayer sp)
        {
            sp = new SoundPlayer("ManagerVoice.wav");
            sp.Play();
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
