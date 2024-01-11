using System;
using System.Collections.Generic;
using System.Text;

namespace Task0111
{
    internal class Student
    {
        public Student(string fullName, DateTime birthDate, string groupNo, int point)
        {
            this.Fullname = fullName;
            this.BirthDate = birthDate;
            this.GroupNo = groupNo;
            this.Point = point;
        }

        public string Fullname;
        public string GroupNo;
        public int Point;
        public DateTime BirthDate;

        public void ShowInfo()
        {
            Console.WriteLine($"{this.Fullname}-{this.BirthDate}-{this.GroupNo}-{this.Point}");
        }
    }
}

