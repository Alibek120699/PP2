using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Complex
    {
        int a;
        int b;
        public Complex(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public static int Gcd(int a, int b)
        {
            if (b == 0) return a;
            else return Gcd(b, a % b);
        }
        public static int Lcm(int a, int b)
        {
            int max = Math.Max(a,b);
            for(int i = max; i < a * b; i++)
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
        public static Complex operator *(Complex x, Complex y)
        {
            Complex result1 = new Complex(x.a * y.a, x.b * y.b);
            result1.Simplify();
            if (result1.b < 0)
            {
                result1.b = result1.b * (-1);
                result1.a = result1.a * (-1);
            }
            return result1;
        }
        public static Complex operator /(Complex x, Complex y)
        {
            Complex result2 = new Complex(x.a * y.b, x.b * y.a);
            result2.Simplify();
            if (result2.b < 0)
            {
                result2.b = result2.b * (-1);
                result2.a = result2.a * (-1);
            }
            return result2;
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
        public static Complex operator -(Complex x, Complex y)
        {
            int lcm = (Lcm(x.b, y.b)/x.b)*x.a-(Lcm(x.b,y.b)/y.b)*y.a;
            Complex result4 = new Complex(lcm, Lcm(x.b,y.b));
            result4.Simplify();
            if (result4.b < 0)
            {
                result4.b = result4.b * (-1);
                result4.a = result4.a * (-1);
            }
            return result4;
        }

        public override string ToString()
        {
            return a + "/" + b;
        }
    }
}
