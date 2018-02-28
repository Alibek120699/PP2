using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public abstract class GameObject
    {
        public List<Point> body { get; }
        public char sign { get; }
        public ConsoleColor color { get; }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }

        public GameObject(Point firstPoint, ConsoleColor color, char sign)
        {
            this.body = new List<Point>();
            if (firstPoint != null)
            {
                this.body.Add(firstPoint);
            }
            this.color = color;
            this.sign = sign;
        }

        public bool IsPointBelong(Point p)
        {
            bool res = false;
            for (int i = 0; i < this.body.Count; i++)
            {
                if (this.body[i].X == p.X && this.body[i].Y == p.Y)
                {
                    res = true;
                    break;
                }
            }
            return res;
        }

        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
            
        }
    }
}
