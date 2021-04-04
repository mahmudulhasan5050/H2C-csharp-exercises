using System;
using System.Collections.Generic;

namespace exercise_90
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
      
      for(int i = 0; i < lists.Count; i++)
            {
               string[] eachInfo = lists[i].Split(new string[] {","}, StringSplitOptions.None);
                int eachInfoAge = Convert.ToInt32(eachInfo[1]);
                if(eachInfoAge > age)
                {
                    age = eachInfoAge;
                }
                
            }
      Console.WriteLine("Age of the oldest: " + age);
      Console.ReadKey();
    }
  }
}



