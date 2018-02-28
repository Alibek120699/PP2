using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSer
{
    public class Worm : GameObject
    {
        public int DX { get; set; }
        public int DY { get; set; }

        public Worm(Point head, char sign, ConsoleColor color) : base(head, sign, color)
        {

        }

        public void Move()
        {
            Point newHeadPos = new Point { X = body[0].X + DX, Y = body[0].Y + DY };
            
            for (int i = body.Count - 1; i > 0; --i)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;
            }

            body[0] = newHeadPos;
        }
        
    }
}