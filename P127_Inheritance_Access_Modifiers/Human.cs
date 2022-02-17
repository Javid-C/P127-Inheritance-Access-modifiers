using System;
using System.Collections.Generic;
using System.Text;

namespace P127_Inheritance_Access_Modifiers
{
    class Human
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Gender;

        public Human(string name)
        {
            Name = name;
        }
        public Human(string name, string surname, int age,string gender)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }
        public string getInfo()
        {
            return $"Name:{Name} Surname: {Surname} Age: {Age} Gender: {Gender}";
        }
    }
}
