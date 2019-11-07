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
        public static int StudentCredit;

        public Student(string Name, int Age, string Gender)
        {
            StudentName = Name;
            StudentAge = Age;
            StudentGender = Gender;
        }

        public void SetCredit(int Credit)
        {
            StudentCredit = Credit;
        }

        public void GetCredit()
        {
            Console.WriteLine("{0}的學分是{1}", this.StudentName, StudentCredit);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student S1 = new Student("Jack", 20, "男");
            S1.SetCredit(30);
            Console.WriteLine("第一位學生");
            S1.GetCredit();

            Student S2 = new Student("Merry", 20, "女");
            S2.SetCredit(40);
            Console.WriteLine("第二位學生");
            S2.GetCredit();
            Console.WriteLine("第一位學生");
            S1.GetCredit();
            Console.Read();
        }
    }
}