using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSer
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override bool Equals(object obj)
        {
            Point p = obj as Point;
            if (p.X == X && p.Y == Y) return true;
            return false;
        }
    }
}
