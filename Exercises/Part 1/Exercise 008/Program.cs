using System;

namespace exercise_08
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("What is your name?");
            Console.Write("> ");
            string name = Console.ReadLine();
            string greet = "Hello ";
            string exclamation = "!";
            Console.WriteLine(greet + name + exclamation);
            Console.ReadKey();
        }
    }
}
