using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using System.Timers;

namespace SnakeSer
{
    public enum GameLevel
    {
        First,
        Second,
        Third,
        Fourth
    }

    public class Game
    {
        public static int BoardW = 35;
        public static int BoardH = 35;

        public Worm worm;
        public Food food;
        public Wall wall;
        public bool IsAlive;
        
        public int GameSpeed = 150;

        GameLevel gamelevel;

        public int score = 0;

        public void SetupBoard()
        {
            Console.SetWindowSize(Game.BoardW, Game.BoardH);
            Console.SetBufferSize(Game.BoardW, Game.BoardH);
            Console.CursorVisible = false;
        }

        public Game()
        {
            SetupBoard();
            IsAlive = true;
            gamelevel = GameLevel.First;

            worm = new Worm(new Point { X = 10, Y = 10 },
                            '0', ConsoleColor.Magenta);
            food = new Food(new Point { X = 20, Y = 10 },
                           '1', ConsoleColor.Green);
            wall = new Wall(null, '#', ConsoleColor.Cyan);

            wall.LoadLevel(GameLevel.First);
        }


        public void Start()
        {
            Console.Clear();
            wall.Draw();
            food.Draw();
            worm.Draw();
            ConsoleKeyInfo pressedButton;
            
            do
            {
                pressedButton = Console.ReadKey();
                ChangeDir(pressedButton);

                while (Console.KeyAvailable == false  && IsAlive)
                {
                    Process(); 
                    Thread.Sleep(GameSpeed);
                }

            }
            while (IsAlive);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Menu menu = new Menu();
            menu.done = true;
            Console.WriteLine("GAME OVER!!!");
            
            Console.ReadKey();


        }


        


        public void ChangeDir(ConsoleKeyInfo pressedButton)
        {
            switch (pressedButton.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.DX = 0;
                    worm.DY = -1;
                    break;
                case ConsoleKey.DownArrow:
                    worm.DX = 0;
                    worm.DY = 1;
                    break;
                case ConsoleKey.LeftArrow:
                    worm.DX = -1;
                    worm.DY = 0;
                    break;
                case ConsoleKey.RightArrow:
                    worm.DX = 1;
                    worm.DY = 0;
                    break;
                case ConsoleKey.Escape:
                    Save();
                    break;
            }
        }

        public void Process()
        {
            worm.ClearPoint(worm.body[worm.body.Count-1]);
            worm.Move();

           

            //worm.Clear();
            if (worm.body[0].Equals(food.body[0]))
            {
                worm.body.Add(new Point { X = food.body[0].X, Y = food.body[0].Y });
                score++;
                /*if (score==3)
                {
                    
                    gamelevel++;
                    //worm.Clear();
                    //worm.body.Clear();

                    worm.body.Clear();                  
                    wall.Clear();
                    wall.Draw();
                    wall.LoadLevel(gamelevel);
                    score = 0;
                }*/
               
                Random rx = new Random();
                while (IsPointBelong(wall.body, food.body[0]) || IsPointBelong(worm.body, food.body[0]))
                {
                    food.body[0] = new Point { X = rx.Next(1, 30), Y = rx.Next(1, 30) };
                }
                food.Draw();
                

            }
            else
            {
                foreach (Point p in wall.body)
                {
                    //Console.SetCursorPosition(25, 5);
                    
                    if (worm.body[0].Equals(p))
                    {
                        IsAlive = false;
                        break;
                    }
                }
              /*for (int i = 1; i < worm.body.Count; i++)
                {
                    if (worm.body[i].Equals(worm.body[0]))
                    {
                        IsAlive = false;
                        break;
                    }
                }*/
            }
            worm.Draw();
        }

        bool IsPointBelong(List<Point> body, Point point)
        {
            foreach (Point p in body)
            {
                if (p.Equals(point))
                {
                    return true;
                }
            }
            return false;
        }

        public void Save()
        {
            string s = @"C:\Users\HP\Desktop\PP2\Lab6\SnakeSer\SnakeSer\worm.xml";
            FileStream fs = new FileStream(s, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(this.GetType());
            xs.Serialize(fs, worm);
            xs.Serialize(fs, food);
            xs.Serialize(fs, wall);
            fs.Close();

            


        }
        public void Load()
        {
            
        }

        public void OpenSettings()
        {

        }

        

        
    }
}
