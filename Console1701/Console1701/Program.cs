using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Console1701
{
    class Program
    {
        public static void PrintState(int index, FileSystemInfo[] array)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for(int i=0; i < array.Length; ++i)
            {
                if (array[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                if(i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }
                Console.Write(array[i].Name);

                for(int j = 1; j < 30-array[i].Name.Length; ++j)
                {
                    Console.Write(' ');
                }

                Console.WriteLine("|");
            }
        }
        public static void OpenFile(int index, string path)
        {
            DirectoryInfo cd = new DirectoryInfo(path);
            FileSystemInfo[] array = cd.GetFileSystemInfos();
            bool quit = false;

            while (!quit)
            {
                PrintState(index, array);
                ConsoleKeyInfo PressedKey = Console.ReadKey();
                switch (PressedKey.Key)
                {
                    case ConsoleKey.UpArrow:
                        index--;
                        if (index < 0)
                        {
                            index = array.Length - 1;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        index = (index + 1) % array.Length;
                        break;
                    case ConsoleKey.Enter:
                        if(array[index].GetType() == typeof(DirectoryInfo))
                        {
                            OpenFile(0, array[index].FullName);
                        }
                        break;
                    case ConsoleKey.Escape:
                        quit = true;
                        break;
                    default:
                        break;

                }
            }
        }
        static void Main(string[] args)
        {
            OpenFile(0, @"C:\Users\HP\Desktop\PP2");
            //string c = Console.ReadLine();
            //OpenFile(0, c);
            

        }
        
    }
}
