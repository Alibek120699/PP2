using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSer
{
    public abstract class GameObject
    {
        public List<Point> body;
        public char sign;
        public ConsoleColor color;

        public GameObject(List<Point> body, char sign, ConsoleColor color)
        {

        }

        public bool IsBelong()
        {
            return false;
        }
    }
}
