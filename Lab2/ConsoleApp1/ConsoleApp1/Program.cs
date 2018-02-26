using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net.Sockets;

namespace ConsoleApp1
{
    class Program
    {
        public static bool Prime (int n)
        {
            bool ok = true;

            if (n < 2)
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
            if (ok == false)
                return false;
            return true;
            
        }
        
        static void Main(string[] args)
        {
            
            string path = @"C:\Users\HP\Desktop\PP2\Lab2\ConsoleApp1\ConsoleApp1\input.txt";
            //StreamReader sr = new StreamReader(@"C: \Users\HP\Desktop\PP2\Lab2\input.");
            string lines = File.ReadAllText(path);
            string[] numbers = lines.Split(' ','\n', '\t');
            int min = 1000;
            int max = 1;
            List<int> primes = new List<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if(Prime(int.Parse(numbers[i]))== true)
                {
                    primes.Add(int.Parse(numbers[i]));
                }
            }
            for(int i = 0; i < primes.Count; ++i)
            {
                if (primes[i] > max)
                {
                    max = primes[i];
                }
                if (primes[i] < min)
                {
                    min = primes[i];
                }
            }
            //Console.WriteLine("min: " + min);
            //Console.WriteLine("max: " + max);
            string[] mins = { "min prime: " + Convert.ToString(min)," ", "max prime: " + Convert.ToString(max) };
            
            File.WriteAllLines(@"C:\Users\HP\Desktop\PP2\Lab2\ConsoleApp1\ConsoleApp1\TextFile1.txt", mins);
            
        }
    }
}
