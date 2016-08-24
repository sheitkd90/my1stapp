//A Hello World! program in C#.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Hello
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");

            //Keep the console window open in debub mode.
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
