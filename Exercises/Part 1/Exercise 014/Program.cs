﻿using System;

namespace exercise_14
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Give me the truth!");
      // Write your code here:
      Console.Write("> ");

            string truth = Console.ReadLine();
            bool booleanValue = System.Convert.ToBoolean(truth);

            Console.WriteLine(booleanValue);
            Console.ReadKey();
    }
  }
}
