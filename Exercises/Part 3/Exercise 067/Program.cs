﻿using System;
using System.Collections.Generic;

namespace exercise_67
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();
      while (true)
      {
        Console.Write("> ");
        string input = Console.ReadLine();
        if (input == "")
        {
          break;
        }
        list.Add(input);
      }
      int last = list.Count - 1;

      Console.WriteLine(list[0]);
      Console.WriteLine(list[last]);
            Console.ReadKey();

    }
  }
}
