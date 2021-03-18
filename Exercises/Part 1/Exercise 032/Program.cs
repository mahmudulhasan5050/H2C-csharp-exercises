using System;

namespace exercise_32
{
  class Program
  {
    public static void Main(string[] args)
    {
           Console.Write("Speak, friend, and enter!\n> ");
            string message = Console.ReadLine();

            string myMessage = "Mellon";

            if(message == myMessage)
            {
                Console.WriteLine("Welcome, friend");
            }
            else
            {
                Console.WriteLine("They've got a cave troll!");
            }
            Console.ReadKey();
    }
  }
}
