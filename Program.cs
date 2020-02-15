using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flowchartpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose (i)nterpretted or (C)ompiled: ");
            string input = Console.ReadLine();
            if (input == "I" || input == "i")
            {
                Console.WriteLine("(P)ython or (J)avascript");
                input = Console.ReadLine();
                if (input == "P" || input == "p")
                {
                    Console.WriteLine("Print(\"Hello\")");
                }
                else
                {
                    Console.WriteLine("Alert(\"Hello\")");
                }
            }
           else if (input == "C" || input == "c")
            {
                Console.WriteLine("(C)# or (J)ava");
                input = Console.ReadLine();

                if (input == "C" || input == "c")
                {
                    Console.WriteLine("Console.WriteLine(\"Hello\")");
                }
                else
                {
                    Console.WriteLine("Println(\"Hello\")");
                }
            }
               else
            {
                Console.WriteLine("That is invalid");
            } 

           
            
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
