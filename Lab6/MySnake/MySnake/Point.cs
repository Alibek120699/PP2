using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MySnake
{   [Serializable]
    class Point
    {
        public int x, y;

        public Point(int _x,int _y)
        {
            x = _x;
            y = _y;
        }
    }
}
