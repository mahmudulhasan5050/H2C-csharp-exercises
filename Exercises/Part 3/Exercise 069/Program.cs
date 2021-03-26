using System;
using System.Collections.Generic;

namespace exercise_69
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
            Console.Write("From where?\n> ");
            int start = Convert.ToInt32(Console.ReadLine());
            Console.Write("Where to?\n> ");
            int end = Convert.ToInt32(Console.ReadLine());
           for(int i = 0; i < list.Count; i++)
            {
                if(list[i] >= start && list[i] <= end)
                {
                    Console.WriteLine(list[i]);
                }
            }
           Console.ReadKey();
    }
  }
}
