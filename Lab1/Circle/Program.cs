using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Circle
    {
        double Radius;
        double pi = Math.PI;
        public void ReadInf()
        {
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public void FindDiameter()
        {
            Console.WriteLine("The diameter of this circle is: " + 2 * Radius);
        }

        public void FindArea()
        {
            Console.WriteLine("The area of this circle is: " + pi * Math.Pow(Radius, 2));
        }

        public void FindCircumference()
        {
            Console.WriteLine("The circumference of this circle is: " + 2 * pi * Radius);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of circle: ");
            Circle x = new Circle();
            x.ReadInf();
            x.FindDiameter();
            x.FindArea();
            x.FindCircumference();
        }
    }
}
