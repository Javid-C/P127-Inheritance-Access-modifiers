using System;

namespace P127_Inheritance_Access_Modifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student = new Student("Gunel", "HAsanova", "P127", 79);
            //Console.WriteLine(student.FullName());
            //Console.WriteLine(student.GetInfo());
            //Console.WriteLine(student.TakeExam());
            //Student student1 = new Student("Lutfiyar");
            //student1.Surname = "Aliyev";
            //Console.WriteLine(student1.FullName());
            //Student student2 = new Student(60);
            //Console.WriteLine(student2.TakeExam());
            //Student student3 = new Student();


            Student student = new Student("Sabir","Quliyev",24,"Male","P127",92,true);
            Teacher teacher = new Teacher("Javid", "Asadullayev", 24, "Male", "Programming", 7650.90d);
            Console.WriteLine(teacher.Detail());
            Console.WriteLine(student.GetInfo());
            student.setGroup("P128");

            student.Result = 100;
            Console.WriteLine(student.Result);
        }
    }
   
}
