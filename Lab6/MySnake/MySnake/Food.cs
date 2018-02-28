using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace MySnake
{
    class Food
    {
        public Point space;
        public char sign;
        public ConsoleColor color;

        public Food()
        {
            color = ConsoleColor.Green;
            sign = '@';
            space = new Point(20, 17);
        }

        public void SetPos()
        {
            int x = new Random().Next(5, 100);
            int y = new Random().Next(0, 36);
           // Point gdd = new Point(1, 1);

            for (int i = 0; i < Game.snake.body.Count - 1; ++i)
            {
                if (space.x == Game.snake.body[i].x && space.x == Game.snake.body[i].y)
                {
                    //gdd.x = Game.food.space.x;
                    //gdd.y = Game.food.space.y;
                    SetPos();
                }
            }

            for(int i = 0; i < Game.wall.body.Count; ++i)
            {
                if(space.x == Game.wall.body[i].x && space.x == Game.wall.body[i].y)
                {
                    SetPos();
                }
            }
            space = new Point(x, y);
        }




        public void Draw()
        {   

            Console.ForegroundColor = color;
            Console.SetCursorPosition(space.x, space.y);
            
            Console.Write(sign);
        }

      
       
    }
}
