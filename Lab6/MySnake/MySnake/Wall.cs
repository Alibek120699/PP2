using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{
    class Wall
    {
        public List<Point> body;
        //public char sign;
        public ConsoleColor color;

        public Wall()
        {
            color = ConsoleColor.DarkGreen;
        }

        public Wall(int k)
        {
            int row = 1;
            StreamReader sr = new StreamReader(@"C:\Users\HP\Desktop\PP2\Lab6\MySnake\MySnake\Level1.txt");
            StreamReader sr1 = new StreamReader(@"C:\Users\HP\Desktop\PP2\Lab6\MySnake\MySnake\Level2.txt");
            StreamReader sr2 = new StreamReader(@"C:\Users\HP\Desktop\PP2\Lab6\MySnake\MySnake\Level3.txt");
            
            body = new List<Point>();

            while ((line = sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; ++x)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x, Y = y });
                    }
                }
                y++;
            }

            sr.Close();
            if (k == 1)
            {

                int t = int.Parse(sr.ReadLine());
                while (row < t)
                {
                    string line = sr.ReadLine();
                    row++;
                    for (int i = 0; i < line.Length; ++i)
                    {
                        if (line[i] == '#')
                        {
                            this.body.Add(new Point(i, row));
                        }
                    }
                }
                sr.Close();
            }

            if (k == 2)
            {

                int t = int.Parse(sr1.ReadLine());
                while (row < t)
                {
                    string line1 = sr1.ReadLine();
                    row++;
                    for (int i = 0; i < line1.Length; ++i)
                    {
                        if (line1[i] == '#')
                        {
                            body.Add(new Point(i, row));
                        }
                    }
                }
                sr1.Close();
            }

            if (k == 3)
            {

                int t = int.Parse(sr2.ReadLine());
                while (row < t)
                {
                    string line2 = sr2.ReadLine();
                    row++;
                    for (int i = 0; i < line2.Length; ++i)
                    {
                        if (line2[i] == '#')
                        {
                            body.Add(new Point(i, row));
                        }
                    }
                }
                sr2.Close();
            }
        }

        public void Draw()
        {
           foreach(Point p in body)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetCursorPosition(p.x, p.y);
                Console.WriteLine('#');
            }     
        }

    }
}

