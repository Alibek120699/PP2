using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    class Student
    {
        string name;
        string surname;
        double gpa;
        

        public void ReadInf()
        {
            name = Convert.ToString(Console.ReadLine());
            surname = Convert.ToString(Console.ReadLine());
            gpa = double.Parse(Console.ReadLine().Replace(".", ","));
        }

        public void PrintInf()
        {
            Console.WriteLine(name + " " + surname + " " + gpa);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student();
            x.ReadInf();
            x.PrintInf();
        }
    }
}

