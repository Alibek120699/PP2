using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool isOperationPerformed = false;
        Double resValue = 0;
        String operationPerformed = "";
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button_click(object sender, EventArgs e)
        {
            if ((textBox_result.Text == "0")||(isOperationPerformed))
                textBox_result.Clear();

            isOperationPerformed = false;
            Button btn = (Button)sender;
            //btn.Text.Replace('.', ',');
            if (btn.Text == ",")
            {
                
                if (!textBox_result.Text.Contains(","))
                    
                    textBox_result.Text = textBox_result.Text + btn.Text;
            }
            else
                textBox_result.Text = textBox_result.Text + btn.Text;

        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            operationPerformed = btn.Text;
            resValue = Double.Parse(textBox_result.Text);
            labelcurrentop.Text = resValue + operationPerformed;
            isOperationPerformed = true;
        }

        private void ce_click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void c_click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            labelcurrentop.Text = "";
            resValue = 0;
        }

        private void equal_click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    textBox_result.Text = (resValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    textBox_result.Text = (resValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "×":
                    textBox_result.Text = (resValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "÷":
                    textBox_result.Text = (resValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void backspace_click(object sender, EventArgs e)
        {
            textBox_result.Text = textBox_result.Text.Remove(textBox_result.Text.Count()-1);
            if (textBox_result.Text == null)
            {
                textBox_result.Text = "0";
            }
        }
    }
}
