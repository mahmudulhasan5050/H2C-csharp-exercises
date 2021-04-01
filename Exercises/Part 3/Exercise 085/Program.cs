using System;
using System.Collections.Generic;

namespace exercise_85
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Enter username: \n> ");
            string username = Console.ReadLine();
            Console.Write("Enter password: \n> ");
            string password = Console.ReadLine();

            if(username == "alex" && password == "sunshine")
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else if(username == "emma" && password == "haskell")
            {
                Console.WriteLine("You have successfully logged in!");
            }
            else
            {
                Console.WriteLine("Incorrect username or password!");
            }

        Console.ReadKey();
    }
  }
}

