/*
Christopher Boehm
9/3/2019
ISM 4300
Deliverable 1 / Hello World
*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Shows the phrase "Hello World" then tells the user to press any key to continue.
            Console.WriteLine("Press any key to continue....");
            Console.WriteLine("Hello World");
            Console.ReadKey(true);
        }
    }
}
