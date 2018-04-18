using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gfx
{
    public partial class Form1 : Form
    {
        Graphics g;
        Rectangle r = new Rectangle(4, 4, 675, 404);
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }
        
        private void draw_click(object sender, EventArgs e)
        {
            Pen border = new Pen(Color.Black, 13);
            Brush draw_brush = new SolidBrush(Color.Indigo);
            g.FillRectangle(draw_brush, 4, 4, 675, 404);
            g.DrawRectangle(border, r);
            Brush circle_brush = new SolidBrush(Color.White);
            g.FillEllipse(circle_brush, 70, 80, 20, 20);
            g.FillEllipse(circle_brush, 70, 300, 20, 20);
            g.FillEllipse(circle_brush, 270, 60, 20, 20);
            g.FillEllipse(circle_brush, 270, 280, 20, 20);
            g.FillEllipse(circle_brush, 600, 140, 20, 20);
            g.FillEllipse(circle_brush, 600, 350, 20, 20);
            g.FillEllipse(circle_brush, 520, 220, 20, 20);
            g.FillEllipse(circle_brush, 410, 90, 20, 20);
            g.FillEllipse(circle_brush, 20, 20, 20, 20);
            Brush centre = new SolidBrush(Color.Yellow);
            Point c1 = new Point(312, 207);
            Point c2 = new Point(352, 187);
            Point c3 = new Point(392, 207);
            Point c4 = new Point(392, 227);
            Point c5 = new Point(352, 247);
            Point c6 = new Point(312, 227);
            Point[] yel = { c1, c2, c3, c4, c5, c6 };
            g.FillPolygon(centre, yel);

            Brush arrow = new SolidBrush(Color.Green);
            Point a1 = new Point(342, 217);
            Point a2 = new Point(352, 203);
            Point a3 = new Point(362, 217);
            Point a4 = new Point(357, 217);
            Point a5 = new Point(357, 227);
            Point a6 = new Point(348, 227);
            Point a7 = new Point(348, 217);
            Point[] gre = { a1, a2, a3, a4, a5, a6, a7 };
            g.FillPolygon(arrow, gre);

            Point s1 = new Point(352, 170);
            Point s2 = new Point(361, 167);
            Point s3 = new Point(364, 161);
            Point s4 = new Point(367, 167);
            Point s5 = new Point(376, 170);
            Point s6 = new Point(367, 173);
            Point s7 = new Point(364, 179);
            Point s8 = new Point(361, 173);
            Point[] stars = { s1, s2, s3, s4, s5, s6, s7, s8 };
            g.FillPolygon(arrow, stars);

            g.FillRectangle(circle_brush, 435, 15, 175, 35);
            Pen level_border = new Pen(Color.Yellow, 4);
            g.DrawRectangle(level_border, 435, 15, 175, 35);
            Font level = new Font("Arial", 9.0f);
            Brush lvl = new SolidBrush(Color.Black);
            g.DrawString("Level: 1 Score: 200 Live: ***", level, lvl, 440, 26);

            Brush astr = new SolidBrush(Color.Red);
            Point p1 = new Point(150, 130);
            Point p2 = new Point(190, 130);
            Point p3 = new Point(170, 160);
            Point[] tr1 = { p1, p2, p3 };
            g.FillPolygon(astr, tr1);
            Point p4 = new Point(150, 150);
            Point p5 = new Point(190, 150);
            Point p6 = new Point(170, 120);
            Point[] tr2 = { p4, p5, p6 };
            g.FillPolygon(astr, tr2);

            Point p7 = new Point(180, 230);
            Point p8 = new Point(220, 230);
            Point p9 = new Point(200, 260);
            Point[] tr3 = { p7, p8, p9 };
            g.FillPolygon(astr, tr3);
            Point p10 = new Point(180, 250);
            Point p11 = new Point(220, 250);
            Point p12 = new Point(200, 220);
            Point[] tr4 = { p10, p11, p12 };
            g.FillPolygon(astr, tr4);

            Point p13 = new Point(520, 130);
            Point p14 = new Point(560, 130);
            Point p15 = new Point(540, 160);
            Point[] tr5 = { p13, p14, p15 };
            g.FillPolygon(astr, tr5);
            Point p16 = new Point(520, 150);
            Point p17 = new Point(560, 150);
            Point p18 = new Point(540, 120);
            Point[] tr6 = { p16, p17, p18 };
            g.FillPolygon(astr, tr6);

            Point p19 = new Point(430, 300);
            Point p20 = new Point(470, 300);
            Point p21 = new Point(450, 330);
            Point[] tr7 = { p19, p20, p21 };
            g.FillPolygon(astr, tr7);
            Point p22 = new Point(430, 320);
            Point p23 = new Point(470, 320);
            Point p24 = new Point(450, 290);
            Point[] tr8 = { p22, p23, p24 };
            g.FillPolygon(astr, tr8);
        }

        private void erase_click(object sender, EventArgs e)
        {
            Brush erase_brush = new SolidBrush(Color.White);
            g.FillRectangle(erase_brush, 0, 0, 686, 415);
        }

        
    }
}
