using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace classdeleg
{
    public delegate void MyDelegate(int a, int b);
    class Program
    {
        static void Main(string[] args)
        {
            dlg deleg = new dlg();
            deleg.process();
        }
    }
}
