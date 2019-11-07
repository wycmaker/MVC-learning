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

        public double GetArea(double radis)
        {
            return radis * radis;
        }

        public double GetArea(double width, double height)
        {
            return width * height;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Area A1 = new Area();
            Console.WriteLine("正方形的面積：{0}", A1.GetArea(10));
            Console.WriteLine("長方形的面積：{0}", A1.GetArea(10, 20));
            Console.Read();
        }
    }
}
