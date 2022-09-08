using System;
using System.Collections.Generic;
using System.Text;

namespace Football_Owner
{
    class Date
    {
        private int _day;
        private int _month;
        private int _year;

        public Date(int day, int month, int year)
        {
            this._day = day;
            this._month = month;
            this._year = year;
        }

        public int getDay() { return this._day; }
        public int getMonth() { return this._month; }
        public int getYear() { return this._year; }

        public void setDay(int day) { this._day = day; }
        public void setMonth(int month) { this._month = month; }
        public void setYear(int year) { this._year = year; }



    }
}
