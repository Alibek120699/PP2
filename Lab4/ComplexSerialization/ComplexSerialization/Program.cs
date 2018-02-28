using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ComplexSerialization
{
    class Program
    {

        static void Main(string[] args)
        {
            Ser();
            //Deser();
        }
        public static void Ser()
        {
            string s = Console.ReadLine();
            string[] cmpx = s.Split(' ');
            string[] cmp1 = cmpx[0].Split('/');
            string[] cmp2 = cmpx[1].Split('/');

            int i1 = int.Parse(cmp1[0]);
            int i2 = int.Parse(cmp1[1]);
            int i3 = int.Parse(cmp2[0]);
            int i4 = int.Parse(cmp2[1]);

            Complex c1 = new Complex(i1, i2);
            Complex c2 = new Complex(i3, i4);

            Complex addresult = c1 + c2;

            FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab4\ComplexSerialization\ComplexSerialization\ComplexNumber.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));



            xs.Serialize(fs, addresult);
            fs.Close();
        }

        public static void Deser()
        {
            FileStream fs = new FileStream(@"ComplexNumber.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            Complex addresult = xs.Deserialize(fs) as Complex;

            Console.WriteLine(addresult);
        }
    }
}
