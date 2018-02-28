using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace MySnake
{
    class Game
    {
        public static bool Gameover;
        public static Snake snake;
        public static bool quit;
        public static int speed;
        public static int dir;
        public static Food food;
        public static Wall wall;
        public static int score;
        public static void Init()
        {
            
            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetWindowSize(100, 40);
            Console.SetCursorPosition(80, 38);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Your Score: " + '0');
            
            Gameover = false;
            dir = 4;
            speed = 100;

            snake = new Snake();
            food = new Food();
            wall = new Wall(1);
            score=0;   
        }

        public static void Die()
        {
            Console.Clear();
            string[] masdie = new string[] { "Yes","No" };
            Console.SetCursorPosition(30, 1);
            Console.WriteLine("Do you want to save your score? ");

           Console.SetCursorPosition(38, 3);
            Console.ReadKey(); 
            
        }

        public static void Settings()
        {

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.SetWindowSize(100, 40);

            quit = false;

            FileStream fs = new FileStream(@"C:\Users\HP\Desktop\PP2\Lab6\MySnake\MySnake\bin\Debug\SNAKEcp.txt", FileMode.OpenOrCreate,FileAccess.Read);
            StreamReader str = new StreamReader(fs);

            string[] massivload = new string[] { "New game", "Resume", "Best score", "Levels" };
            Console.ForegroundColor = ConsoleColor.Red; 

            int row = 0;
            string line = "";
            while (row < 7)
            {
                line = str.ReadLine();
                Console.WriteLine(line);
                row++;
            }
            
            Console.SetCursorPosition(45, 10);

            for (int i = 0; i < massivload.Length; ++i)
            {

                Console.SetCursorPosition(45, 10 + i);
                Console.WriteLine(massivload[i]);
                
            }
            str.Close();
            fs.Close();
        }

        public static void Draw()
        {
            //    Console.Clear();
            wall.Draw();
            snake.Draw();
            food.Draw();
            
        }
    }
}
