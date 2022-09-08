using System;
using System.Collections.Generic;
using System.Text;
using System.Media;

namespace Football_Owner
{
    abstract class Person
    {

        private string _first_name;
        private string _last_name;
        private char _gender; //'M' - MALE , 'F'-FAMALE, 'O'- OTHER
        private int _age;
        private Date _birthday;

        public Person(string first_name, string last_name, char gender, Date birthday)
        {
            this._first_name = first_name;
            this._last_name = last_name;
            this._gender = gender;
            this._birthday = birthday;
            this._age = 2022 - this._birthday.getYear();
        }
        public Person() { }

        public string getFirstName() { return this._first_name; }
        public string getLastName() { return this._last_name; }
        public char getGender() { return this._gender; }
        public int getAge() { return this._age; }
        public Date getBirthday() { return this._birthday; }

        public void setFirstName(string first_name) { this._first_name = first_name; }
        public void setLastName(string last_name) { this._last_name = last_name; }
        public void setGender(char gender) { this._gender = gender; }
        public void setAge(int age ) { this._age = age; }
        public void setDate(Date birthday) { this._birthday = birthday; }
        public abstract void special_ability(SoundPlayer sp);
    }
   
}
