using System;

namespace exercise_35
{
  class Program
  {
    public static void Main(string[] args)
    {
       while (true) { 
            Console.Write("Give a number:\n> ");
            int  answer = Convert.ToInt32(Console.ReadLine());

            if(answer == 42)
            {
                break;
            }
         
            }
            Console.ReadKey();

    }
  }
}
