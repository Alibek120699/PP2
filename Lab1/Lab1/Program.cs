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
        public void ReadInf()
        {
            width = Convert.ToDouble(Console.ReadLine());
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void FindArea()
        {
            Console.WriteLine("The area of this Rectangle is: " + width * height);
        }

        public void FindPerimeter()
        {
            Console.WriteLine("The perimeter of this rectangle is: " + (2 * (width + height)));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the width and the height of the rectangle in separate lines: ");
            Rectangle x = new Rectangle();
            x.ReadInf();
            x.FindArea();
            x.FindPerimeter();
        }
    }
}
