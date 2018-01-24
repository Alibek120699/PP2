using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace stackProvodnik
{
    class Program
    {
        /*static void PrintState(int index, FileSystemInfo[] array)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            for(int i=0; i < array.Length; ++i)
            {
                if(array[i].GetType() == typeof(DirectoryInfo))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                if(i == index)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                }

                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                }

                Console.Write(array[i].Name);

                for(int j = 0; j < 20 - array[i].Name.Length;++j)
                {
                    Console.Write(' ');
                }
                Console.WriteLine("|");
            }
        }
        public static void OpenFile(int index, string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileSystemInfo[] array = di.GetFileSystemInfos();
            
            
            
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
                        if (array[index].GetType() == typeof(DirectoryInfo))
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
        static string path(string x)
        {
            var stack = new Stack<string>();
            string[] PartsOfPath = x.Split('\\');
            for(int a = 0; a < PartsOfPath.Length; ++a)
            {
                stack.Push(PartsOfPath[a]);
            }
            while(stack.Count > 1)
            {
                stack.Pop();
            }
            return stack.Peek();
            
        }
        /*static void reverse_path(string s)
        {
                stack.Push(PartOfPath[i]);
                
            }
            while (stack.Count > 0)
            {
                stack2.Push(stack.Pop());
                Console.Write(stack2.Pop() + '\\');
            }
        }*/
        static void Main(string[] args)
        {

            //OpenFile(0, @"C:\Users\HP\Desktop\PP2");
            var stack1 = new Stack<string>();
            var stack2 = new Stack<string>();
            string s = Console.ReadLine();
            string ns = null;

            ns = s.Remove(s.LastIndexOf('\\'), s.Length - s.LastIndexOf('\\'));
            Console.WriteLine(ns);
            string[] tool = s.Split('\\');

            for(int g = 0; g < tool.Length-1; ++g)
            {
                stack1.Push(tool[g]);
            }
            
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
                //Console.Write(stack2.Pop() + '\\');
            }
            while(stack2.Count > 1)
            {
                Console.Write(stack2.Pop() + '\\');
            }
            Console.Write(stack2.Pop());
        }
    }
}
