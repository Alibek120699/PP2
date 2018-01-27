using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] cmpx = s.Split(' ');
            string[] cmp1 = cmpx[0].Split('/');
            string[] cmp2 = cmpx[1].Split('/');
            
            int i1 = int.Parse(cmp1[0]);
            int i2 = int.Parse(cmp1[1]);
            int i3 = int.Parse(cmp2[0]);
            int i4 = int.Parse(cmp2[1]);
            Complex c1 = new Complex(i1, i2);
            Complex c2 = new Complex(i3, i4);
            Complex  mul = c1 * c2;
            Complex  div = c1 / c2;
            Complex  add = c1 + c2;
            Complex  sub = c1 - c2;
            Console.WriteLine("The multiplication of these two numbers is: " + mul);
            Console.WriteLine("The division of these two numbers is:  " + div);
            Console.WriteLine("The addition of these two numbers is: " + add);
            Console.WriteLine("The substraction of these two numbers is: " + sub);
        }
    }
}
