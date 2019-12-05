using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePractice
{
    class A
    {
        static A()
        { Console.WriteLine("Static A"); }

        internal A()
        { Console.WriteLine("Default A"); }
        int Add(int x, int y)
        {
            return x + y;
        }
    }

    class Program : A
    {
        static Program()
        { Console.WriteLine("Static P"); }

        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");
            A a = new Program();
            
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
