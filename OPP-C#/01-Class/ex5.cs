using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Area
    {
        public double radis;
        public double width;
        public double height;

        public virtual double GetArea()
        {
            return this.radis * this.radis;
        }

    }

    public class Circle:Area
    {
        public const double PI = 3.14;

        public override double GetArea()
        {
            return base.GetArea()*3.14;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle();
            C1.radis = 5;
            Console.WriteLine("圓面積為：{0}", C1.GetArea());
            Console.Read();
        }
    }
}
