using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Inheritance_Access_Modifiers
{
    class Student : Human
    {

        string Group;
        private int Point;
        public int Result
        {
            get
            {
                return Point;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    Point = value;
                }
                else
                {
                    Console.WriteLine("Zehmet olmasa duzgun point daxil edin");
                }
            }
        }
        public bool IsGraduated;

        public Student(string name, string surname, int age, string gender, string group, byte point, bool isgraduated = false) : base(name, surname, age, gender)
        {
            Group = group;
            Point = point;
            IsGraduated = isgraduated;
        }
        //public Student(string name)
        //{
        //    Name = name;
        //}
        //public Student(byte point) : this()
        //{
        //    Console.WriteLine($"Point: {point}");
        //}
        //public Student(string name, string surname, string group, byte point, bool isGraduated = false) : this(point)
        //{
        //    Console.WriteLine("Info");
        //    Name = name;
        //    Surname = surname;
        //    Group = group;
        //    Point = point;
        //    IsGraduated = isGraduated;
        //}
        public string getGroup()
        {
            return Group;
        }

        public void setGroup(string groupName)
        {
            if (groupName.Length > 3)
            {
                Group = groupName;
            }
            else
            {
                Console.WriteLine("Zehmet olmasa duzgun bir qrup adi teyin edin");
            }
        }
        public string FullName()
        {
            return $"Name:{Name}\nSurname:{Surname}";
        }
        public string GetInfo()
        {
            string Info = $"Name:{Name} Surname:{Surname} Group:{Group} Point:{Point}\n";
            if (IsGraduated)
            {
                return Info + "Bu telebe mezun olub";
            }
            else
            {
                return Info + "Bu telebe mezun olmayib";
            }

        }
        public string TakeExam()
        {
            if (Point == 100)
            {
                return "Siz maksimum bali yigmisiz";
            }
            else if (Point > 80)
            {
                return "Bu telebe imtahana gire biler";
            }
            else
            {
                return "Imtahani unut";
            }
        }
    }
}
