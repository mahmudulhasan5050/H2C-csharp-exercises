using System;

namespace exercise_07
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give input!");
            // Write your code here:
            Console.Write("> ");
            string greet = Console.ReadLine();
            Console.WriteLine(greet + "\n" + greet + "\n" + greet);
            Console.ReadKey();
        }
    }
}
