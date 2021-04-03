using System;
using System.Collections.Generic;

namespace exercise_87
{
  class Program
  {
    public static void Main(string[] args)
    {

            bool start = true;
            

            while (start) { 
            Console.Write("> ");
            string input = Console.ReadLine();
            string[] word = input.Split(new string[] {" "}, StringSplitOptions.None);
            

            if(input != "") 
                {                      
                  for(int i = 0; i < word.Length; i++) 
                    {
                        if (word[i].Contains("av"))
                        {
                            Console.WriteLine(word[i]);
                        }
                    }
                }
                else
                {
                    break;
                }
        }
            start = false;
            Console.ReadKey();
    }

  }

}

