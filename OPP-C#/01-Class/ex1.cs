using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Student
    {
        public string StudentName;
        public int StudentAge;
        public string StudentGender;

        //public Student(string Name, int Age, string Gender)
        //{
        //    StudentName = Name;
        //    StudentAge = Age;
        //    StudentGender = Gender;
        //}

        public void GetName()
        {
            Console.WriteLine("我的名字是{0}", StudentName);
        }
    } 
    class Program
    {
        static void Main(string[] args)
        {
            //Student S1 = new Student("Jack", 20, "男");
            Student S1 = new Student();
            S1.StudentName = "Jack";
            S1.StudentAge = 20;
            S1.StudentGender = "男";
            S1.GetName();
            Console.Read();
        }
    }
}