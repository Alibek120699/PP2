using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator2
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        public double result=0;
        public bool onoff = false;
        public bool smthpressed = false;
        public string memory;
        public string currentnum;
        public bool operationdone = false;
        public string operationperformed = "";
        private void digit_click(object sender, EventArgs e)
        {

            if (smthpressed)
            {
                textBox_result.Clear();
                smthpressed = false;
            }
            if (textBox_result.Text == "0")
            {
                textBox_result.Clear();
            }
            Button btn = (Button)sender;
            textBox_result.Text = textBox_result.Text + btn.Text;
            currentnum = textBox_result.Text;
            operationdone = false;
            //result = Double.Parse(textBox_result.Text );
        }

        private void dot_click(object sender, EventArgs e)
        {
            if (!textBox_result.Text.Contains(","))
            {
                textBox_result.Text = textBox_result.Text + ",";
            }
        }

        private void save_click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab7\Calculator2\Calculator2\bin\Debug\number.xml", FileMode.Truncate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(string));
            memory = textBox_result.Text;
            xs.Serialize(fs, memory);
            fs.Close();
            mc.ForeColor = Color.Black;
            mr.ForeColor = Color.Black;
            mmns.ForeColor = Color.Black;
            mpls.ForeColor = Color.Black;
            mnabla.ForeColor = Color.Black;
            onoff = true;
            smthpressed = true;
        }

        private void read_click(object sender, EventArgs e)
        {
            if (onoff)
            {
                FileStream fs = new FileStream(@"number.xml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(string));
                try
                {
                   textBox_result.Text = xs.Deserialize(fs) as string;
                }
                catch (Exception)
                {

                }
                fs.Close();
            }
        }

        private void clear_click(object sender, EventArgs e)
        {
            if (onoff)
            {
                FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab7\Calculator2\Calculator2\bin\Debug\number.xml", FileMode.Create, FileAccess.ReadWrite);
                fs.Close();
                onoff = false;
                smthpressed = true;
                mc.ForeColor = Color.DarkGray;
                mr.ForeColor = Color.DarkGray;
                mmns.ForeColor = Color.DarkGray;
                mpls.ForeColor = Color.DarkGray;
                mnabla.ForeColor = Color.DarkGray;
            }
        }

        private void backspace_click(object sender, EventArgs e)
        {

            if (textBox_result.Text != "")
            {
                textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Length - 1);

            }

            if (textBox_result.Text == "")
            {
                textBox_result.Text = "0";
            }

        }

        private void ce_click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void changesign_click(object sender, EventArgs e)
        {
            textBox_result.Text = ((-1) * Double.Parse(textBox_result.Text)).ToString();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            switch (operationperformed)
            {
                case "+":
                    textBox_result.Text = (result + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (result - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "×":
                    textBox_result.Text = (result * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "÷":
                    if (Double.Parse(textBox_result.Text) == 0)
                    {
                        textBox_result.Text = "MATH ERROR!!!";
                    }
                    else
                    {
                        textBox_result.Text = (result / Double.Parse(textBox_result.Text)).ToString();
                    }
                    break;
                default:
                    break;
            }
            smthpressed = true;
            currentop.Text = "";
        }

        private void mplus(object sender, EventArgs e)
        {
            if (onoff)
            {
                memory = (Double.Parse(memory) + Double.Parse(currentnum)).ToString();
                FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab7\Calculator2\Calculator2\bin\Debug\number.xml", FileMode.Truncate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(string));
                xs.Serialize(fs, memory);
                fs.Close();
                smthpressed = true;
            }
        }

        private void mminus(object sender, EventArgs e)
        {
            if (onoff)
            {
                memory = (Double.Parse(memory) - Double.Parse(currentnum)).ToString();
                FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab7\Calculator2\Calculator2\bin\Debug\number.xml", FileMode.Truncate, FileAccess.ReadWrite);
                XmlSerializer xs = new XmlSerializer(typeof(string));
                xs.Serialize(fs, memory);
                fs.Close();
                smthpressed = true;
            }
        }

        private void operation(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (!operationdone)
            {
                operationperformed = btn.Text;
            }

            result = Double.Parse(textBox_result.Text);
            currentop.Text = result + operationperformed;
            smthpressed = true;
        }

        private void c_click(object sender, EventArgs e)
        {
            currentop.Text = "";
            textBox_result.Text = "0";
        }

        private void squareroot(object sender, EventArgs e)
        {
            if (Double.Parse(textBox_result.Text) < 0)
            {
                textBox_result.Text = "MATH ERROR!!!";
                smthpressed = true;
            }
            else
            {
                currentop.Text = "sqrt(" + textBox_result.Text + ")";
                textBox_result.Text = (Math.Sqrt(Double.Parse(textBox_result.Text))).ToString();
            }
        }

        private void square(object sender, EventArgs e)
        {
            currentop.Text = "(" + textBox_result.Text + ")²";
            textBox_result.Text = (Math.Pow(Double.Parse(textBox_result.Text), 2)).ToString();
        }

        private void inverse(object sender, EventArgs e)
        {
            if (Double.Parse(textBox_result.Text) == 0)
            {
                textBox_result.Text = "MATH ERROR!!!";
                smthpressed = true;
            }
            else
            {
                currentop.Text = "1/(" + textBox_result.Text + ")";
                textBox_result.Text = (1 / (Double.Parse(textBox_result.Text))).ToString();
            }
        }

        private void calculate_percent(object sender, EventArgs e)
        {
            smthpressed = true;
            if (result != 0)
            {
                textBox_result.Text = ((result * Double.Parse(textBox_result.Text)) / 100).ToString();
                currentop.Text = result.ToString() + operationperformed + textBox_result.Text;
            }
        }
    }
}
