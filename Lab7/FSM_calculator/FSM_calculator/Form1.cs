using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FSM_calculator
{
    public partial class FSMcalculator : Form
    {
        Brain brain = new Brain();

        public FSMcalculator()
        {
            InitializeComponent();
            brain.invoker = ShowInfo;
        }

        public void ShowInfo(string msg)
        {
            textBox_result.Text = msg;
            currentop.Text = msg;
        }

        public void BtnClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            brain.Process(btn.Text);
        }
    }
}
