using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Inheritance_Access_Modifiers
{
    class Teacher:Human
    {
        public string Profession;
        public double Salary;
        public Teacher(string name,string surname,int age,string gender,string profession,double salary):base(name,surname,age,gender)
        {
            Profession = profession;
            Salary = salary;

        }

        public string Detail()
        {
            return getInfo() + $" Profession: {Profession} Salary: {Salary}";
        }
    }
}
