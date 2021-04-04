using System;
using System.Collections.Generic;

namespace exercise_92
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

      int ageHighest = 0;
      string name = "";
      int lengthName = 0;
      int currentYear = 2020;

      for(int i = 0; i < lists.Count; i++)
            {
               string[] eachInfo = lists[i].Split(new string[] {","}, StringSplitOptions.None);
                int eachInfoYear = Convert.ToInt32(eachInfo[1]);
                string eachInfoName = eachInfo[0];
                int age = currentYear - eachInfoYear;

                if(age > ageHighest)
                {                   
                    ageHighest = age;
                }
                if(eachInfoName.Length > lengthName)
                {
                    lengthName = eachInfoName.Length;
                    name = eachInfoName;
                }
                
            }
      Console.WriteLine("Longest name: " + name);   //If name lenght is same, it will show only the first one.
      Console.WriteLine("Highest age: " + ageHighest);
      Console.ReadKey();
    }
  }
}



