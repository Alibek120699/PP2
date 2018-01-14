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
        double pi = Math.PI;// we take value of number pi from Math.PI
        public void ReadInf() // reads radius of circle and makes it visible to other classes
        {
            Radius = Convert.ToDouble(Console.ReadLine());
        }

        public void FindDiameter()// finds diameter by formula D=2*R and makes it visible to other classes
        {
            Console.WriteLine("The diameter of this circle is: " + 2 * Radius);
        }

        public void FindArea()// finds area of the circle by formula A=pi*R*R and makes it visible to other classes
        {
            Console.WriteLine("The area of this circle is: " + pi * Math.Pow(Radius, 2));
        }

        public void FindCircumference()// finds circumference of the circle by formula C=2*pi*R and makes it visible to other classes
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
            x.ReadInf();//takes value of radius from class Circle and prints it in console
            x.FindDiameter();// takes value of diameter from class Circle and prints it in console
            x.FindArea();// takes value of area from class Circle and prints it in console
            x.FindCircumference();// takes value of circumference from class Circle and prints it in console
        }
    }
}
