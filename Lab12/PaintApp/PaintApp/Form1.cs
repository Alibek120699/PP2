using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintApp
{
    public enum Tool { Pencil, Rectangle, Ellipse, Line, Triangle, IsoTriangle, Eraser};

    public partial class Form1 : Form
    {
        Point firstpoint;
        Point secondpoint;
        Bitmap btmp;
        Graphics gfx;
        GraphicsPath path;
        Pen pen;
        int fx, fy, sx, sy;
        Tool t;

        public Form1()
        {
            InitializeComponent();
            gfx = CreateGraphics();
            pen = new Pen(Color.Black, 2);
            path = new GraphicsPath();
            btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btmp;
            gfx = Graphics.FromImage(btmp);
            gfx.Clear(Color.White);
            t = Tool.Pencil;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            firstpoint = e.Location;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                path.Reset();
                secondpoint = e.Location;
                //path.AddLine(firstpoint, secondpoint);
                Refresh();
                fx = firstpoint.X;
                fy = firstpoint.Y;
                sx = secondpoint.X;
                sy = secondpoint.Y;
                switch (t)
                {
                    case Tool.Pencil:
                        gfx.DrawLine(pen, firstpoint, secondpoint);
                        firstpoint = secondpoint;
                        break;
                    case Tool.Rectangle:
                        if (sx < fx && sy < fy)
                        {
                            path.AddRectangle(new Rectangle(sx, sy, fx - sx, fy - sy));
                        }
                        else if (sx < fx && sy > fy)
                        {
                            path.AddRectangle(new Rectangle(sx, fy, fx - sx, sy - fy));
                        }
                        else if (sx > fx && sy < fy)
                        {
                            path.AddRectangle(new Rectangle(fx, sy, sx - fx, fy - sy));
                        }
                        else
                        {
                            path.AddRectangle(new Rectangle(fx, fy, sx-fx, sy-fy));
                        }
                        break;
                    case Tool.Ellipse:
                        if (sx < fx && sy < fy)
                        {
                            path.AddEllipse(new Rectangle(sx, sy, fx - sx, fy - sy));
                        }
                        else if (sx < fx && sy > fy)
                        {
                            path.AddEllipse(new Rectangle(sx, fy, fx - sx, sy - fy));
                        }
                        else if (sx > fx && sy < fy)
                        {
                            path.AddEllipse(new Rectangle(fx, sy, sx - fx, fy - sy));
                        }
                        else
                        {
                            path.AddEllipse(new Rectangle(fx, fy, sx - fx, sy - fy));
                        }
                        break;
                    case Tool.Line:
                        path.AddLine(firstpoint, secondpoint);
                        break;
                    case Tool.Triangle:
                        Point interior;
                        if (sx < fx && sy < fy)
                        {
                            interior = new Point(sx, fy);
                            Point[] tr1 = { secondpoint, interior, firstpoint };
                            path.AddPolygon(tr1);
                        }
                        else if (sx < fx && sy > fy)
                        {
                            interior = new Point(sx, fy);
                            firstpoint = new Point(fx, sy);
                            Point[] tr2 = { interior, secondpoint, firstpoint };
                            path.AddPolygon(tr2);
                        }
                        else if (sx > fx && sy < fy)
                        {
                            interior = new Point(fx, sy);
                            secondpoint = new Point(sx, fy);
                            Point[] tr3 = { interior, firstpoint, secondpoint };
                            path.AddPolygon(tr3);
                        }
                        else
                        {
                            interior = new Point(fx, sy);
                            Point[] tr4 = { firstpoint, interior, secondpoint };
                            path.AddPolygon(tr4);
                        }
                        break;
                    case Tool.IsoTriangle:
                        Point exterior;
                        if (fx < sx && fy > sy)
                        {
                            if ((sx - fx) % 2 == 1)
                            {
                                interior = new Point((sx + fx - 1) / 2, sy);
                            }
                            else
                            {
                                interior = new Point((sx + fx) / 2, sy);
                            }
                            exterior = new Point(sx, fy);
                            Point[] isotr1 = { firstpoint, interior, exterior };
                            path.AddPolygon(isotr1);
                        }
                        else if (fx < sx && fy < sy)
                        {
                            exterior = new Point(fx, sy);
                            if ((sx - fx) % 2 == 1)
                            {
                                interior = new Point((sx + fx - 1) / 2, fy);
                            }
                            else
                            {
                                interior = new Point((sx + fx) / 2, fy);
                            }
                            Point[] isotr2 = { exterior, interior, secondpoint };
                            path.AddPolygon(isotr2);
                        }
                        else if (fx > sx && fy < sy)
                        {
                            if ((fx - sx) % 2 == 1)
                            {
                                interior = new Point((fx + sx - 1) / 2, fy);
                            }
                            else
                            {
                                interior = new Point((fx + sx) / 2, fy);
                            }
                            exterior = new Point(fx, sy);
                            Point[] isotr3 = { secondpoint, interior, exterior };
                            path.AddPolygon(isotr3);
                        }
                        else
                        {
                            if ((fx - sx) % 2 == 1)
                            {
                                interior = new Point((fx + sx - 1) / 2, sy);
                            }
                            else
                            {
                                interior = new Point((fx + sx) / 2, sy);
                            }
                            exterior = new Point(sx, fy);
                            Point[] isotr4 = { exterior, interior, firstpoint };
                            path.AddPolygon(isotr4);
                        }
                        break;
                    case Tool.Eraser:
                        Pen erase = new Pen(Color.White, 10);
                        gfx.DrawLine(erase, firstpoint, secondpoint);
                        firstpoint = secondpoint;
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(path!= null)
            {
                gfx.DrawPath(pen, path);
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen, path);
        }

        private void tools_click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            switch (btn.Text)
            {
                case "Pencil":
                    t = Tool.Pencil;
                    break;
                case "Rect":
                    t = Tool.Rectangle;
                    break;
                case "Ellipse":
                    t = Tool.Ellipse;
                    break;
                case "Line":
                    t = Tool.Line;
                    break;
                case "Triangle":
                    t = Tool.Triangle;
                    break;
                case "IsoTriangle":
                    t = Tool.IsoTriangle;
                    break;
                case "Eraser":
                    t = Tool.Eraser;
                    break;
            }
        }
    }
}
