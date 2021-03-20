using System;

namespace exercise_46
{
  class Program
  {
    public static void Main(string[] args)
    {

            Console.Write("> ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            for(int i = userInput; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey(); 

    }
  }
}
