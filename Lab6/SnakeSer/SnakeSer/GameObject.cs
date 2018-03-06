using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace SnakeSer
{
    public abstract class GameObject
    {
        public List<Point> body { get; set; }
        public char sign { get; }
        public ConsoleColor color { get; }
        public object Streamwriter { get; private set; }

        public GameObject(Point head, char sign, ConsoleColor color)
        {
            this.body = new List<Point>();
            if (head != null)
            {
                this.body.Add(head);
            }
            this.sign = sign;
            this.color = color;
        }

       



        public void Draw()
        {
            
            Clear();
            Console.ForegroundColor = this.color;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(this.sign);
                
            }
        }
        public void ClearPoint(Point p)
        {
            Console.SetCursorPosition(p.X, p.Y);
            Console.Write(' ');
        }
        

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            foreach (Point p in body)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write(sign);
            }
        }

    }

}

