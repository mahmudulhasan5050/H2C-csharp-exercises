using System;

namespace exercise_45
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("> ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i <= userInput; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();   
    }
  }
}
