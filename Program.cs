using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp
{
    class Program2
    {
        static int Main(string[] args)
        {

            
            Stack stack = new Stack(5);

            string str;

            start();

            while (true) {

                str = Console.ReadLine();
                switch (str) {

                    case "add":
                        {
                            add(str,stack);
                            break;
                        }

                    case "delete":
                        {

                            delete(stack);
                            break;
                        }

                    case "print":
                        {

                            print(stack);
                            break;
                        }

                    case "clear": {

                            Console.Clear();
                            break;
                        }

                    case "create_file": {

                            create_file(stack);
                            break;
                        }

                    case "exit": {

                            return 0;
                        }

                    default:{

                            @default(str);
                            break;
                        }
                }
            }
            
        }

        public static void create_file(Stack stack) {

            FileStream file1 = new FileStream("C:\\new_file.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);

            foreach (string strr in stack.stck)
            {
                writer.Write(strr + " ");
            }
            writer.Close();

            Console.WriteLine("File was created in C:\\new_file.txt");
        }

        public static void start() {

            Console.WriteLine("Stack.\nLebedev Kirill 22.05.2018 12:56");

            System.Threading.Thread.Sleep(1000);
            Console.Clear();

            Console.WriteLine("Commands:\n\t: add\n\t: delete\n\t: clear\n\t: print\n\t: create_file\n\t: exit");
        }

        public static void add(string str,Stack stack) {

            Console.Clear();
            Console.Write(": ");
            str = Console.ReadLine();

            Console.Clear();

            stack.Push(str);
        }

        public static void delete(Stack stack) {

            Console.Clear();
            stack.Pop();
        }

        public static void print(Stack stack){

            Console.Clear();
            stack.Print();
        }

        public static void @default(string str) {

            Console.Clear();
            Console.Write(str);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" -unknown command");
            Console.ResetColor();
        }

    }
}
