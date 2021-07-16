using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            Random r = new Random();

            int winNum = r.Next(0, 100);

            bool win = false;

            do
            {
                Console.Write("Guess a number between 0 and 100....");
                string s = Console.ReadLine();

                int i = int.Parse(s);

                if (i > winNum)
                {
                    Console.WriteLine("Too high! Guess lower...");
                }

                else if (i < winNum)
                {
                    Console.WriteLine("Too low guess higher...");
                }

                else if (i == winNum)
                {
                    Console.WriteLine("You win!!");
                    win = true;
                }

                Console.WriteLine();

            } while (win == false);

            Console.WriteLine("thank you for playing");
            Console.Write("Press any key to finish");
            Console.ReadKey(true);
        }
    }
}
