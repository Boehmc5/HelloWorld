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
            //Asks user to press any key to continue... then writes "Hello World".
            Console.WriteLine("Press any key to continue....");
            Console.WriteLine("Hello World");
            Console.ReadKey(true);
        }
    }
}
