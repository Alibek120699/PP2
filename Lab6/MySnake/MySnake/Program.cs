using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Threading.Tasks;

namespace MySnake
{
    class Program
    {

        

        static void filldown(string pred,string now,int maspred,int masnow)
        {
            //string[] massivload = new string[] { "New game", "Resume", "Best score", "Levels" };

            Console.SetCursorPosition(45, 10 + maspred);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(pred);

            Console.SetCursorPosition(45, 10 + masnow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(now);

            Console.BackgroundColor = ConsoleColor.Blue;
        }

        static void fillup(string pred, string now, int maspred,int masnow)
        {
            Console.SetCursorPosition(45, 10 + maspred);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(pred);

            Console.SetCursorPosition(45, 10 + masnow);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine(now);

            Console.BackgroundColor = ConsoleColor.Blue;
        }

        static void MoveForSnake()
        {
            while (!Game.Gameover)
            {
                switch (Game.dir)
                {
                    case 1:
                        Game.snake.Move(0, -1);
                        break;
                    case 2:
                        Game.snake.Move(0, 1);
                        break;
                    case 3:
                        Game.snake.Move(-1, 0);
                        break;
                    case 4:
                        Game.snake.Move(1,0);
                        break;
                }
                if (Game.Gameover == false)
                {
                    Game.Draw();
                    Thread.Sleep(Game.speed);
                }
            }
        }

        static void Main(string[] args)
        {

            Game.Settings();

            int start = 0;
            int posload = 0;
            Wall wall = new Wall(1);
            /*Snake sy = new Snake();
            Serial ss = new Serial();
            ss.f1(sy);
            return;
            */
            string[] massivload = new string[] { "New game", "Resume", "Best score", "Levels" };

            while (!Game.quit)
            {
                ConsoleKeyInfo btt = Console.ReadKey();
                switch (btt.Key)
                {
                    case ConsoleKey.UpArrow:
                        posload--;
                        if (posload < 0)
                        {
                            posload = 3;
                            fillup(massivload[0],massivload[3],0,posload);
                        }
                        else
                        {
                            fillup(massivload[posload+1],massivload[posload],posload+1,posload);
                        }
                        break;
                    case ConsoleKey.Enter:
                        if(posload == 0)
                        {
                            Game.quit = true;
                            Console.Clear();
                //            Game.Init();
                            start = 1;
                        }
                        else if (posload == 1)
                        {
                            Game.quit = true;
                            //Console.Clear();
                            start = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        posload++;
                        if (posload < 4)
                        {
                            //Console.SetCursorPosition(45, 10 + posload);
                            filldown(massivload[posload-1],massivload[posload],posload-1,posload);                    
                        }
                        else
                        {
                            posload = 0;
                            filldown(massivload[3], massivload[0], 3, 0);
                        }            
                        //Console.SetCursorPosition(45, 10 + posload);
                        //Console.ForegroundColor = ConsoleColor.Red;
                        //Console.BackgroundColor = ConsoleColor.Yellow;
                       // Console.WriteLine(massivload[posload]);
                        break;
                } 
            }

            if (start == 1)
            {
                if (posload == 0) { Game.Init(); }
                else
                {
                    Console.Clear();
                    Game.Init();
                    Serial ssss = new Serial();
                    Game.snake = ssss.f2();
                    
                    
                }
               
                Thread mythread = new Thread(MoveForSnake);
                mythread.Start();
                while (!Game.Gameover)
                {
                    //Game.Draw();
                    ConsoleKeyInfo btn = Console.ReadKey();
                    switch (btn.Key)
                    {
                        case ConsoleKey.UpArrow:
                            Game.dir = 1;
                            break;
                        case ConsoleKey.DownArrow:
                            Game.dir = 2;
                            break;
                        case ConsoleKey.LeftArrow:
                            Game.dir = 3;
                            break;
                        case ConsoleKey.RightArrow:
                            Game.dir = 4;
                            break;
                        case ConsoleKey.Escape:

                            mythread.Abort();
                            
                            Serial ss = new Serial();
                            ss.f1(Game.snake);
                            return;
                            //Serial s = new Serial();
                              //  s.f1(Game.snake);
                                //mythread.Abort();
                               // return;
                    }
                }
            }
        }
    }
}


