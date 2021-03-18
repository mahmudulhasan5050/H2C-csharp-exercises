using System;

namespace exercise_34
{
  class Program
  {
    public static void Main(string[] args)
    {
            while (true) { 
            Console.Write("Do you want to continue?\n> ");
            string  answer = Console.ReadLine();

            if(answer == "no")
            {
                break;
            }
         
            }
            Console.ReadKey();
    }
  }
}
