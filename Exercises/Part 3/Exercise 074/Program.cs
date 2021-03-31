using System;
using System.Collections.Generic;

namespace exercise_74
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> list = new List<string>();

      string found = "";
      string notFound = "";


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
      

      Console.WriteLine("Search for?");
      Console.Write("> ");
      string userInput = Console.ReadLine();
      
      for(int i = 0; i < list.Count; i++)
            {
                if(list[i] == userInput)
                {
                    found = list[i];
                }
                else
                {
                    notFound = userInput;
                }
            }

      if(found != "")
            {
                Console.WriteLine(found + " was found!");
            }
      else
            {
                Console.WriteLine(notFound + " was not found!");
            }

      Console.ReadKey();
    }
  }
}

