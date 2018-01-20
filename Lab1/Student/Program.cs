using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{

    class Student// we create class Student with parametres name, surname and gpa
    {
        string name;
        string surname;
        double gpa;
        

        public void ReadInf()//reads name, surname, gpa  and makes them visible to other classes
        {
            name = Convert.ToString(Console.ReadLine());
            surname = Convert.ToString(Console.ReadLine());
            gpa = double.Parse(Console.ReadLine().Replace(".", ","));
        }

        public void PrintInf()//takes name, surname, gpa from console and prints them in console in one line 
        {
            Console.WriteLine(name + " " + surname + " " + gpa);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student x = new Student();
            x.ReadInf();//reads name, surname, gpa from console and sends them to class Student
            x.PrintInf();// takes name, surname, gpa and prints them in console in one line
        }
    }
}

