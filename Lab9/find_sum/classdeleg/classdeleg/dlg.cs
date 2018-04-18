using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace classdeleg
{
    public class dlg
    {
        public void process()
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            Find fd = new Find(a, b);
            MyDelegate md = fd.DoIt;
            Thread.Sleep(5000);
            md.Invoke(a, b);
        }
    }
}
