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

        public double result;
        private void digit_click(object sender, EventArgs e)
        {
            

            if (textBox_result.Text == "0")
            {
                textBox_result.Clear();
            }
            Button btn = (Button)sender;
            textBox_result.Text = textBox_result.Text + btn.Text;

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
            xs.Serialize(fs, textBox_result.Text);
            fs.Close();
        }

        private void read_click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"number.xml", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(string));
            textBox_result.Text = xs.Deserialize(fs) as string;
            fs.Close();
        }

        private void clear_click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab7\Calculator2\Calculator2\bin\Debug\number.xml", FileMode.Create, FileAccess.ReadWrite);
            fs.Close();
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
    }
}
