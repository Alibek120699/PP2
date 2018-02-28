using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeSer
{
    
    public class Menu
    {
        public bool done = false;
        public string[] items = { "New game", "Load Game", "Settings", "Exit" };
        public int index = 0;
        public void ClearMenu()
        {
            Console.Clear();
        }
        public void ShowMenu()
        {
            ClearMenu();
            
            for(int i=0; i < items.Length; i++)
            {
                if (index == i)
                {
                    Console.ForegroundColor = ConsoleColor.Green;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("             " + items[i]);

                
            }
        }
        public int mindex = 0;
        public void ExitMessage()
        {

            Console.Clear();
            Console.WriteLine("Do you want to exit? ");
            
            string[] choose = { "YES", "NO" };
            
            for (int i = 0; i < 2; i++)
            {
                if (i == mindex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine(choose[i]);
            }
            

        }
        public void Exit()
        {
            ConsoleKeyInfo messagebutton;
            bool mesbool = false;
            while (!mesbool)
            {
                ExitMessage();
                messagebutton = Console.ReadKey();
                switch (messagebutton.Key)
                {
                    case ConsoleKey.UpArrow:
                        mindex--;
                        if (mindex < 0)
                        {
                            mindex = 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        mindex++;
                        if (mindex > 1)
                        {
                            
                            mindex = 0;
                        }
                        break;
                    case ConsoleKey.Enter:
                        if (mindex == 0)
                        {
                            done = true;
                            mesbool = true;
                        }
                        if(mindex==1)
                        {
                            ShowMenu();
                            mesbool = true;
                        }
                        break;
                }

            }
        }
        public void SelectItem()
        {
            while (!done)
            {
                ShowMenu();
                ConsoleKeyInfo menubutton = Console.ReadKey();
                switch (menubutton.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        if (index < 0)
                        {
                            index = items.Length - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        index = (index + 1) % items.Length;
                        break;
                    case ConsoleKey.Enter:
                        if (index == 0)
                        {
                            Game game = new Game();
                            game.Start();
                        }
                        if(index == 1)
                        {
                            Game game = new Game();
                            game.Load();
                        }
                        if(index == 2)
                        {
                            Game game = new Game();
                            game.OpenSettings();
                        }
                        if(index == 3)
                        {
                            
                            Exit();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
