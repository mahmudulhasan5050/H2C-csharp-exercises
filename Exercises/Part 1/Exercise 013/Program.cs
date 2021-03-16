using System;

namespace exercise_13
{
  class Program
  {
    public static void Main(string[] args)
    {
      Console.Write("Give a number!\n> ");

            string userInput = Console.ReadLine();
            double doubleValue = Convert.ToDouble(userInput);

            Console.WriteLine("You gave " + doubleValue);
            Console.ReadKey();

    }
  }
}
