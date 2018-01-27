using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers2
{
    class Program
    {
     /// <summary>
     /// prints prime numbers
     /// </summary>
     /// <param name="n"></param>
        static void Checkprime(int n)//prints prime numbers
        {
            bool ok = true;
            if (n < 2)
            {
                ok = false;
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
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
                Console.Write(n + " ");
                //Console.WriteLine(n);
            }
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] numbers = s.Split(' ');
            for(int i = 0; i < numbers.Length; i++)
            {
                Checkprime(int.Parse(numbers[i]));
            }
        }
    }
}
