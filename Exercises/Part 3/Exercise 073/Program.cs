﻿using System;
using System.Collections.Generic;

namespace exercise_73
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<int> list = new List<int>();
      while (true)
      {
        Console.Write("> ");
        int input = Convert.ToInt32(Console.ReadLine());
        if (input == -1)
        {
          break;
        }
        list.Add(input);
      }

      int sum = 0;
            for(int i = 0; i < list.Count; i++)
            {
                sum = sum + list[i];
            }
            Console.WriteLine("Sum: " + sum);
            Console.ReadKey();
    }
  }
}
