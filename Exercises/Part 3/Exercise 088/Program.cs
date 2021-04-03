using System;
using System.Collections.Generic;

namespace exercise_88
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
                 
                    Console.WriteLine(word[0]);
                    
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



