using System;

namespace exercise_25
{
  class Program
  {
    public static void Main(string[] args)
    {
            Console.Write("Give a number:\n> ");

            int year = Convert.ToInt32(Console.ReadLine());

            if(year == 1984)
            {
                Console.WriteLine("Orwell");
            }
      
            Console.ReadKey();

    }
  }
}
