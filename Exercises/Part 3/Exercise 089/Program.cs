using System;
using System.Collections.Generic;

namespace exercise_89
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
                    int lastIndex = word.Length - 1;
                    Console.WriteLine(word[lastIndex]);
                    
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



