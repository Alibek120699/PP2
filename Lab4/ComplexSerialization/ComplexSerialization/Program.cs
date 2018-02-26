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
            Complex c1 = new Complex(1, 2);
            Complex c2 = new Complex(1, 3);

            FileStream fs = new FileStream("ComplexNumber.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            FileStream fs2 = new FileStream("ComplexNumber2.xml", FileMode.Truncate, FileAccess.ReadWrite);

            xs.Serialize(fs, c1);
            xs.Serialize(fs2, c2);
            fs.Close();


        }
        public static void Deser()
        {
            FileStream fs = new FileStream("ComplexNumber.xml", FileMode.Open, FileAccess.Read);
            FileStream fs2 = new FileStream("ComplexNumber2.Xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(Complex));

            Complex c1 = xs.Deserialize(fs) as Complex;
            Complex c2 = xs.Deserialize(fs2) as Complex;

            Complex res = c1 + c2;
            Console.WriteLine(res);
        }
    }
}
