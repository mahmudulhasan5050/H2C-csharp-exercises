﻿using System;

namespace exercise_09
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Write your code here:
            Console.WriteLine("Hello, how are you?");
            Console.Write("> ");
            string msg1 = Console.ReadLine();
            Console.WriteLine("That's interesting, tell me more");
            Console.Write("> ");
            string msg2 = Console.ReadLine();
            Console.WriteLine("Thank you for sharing!");
            Console.ReadKey();
        }
    }
}
