using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeSer
{
    public class Wall: GameObject
    {
        public Wall(Point head, char sign, ConsoleColor color) : base(head, sign, color)
        {

        }

        public void LoadLevel(GameLevel gamelevel)
        {
            string fname = "";

            switch (gamelevel)
            {
                case GameLevel.First:
                    fname = @"level1.txt";
                    break;
                case GameLevel.Second:
                    fname = @"level2.txt";
                    break;
                case GameLevel.Third:
                    fname = @"level3.txt";
                    break;
                default:
                    break;
            }

            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;

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
            fs.Close();
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }
    }
}
