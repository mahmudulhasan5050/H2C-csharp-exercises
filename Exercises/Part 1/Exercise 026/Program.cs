﻿using System;

namespace exercise_26
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Give your age:\n> ");

            int year = Convert.ToInt32(Console.ReadLine());

            if(year < 1900)
            {
                Console.WriteLine("You're old");
            }
      
            Console.ReadKey();

    }
  }
}
