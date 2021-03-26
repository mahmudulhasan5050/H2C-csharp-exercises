using System;
using System.Collections.Generic;

namespace exercise_66
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
      int lastWord = list.Count - 1;
      Console.WriteLine(list[lastWord]);
      Console.ReadKey();
    }
  }
}
