using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSer
{
    public class Food:GameObject
    {
        public Food(Point head, char sign, ConsoleColor color) : base(head, sign, color)
        {

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
        

    }
}
