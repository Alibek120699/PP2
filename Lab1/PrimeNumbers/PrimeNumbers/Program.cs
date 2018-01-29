using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        /// <summary>
        /// checks is number prime or not, if it is prime returns true, else returns false
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>

        public static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        return false;
                        break;
                    }
                }
            }
            return true;
        }
        static void Main(string[] args)
        {
            
            for(int i = 0; i < args.Length; i++)
            {
                if (CheckPrime(int.Parse(args[i])) == true)
                {
                    //Console.Write(numbers[i] + " ");
                    Console.WriteLine(args[i]);
                }
            }
        }
    }
}
