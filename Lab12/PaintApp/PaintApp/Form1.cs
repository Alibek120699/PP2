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
    public enum Tool { Pencil, Rectangle, Ellipse, Line, Triangle, IsoTriangle, Eraser, Fill};

    enum BmpCreationMode { AfterFill, FromFile, Init};
   
    public partial class Form1 : Form
    {
        Point firstpoint;
        Point secondpoint;
        Bitmap btmp;
        Graphics gfx;
        GraphicsPath path;
        Pen pen;
        Pen erase;
        Pen figurepen = new Pen(Color.Black, 5);
        int fx, fy, sx, sy;
        Tool t;
        
        public Form1()
        {
            InitializeComponent();
            SetupPictureBox(BmpCreationMode.Init, "");
            gfx = CreateGraphics();
            pen = new Pen(Color.Black, 2);
            path = new GraphicsPath();
            btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = btmp;
            gfx = Graphics.FromImage(btmp);
            gfx.Clear(Color.White);
            t = Tool.Pencil;
        }
        private void SetupPictureBox(BmpCreationMode mode, string fileName)
        {

            if (mode == BmpCreationMode.Init)
            {
                btmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
            else if (mode == BmpCreationMode.FromFile)
            {
                btmp = new Bitmap(Bitmap.FromFile(openFileDialog1.FileName));
            }

            gfx = Graphics.FromImage(btmp);

            if (mode == BmpCreationMode.Init)
            {
                gfx.Clear(Color.White);
            }

            pictureBox1.Image = btmp;
            gfx.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncolor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                figurepen.Color = colorDialog1.Color;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            SetupPictureBox(BmpCreationMode.AfterFill, "");
            if (t == Tool.Fill)
            {
                MapFill mf = new MapFill();
                mf.Fill(gfx, firstpoint, pen.Color, ref btmp);
                SetupPictureBox(BmpCreationMode.AfterFill, "");
            }
            firstpoint = e.Location;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            string widthofpen = toolStripMenuItem3 + "";
            pen = new Pen(pen.Color, int.Parse(widthofpen));
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            string widthofpen = toolStripMenuItem4 + "";
            pen = new Pen(pen.Color, int.Parse(widthofpen));
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            string widthofpen = toolStripMenuItem5 + "";
            pen = new Pen(pen.Color, int.Parse(widthofpen));
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            string widthofpen = toolStripMenuItem6 + "";
            pen = new Pen(pen.Color, int.Parse(widthofpen));
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            string widthoferaser = toolStripMenuItem7 + "";
            erase = new Pen(Color.White, int.Parse(widthoferaser));
        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            string widthoferaser = toolStripMenuItem8 + "";
            erase = new Pen(Color.White, int.Parse(widthoferaser));
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            string widthoferaser = toolStripMenuItem9 + "";
            erase = new Pen(Color.White, int.Parse(widthoferaser));
        }

        private void toolStripMenuItem10_Click(object sender, EventArgs e)
        {
            string widthoferaser = toolStripMenuItem10 + "";
            erase = new Pen(Color.White, int.Parse(widthoferaser));
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            figurepen = new Pen(figurepen.Color, 5);
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
                        RectangleF r = new RectangleF(secondpoint.X - pen.Width / 2, secondpoint.Y - pen.Width / 2, pen.Width, pen.Width);
                        gfx.FillEllipse(pen.Brush, r);
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
                        //erase = new Pen(Color.White, 10);
                        gfx.DrawLine(erase, firstpoint, secondpoint);
                        RectangleF er= new RectangleF(secondpoint.X - erase.Width/2, secondpoint.Y - erase.Width/2, erase.Width, erase.Width);
                        gfx.FillRectangle(erase.Brush, er);
                        firstpoint = secondpoint;
                        break;
                    case Tool.Fill:
                        
                        break;
                }
                pictureBox1.Refresh();
            }
        }

        private void pencilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Pencil;
        }

        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Rectangle;
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Ellipse;
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Line;
        }

        private void triangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Triangle;
        }

        private void isoTriangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.IsoTriangle;
        }

        

        

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                SetupPictureBox(BmpCreationMode.FromFile, openFileDialog1.FileName);
            }
        }

        private void fillToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Fill;
        }

        

        private void eraserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            t = Tool.Eraser;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if(path!= null)
            {
                switch (t)
                {
                    case Tool.Pencil:
                        gfx.DrawPath(pen, path);
                        break;
                    case Tool.Rectangle:
                        gfx.DrawPath(figurepen, path);
                        break;
                    case Tool.Line:
                        gfx.DrawPath(figurepen, path);
                        break;
                    case Tool.Ellipse:
                        gfx.DrawPath(figurepen, path);
                        break;
                    case Tool.Triangle:
                        gfx.DrawPath(figurepen, path);
                        break;
                    case Tool.IsoTriangle:
                        gfx.DrawPath(figurepen, path);
                        break;
                    
                }
                
                
            }
            
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(pen, path);
        }

        
    }
}
