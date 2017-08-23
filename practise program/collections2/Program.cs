using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace collections2
{ 
    public class Shape
    {
        public virtual void Area()
        {
            Console.WriteLine("This is the main defination of Area");
        }
    }
    class Square : Shape
    {
        public override void Area()
        {
            Console.WriteLine("Please enter the side to get area");
            int side = int.Parse(Console.ReadLine());
            int area = side * side;
            Console.WriteLine("Area of a square is {0}", area);
        }
    }
    class Circle : Shape
    {
        public override void Area()
        {
           const double pi = 3.14;
           Console.WriteLine("Please enter the radius of the circle");
           double radius = double.Parse(Console.ReadLine());
           double area = pi * radius * radius;
           Console.WriteLine("Area of a circle is {0}", area);
        }
    }
    class Foo : Shape
    {
    }
    class Program
    {
        static void Main(string[] args)
        {
            Shape s1 = new Shape();
            s1.Area();
            Square s = new Square();
            s.Area();
            Circle c = new Circle();
            c.Area();

            
        }
    }
}
	
   
  