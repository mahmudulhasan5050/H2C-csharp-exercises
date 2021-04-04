using System;
using System.Collections.Generic;

namespace exercise_91
{
  class Program
  {
    public static void Main(string[] args)
    {
      List<string> lists = new List<string>();

      while (true)
         {
            Console.Write("> ");
            string input = Console.ReadLine();
             if (input == "")
             {
              break;
             }

             lists.Add(input);
            
         }

      int age = 0;
      string name = "";
      for(int i = 0; i < lists.Count; i++)
            {
               string[] eachInfo = lists[i].Split(new string[] {","}, StringSplitOptions.None);
                int eachInfoAge = Convert.ToInt32(eachInfo[1]);
                if(eachInfoAge > age)
                {
                    name = eachInfo[0];
                    age = eachInfoAge;
                }
                
            }
      Console.WriteLine("Name of the oldest: " + name);
      Console.ReadKey();
    }
  }
}



