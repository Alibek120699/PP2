using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle
{
    class Rectangle
    {
        double width;
        double height;
        public void ReadInf()//reads values of width and height from console and makes it visible to other classes
        {
            width = Convert.ToDouble(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void FindArea()//finds area of rectangle by formula and makes it visible to other classes
        {
            Console.WriteLine("The area of this Rectangle is: " + width * height);
        }

        public void FindPerimeter()//finds perimeter of rectangle by formula and makes it visible to other classes
        {
            Console.WriteLine("The perimeter of this rectangle is: " + (2 * (width + height)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width and the height of the rectangle in separate lines: ");
            Rectangle y = new Rectangle();
            y.ReadInf();//takes values of width and height it console and sends them to class Rectangle
            y.FindArea();//takes value of area from class Rectangle and prints it in console
            y.FindPerimeter();//takes value of area from class Rectangle and prints it in console
        }
    }
}
