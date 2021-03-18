using System;

namespace exercise_31
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number:\n> ");
      int number = Convert.ToInt32(Console.ReadLine());

            int reminder = number % 2;

            if(reminder == 0)
            {
                Console.WriteLine("It is even.");
            }
            else
            {
                Console.WriteLine("It is odd.");
            }
            Console.ReadKey();
    }
  }
}
