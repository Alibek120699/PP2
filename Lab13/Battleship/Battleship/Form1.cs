using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Button> buttons;
        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button btn = new Button();
                    btn.Name = (i + " " + j) + "";
                    btn.Location = new Point(i*5 + 10, j * 5 + 10);
                    btn.BackColor = Color.Black;
                    btn.CreateControl();
                }
            }
        }
    }
}
