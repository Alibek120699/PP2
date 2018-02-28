using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Snake
{
    public class Worm : GameObject
    {
        public Worm(Point firstPoint, ConsoleColor color, char sign) : base(firstPoint, color, sign)
        {

        }
        public void Move(int dx, int dy)
        {
            Point newHeadPos = new Point { X = body[0].X + dx, Y = body[0].Y + dy };

            Point last = body[body.Count - 1];

            for (int i = body.Count - 1; i > 1; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;

             
                Console.SetCursorPosition(last.X, last.Y);
                //Clear();
                Console.Write(' ');
            }
            //last = new Point { X = body[body.Count - 1].X - dx, Y = body[body.Count - 1].Y - dy };


            body[0] = newHeadPos;
            
        }
    }
}
