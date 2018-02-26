using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexSerialization
{
    public class Complex
    {
        public int a;
        public int b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        
        public Complex()
        {

        }

        


        public static int Gcd(int a, int b)
        {
            if (b == 0) return a;
            else return Gcd(b, a % b);
        }

        public static int Lcm(int a, int b)
        {
            int max = Math.Max(a, b);
            for (int i = max; i < a * b; i++)
            {
                if (i % a == 0 && i % b == 0)
                {
                    max = i;
                    break;
                }
                else
                    max = a * b;
            }
            return max;
        }

        public void Simplify()
        {
            int a1 = a;
            int b1 = b;
            int div = Gcd(a1, b1);
            this.a = this.a / div;
            this.b = this.b / div;
        }
        
        public static Complex operator +(Complex x, Complex y)
        {
            int lcm = (Lcm(x.b, y.b) / x.b) * x.a + (Lcm(x.b, y.b) / y.b) * y.a;
            Complex result3 = new Complex(lcm, Lcm(x.b, y.b));
            result3.Simplify();
            if (result3.b < 0)
            {
                result3.b = result3.b * (-1);
                result3.a = result3.a * (-1);
            }
            return result3;
        }

       

        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
