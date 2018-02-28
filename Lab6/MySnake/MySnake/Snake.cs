using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySnake
{   
    [Serializable]
    class Snake
    {
        public char sign;
        public List<Point> body;
        public ConsoleColor color;
        public Snake()
        {
            sign = 'o';
            color = ConsoleColor.Yellow;
            body = new List<Point>();
            body.Add(new Point(12, 10));
            body.Add(new Point(11, 10));
            body.Add(new Point(10, 10));
            body.Add(new Point(9, 10));
           
        }

        public int score = 0;

        public void Move(int dx, int dy)
        {
            Point fill = body[body.Count-1];
            Console.SetCursorPosition(fill.x, fill.y);
            Console.Write(' ');
           

            
            for(int i = body.Count-1;i>0;i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x = body[0].x + dx;
            body[0].y = body[0].y + dy;

            if (Collisionn(Game.wall))
            {

                Game.Gameover = true;
                Console.Clear();
                Game.Die();
            }
            if (ColwithSn())
            {
                Console.Clear();
                for(int i = 0; i < body.Count - 1; ++i)
                {
                    Console.SetCursorPosition(body[i].x, body[i].y);
                    Console.Write(' ');
                }

                Game.Gameover = true;
                Game.Die();
            }
            CollisionWithWall();
            if (Eat())
            {
                score++;
                Console.SetCursorPosition(80, 38);
                Console.WriteLine("Your Score: " + score);

                if (body.Count % 1 == 0 && Game.speed >= 30)
                {
                    Game.speed -= 1;
                }
                Game.food.SetPos();

                if (score == 5)
                {
                    Console.Clear();
                    Game.wall = new Wall(2);
                }
                else if (score == 15)
                {
                    Game.wall = new Wall(3);
                }
            }
            
        }

        public bool Collisionn(Wall wall)
        {
            for(int i = 0; i <wall.body.Count ; ++i)
            {
                if((body[0].x == wall.body[i].x && body[0].y== wall.body[i].y))
                {
                    return true;
                }
            }
            return false;
        }

       

        public bool Eat()
        {
            if (body[0].x == Game.food.space.x
                && body[0].y == Game.food.space.y)
            {
                body.Add(new Point(body[body.Count - 1].x, body[body.Count - 1].y));
                return true;
            }
            return false;

        }
        public void CollisionWithWall()
        {
            
            if (body[0].x > 99)
                body[0].x = 0;
            if (body[0].x < 0)
                body[0].x = 99;
            if (body[0].y > 37)
                body[0].y = 0;
            if (body[0].y < 0)
                body[0].y = 37;

        }

        
        public bool ColWithFoodSn()
        {
            for(int i = 0; i < body.Count-1; ++i)
            {
                if(Game.food.space.x == body[i].x && Game.food.space.x == body[i].y)
                {
                    
                    return false;
                }
                
            }
            return true;
        }

        public bool ColwithSn()
        {
            for(int i = 1; i < body.Count - 1; ++i)
            {
                if(body[0].x==body[i].x && body[0].y == body[i].y)
                {
                        
                    return true;
                }
            }
            return false;
            
        }

        public void Draw()
        {  
           
            for(int i = 0; i < body.Count; ++i)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else Console.ForegroundColor = color;
            
            Console.SetCursorPosition(body[i].x, body[i].y);
                if (ColWithFoodSn())
                {
                    Console.Write(sign);
                }  
            }
        }
    }
}
