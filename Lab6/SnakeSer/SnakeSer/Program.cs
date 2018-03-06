using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Threading;


namespace SnakeSer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Timer time = new Timer();
            //time.Interval = 500;
            //time.Elapsed += Time_Elapsed;
            //time.Start();
            Menu menu = new Menu();
            menu.SelectItem();
        }

        /*private static void Time_Elapsed(object sender, ElapsedEventArgs e)
        {
            Menu menu = new Menu();
            menu.SelectItem();
        }*/
    }
}
