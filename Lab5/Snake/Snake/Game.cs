using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public enum GameLevel
    {
        First,
        Second,
        Bonus
    }

    public class Game
    {
        public static int boardW = 35;
        public static int boardH = 35;

        bool[,] field = new bool[10, 10];

        public Worm worm;
        public Food food;
        public Wall wall;
        public bool isAlive;

        GameLevel gameLevel;
        
        public int count = 0;
        public void SetupBoard()
        {
            Console.SetWindowSize(Game.boardW, Game.boardH);
            Console.SetBufferSize(Game.boardW, Game.boardH);
            Console.CursorVisible = false;
        }

        public Game()
        {
            isAlive = true;
            gameLevel = GameLevel.First;

            worm = new Worm(new Point { X = 10, Y = 10 },
                            ConsoleColor.Magenta, '0');
            food = new Food(new Point { X = 20, Y = 10 },
                           ConsoleColor.Green, '1');
            wall = new Wall(null, ConsoleColor.Cyan, '#');

            wall.LoadLevel(GameLevel.First);
            
        }

        public void Draw()
        {

        }
       
        public void Exit()
        {

        }

        public void Start()
        {

        }

        public void Process()
        {
            ConsoleKeyInfo pressedButton = Console.ReadKey();
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Move(0, -1);
                    break;
                case ConsoleKey.DownArrow:
                    worm.Move(0, 1);
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Move(-1, 0);
                    break;
                case ConsoleKey.RightArrow:
                    worm.Move(1, 0);
                    break;
                case ConsoleKey.Escape:
                    break;
            }

            if (worm.body[0].Equals(food.body[0]))
            {
                worm.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y });
                count++;
                if (count==3)
                {
                    wall.Clear();
                    worm.Clear();
                    worm.body.Clear();
                    wall.LoadLevel(gameLevel);
                    wall.Draw();
                    gameLevel++;
                    count = 0;
                }
                Random rx = new Random();
                while(wall.IsPointBelong(food.body[0]) || worm.IsPointBelong(food.body[0]))
                {
                    food.body[0] = new Point { X=rx.Next(1,30), Y=rx.Next(1,30) };
                }

                
                
            }
            else
            {
                foreach (Point p in wall.body)
                {
                    if (p.Equals(worm.body[0]))
                    {
                        Console.Clear();
                        Console.WriteLine("GAME OVER!!!");
                        isAlive = false;
                        break;
                    }
                }
                for(int i=1; i<worm.body.Count; i++)
                {
                    if (worm.body[i].Equals(worm.body[0]))
                    {
                        Console.Clear();
                        Console.WriteLine("GAME OVER!!!");
                        isAlive = false;
                        break;
                    }
                }           
            }
        }
    }
}
