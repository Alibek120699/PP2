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
            string[] numbers = s.Split(' ');
            int size = numbers.Length;
            for (int i = 0; i < size; i++)
            {
                CheckPrime(int.Parse(numbers[i]));
            }

        }
        static void CheckPrime(int n)
        {
            bool ok = true;
            if (n <= 1)
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
                Console.WriteLine(n);
            }

        }
    }
}
