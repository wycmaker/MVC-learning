using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Animal
    {
        public string Spices;
        public int Age;
    } 

    public class Cat:Animal
    {
        public int FootNumber;

        public Cat(string spices, int age, int footnumber)
        {
            Spices = spices;
            Age = age;
            FootNumber = footnumber;
        }
    }

    public class Dog:Animal
    {
        public string Color;

        public Dog(string spices, int age, string color)
        {
            Spices = spices;
            Age = age;
            Color = color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat cat1 = new Cat("cat", 2, 4);
            Dog dog1 = new Dog("dog", 3, "yellow");
            Console.Read();
        }
    }
}
