using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace classdeleg
{
    public class Find
    {
        int a, b;
        public Find(int a, int b)
        {
            this.a = a;
            this.b = b;
        }
        public void DoIt(int a, int b)
        {
            Console.WriteLine(a + b);
        }
    }
}
