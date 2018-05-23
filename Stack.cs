using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Stack
    {

        public string[] stck { get; set; }
        private int tos;

        public Stack(uint size)
        {

            stck = new string[size];
            tos = 0;
        }

        public void Push(string str)
        {

            if (tos >= stck.Length)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stack is full");
                Console.ResetColor();

                return;
            }
            else
            {

                Console.Write(str);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" -add");
                Console.ResetColor();

                stck[tos] = str;
                tos++;
            }
        }

        public void Pop()
        {

            if (tos == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stack is empty");
                Console.ResetColor();

                return;
            }
            else
            {

                Console.Write(stck[tos - 1]);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(" -removed");
                Console.ResetColor();

                stck[tos - 1] = "";
                tos--;
            }


        }

        public void deleteAll()
        {

            if (tos == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stack is empty");
                Console.ResetColor();

                return;
            }
            else
            {

                for (int i = 0; i < stck.Length; i++)
                {
                    Console.Write(stck[i]);
                    Console.ForegroundColor = ConsoleColor.Green;

                    if (stck[i] != "")
                        Console.WriteLine(" -removed");
                    
                    Console.ResetColor();
                    stck[i] = "";
                }
                tos = 0;
            }

        }

        public void Print()
        {

            foreach (string str in stck)
                Console.Write(str + "\n");
            Console.WriteLine();
        }
    }
}
