using System;

namespace MyVSCodeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // get some input from the console
            Console.WriteLine("What's your name?");
            string name = Console.ReadLine(); // waits for input until user presses ENTER
            Console.WriteLine($"Hello, {name} nice to meet you!");
        }
    }
}
