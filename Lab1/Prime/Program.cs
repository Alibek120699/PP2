using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Convert.ToString(Console.ReadLine());
            string[] numbers = s.Split(' ');// we convert string s to array numbers splitting by space
            int size = numbers.Length;
            for (int i = 0; i < size; i++)
            {
                CheckPrime(int.Parse(numbers[i]));// we convert every part of string array numbers[] to integer number
            }

        }
        static void CheckPrime(int n) // checks every number from numbers[] and prints prime numbers in console
        {
            bool ok = true;
            if (n <= 1) // 1 is not prime number
            {
                ok = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        ok = false;
                        break;
                    }
                }
            }

            if (ok == true) 
            {
                Console.WriteLine(n);// If number is prime this method prints this number in console
            }

        }
    }
}
