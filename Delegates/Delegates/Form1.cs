using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegates
{
    public delegate void MyDelegate();

    public partial class Form1 : Form
    {
        MyDelegate example;
        public Form1()
        {
            example = DoIt;
            example += DoIt2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            example.Invoke();
        }

        private void DoIt()
        {
            MessageBox.Show("helaljdbvhkb");
        }

        private void DoIt2()
        {
            MessageBox.Show("123");
        }

        private void digit_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Clear();
            }
            textBox1.Text = textBox1.Text + btn.Text;
        }
    }
}
